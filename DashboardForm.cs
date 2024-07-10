using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using MySql.Data.MySqlClient;
using SkiaSharp;

namespace Spend_Smart
{
    public partial class DashboardForm : Form
    {
        private readonly PieChart pieChart;
        private readonly string conString = Properties.Resources.ConnectionString;

        public DashboardForm()
        {
            InitializeComponent();
            pieChart = new PieChart
            {
                Location = new Point(20, 18),
                Size = new Size(250, 250),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            /*Pie Chart */

            panel15.Controls.Add(pieChart);

            LoadDashboardData();
            LoadBudgetStatusChart();
            LoadTopExpensesChart();
        }

        private void LoadTopExpensesChart()
        {
            DataTable topExpenses = GetTopExpenses(4);

            if (topExpenses.Rows.Count < 4)
            {
                cartesianChart1.Visible = false;
                ExpenseMessageLabel.Visible = true;
            }
            else
            {
                cartesianChart1.Visible = true;
                ExpenseMessageLabel.Visible = false;

                var expenseNames = new List<string>();
                var expenseAmounts = new List<double>();

                foreach (DataRow row in topExpenses.Rows)
                {
                    expenseNames.Add(row["Name"].ToString());
                    expenseAmounts.Add(Convert.ToDouble(row["Amount"]));
                }

                cartesianChart1.Series = new ObservableCollection<ISeries>
                {
                    new ColumnSeries<double>
                    {
                        Values = new ObservableCollection<double>(expenseAmounts),
                        Fill = new SolidColorPaint(new SKColor(134, 146, 255))
                    }
                };

                cartesianChart1.XAxes = new List<Axis>
                {
                    new Axis { Labels = expenseNames.ToArray(), IsVisible = false }
                };

                cartesianChart1.YAxes = new List<Axis>
                {
                    new Axis { Labeler = Labelers.Currency }
                };
            }
        }

        private void LoadDashboardData()
        {
            var data = GetDashboardData();

            if (data != null)
            {
                TotalExpensesLabel.Text = $"${data.TotalExpenses}";
                TotalIncomeLabel.Text = $"${data.TotalIncome}";
                NetSavingsLabel.Text = $"${data.NetSavings}";
                SavingGoalsLabel.Text = $"{data.SavingGoalsCount}";
            }
        }

        private void LoadBudgetStatusChart()
        {
            DataTable budgetData = GetBudgetData();

            if (budgetData.Rows.Count < 2)
            {
                pieChart.Visible = false;
                BudgetMessageLabel.Visible = true;
            }
            else
            {
                pieChart.Visible = true;
                BudgetMessageLabel.Visible = false;

                var seriesList = new List<PieSeries<double>>();

                foreach (DataRow row in budgetData.Rows)
                {
                    seriesList.Add(new PieSeries<double>
                    {
                        Name = row["ExpenseName"].ToString(),
                        Values = new double[] { Convert.ToDouble(row["Amount"]) },
                        ToolTipLabelFormatter = point => $"${point.Coordinate.PrimaryValue}"
                    });
                }

                pieChart.Series = seriesList.ToArray();
            }
        }

        private DataTable GetTopExpenses(int topN)
        {
            DataTable expensesTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                string query = $"SELECT Name, Amount FROM expenses WHERE UserId = @UserId ORDER BY Amount DESC LIMIT {topN}";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(expensesTable);
                }
            }

            return expensesTable;
        }

        private DataTable GetBudgetData()
        {
            DataTable budgetTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                string query = "SELECT ExpenseName, Amount FROM budgets WHERE UserId = @UserId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(budgetTable);
                }
            }

            return budgetTable;
        }

        private DashboardData GetDashboardData()
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                string query = @"
                    SELECT 
                        (SELECT IFNULL(SUM(Amount), 0) FROM expenses WHERE UserId = @UserId) AS TotalExpenses,
                        (SELECT IFNULL(SUM(Amount), 0) FROM income WHERE UserId = @UserId) AS TotalIncome,
                        (SELECT COUNT(*) FROM savings WHERE UserId = @UserId) AS SavingGoalsCount";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);

                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var data = new DashboardData
                            {
                                TotalExpenses = reader.GetDecimal("TotalExpenses"),
                                TotalIncome = reader.GetDecimal("TotalIncome"),
                                SavingGoalsCount = reader.GetInt32("SavingGoalsCount")
                            };
                            data.NetSavings = data.TotalIncome - data.TotalExpenses;
                            return data;
                        }
                    }
                }
            }
            return null;
        }
    }

    public class DashboardData
    {
        public decimal TotalExpenses { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal NetSavings { get; set; }
        public int SavingGoalsCount { get; set; }
    }
}
