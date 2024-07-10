using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Spend_Smart
{
    public partial class ExpensesForm : Form
    {
        readonly string conString = Properties.Resources.ConnectionString;
        public ExpensesForm()
        {
            InitializeComponent();

            RefreshExpenses();
        }

        private DataTable GetExpenses()
        {
            DataTable expensesTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                string query = "SELECT ExpenseId, Category, Amount, SubCategory, IsRecurring FROM Expenses WHERE UserId = @UserId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(expensesTable);
                }
            }

            return expensesTable;
        }

        private void PopulateExpenseTable(DataTable expensesTable)
        {
            ExpenseTable.Controls.Clear();

            ExpenseTable.Controls.Add(new Label() { Text = "Is Recurring", Font = new Font("Arial", 9F, FontStyle.Bold), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 0, 0);
            ExpenseTable.Controls.Add(new Label() { Text = "Category", Font = new Font("Arial", 9F, FontStyle.Bold), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 1, 0);
            ExpenseTable.Controls.Add(new Label() { Text = "Sub Category", Font = new Font("Arial", 9F, FontStyle.Bold), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 2, 0);
            ExpenseTable.Controls.Add(new Label() { Text = "Amount", Font = new Font("Arial", 9F, FontStyle.Bold), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 3, 0);
            ExpenseTable.Controls.Add(new Label() { Text = "Action", Font = new Font("Arial", 9F, FontStyle.Bold), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 4, 0);

            // Add rows
            for (int i = 0; i < expensesTable.Rows.Count; i++)
            {
                var row = expensesTable.Rows[i];
                ExpenseTable.Controls.Add(new Label() { Text = Convert.ToInt32(row["IsRecurring"]) == 1 ? "YES" : "NO", Font = new Font("Arial", 9F, FontStyle.Regular), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 0, i + 1);
                ExpenseTable.Controls.Add(new Label() { Text = row["Category"].ToString(), Font = new Font("Arial", 8.25F, FontStyle.Regular), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 1, i + 1);
                ExpenseTable.Controls.Add(new Label() { Text = row["SubCategory"].ToString(), Font = new Font("Arial", 8.25F, FontStyle.Regular), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 2, i + 1);
                ExpenseTable.Controls.Add(new Label() { Text = "$" + Math.Round(Convert.ToDouble(row["Amount"])).ToString(), Font = new Font("Arial", 8.25F, FontStyle.Regular), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 3, i + 1);

                FlowLayoutPanel actionPanel = new FlowLayoutPanel()
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight
                };

                LinkLabel editLink = new LinkLabel()
                {
                    Text = "EDIT",
                    Tag = row["ExpenseId"],
                    Font = new Font("Arial", 10F, FontStyle.Regular),
                    LinkColor = Color.FromArgb(134, 146, 255),
                    Margin = new Padding(10, 5, 0, 0),
                    AutoSize = true
                };
                editLink.Click += EditLink_Click;
                actionPanel.Controls.Add(editLink);


                LinkLabel deleteLink = new LinkLabel()
                {
                    Text = "DELETE",
                    Tag = row["ExpenseId"],
                    Font = new Font("Arial", 10F, FontStyle.Regular),
                    LinkColor = Color.FromArgb(134, 146, 255),
                    Margin = new Padding(5, 5, 0, 0),
                    AutoSize = true
                };
                deleteLink.Click += DeleteLink_Click;
                actionPanel.Controls.Add(deleteLink);

                ExpenseTable.Controls.Add(actionPanel, 4, i + 1);
            }
        }

        private void EditLink_Click(object sender, EventArgs e)
        {
            if (sender is LinkLabel link)
            {
                int expenseId = (int)link.Tag;
                ExpenseModal.isAdd = false;
                ExpenseModal.expenseID = expenseId;

                Form fm = new ExpenseModal();
                fm.ShowDialog();

                RefreshExpenses();
            }
        }

        private void DeleteLink_Click(object sender, EventArgs e)
        {
            if (sender is LinkLabel link)
            {
                int expenseId = (int)link.Tag;

                if (MessageBox.Show("Do you really want to delete this expense?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteExpense(expenseId);

                    RefreshExpenses();
                }
            }
        }

        private void DeleteExpense(int expenseId)
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM Expenses WHERE ExpenseId = @ExpenseId AND UserId = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ExpenseId", expenseId);
                        cmd.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void LoadExpenseChart(DataTable expensesTable)
        {
            if (expensesTable.Rows.Count >= 4)
            {
                // Group expenses by category and sum the amounts
                var categorySums = expensesTable.AsEnumerable()
                    .GroupBy(row => row.Field<string>("Category"))
                    .Select(g => new
                    {
                        Category = g.Key,
                        TotalAmount = g.Sum(row => row.Field<decimal>("Amount"))
                    }).ToList();

                // Prepare data for the chart
                var categories = categorySums.Select(c => c.Category).ToArray();
                var amounts = categorySums.Select(c => (int)c.TotalAmount).ToArray();

                ExpensesChart.Series = new ObservableCollection<ISeries>
                {
                    new ColumnSeries<int> { Values = new ObservableCollection<int>(amounts), Fill = new SolidColorPaint(new SKColor(134, 146, 255)) }
                };

                ExpensesChart.XAxes = new List<Axis>
                {
                    new Axis { Labels = categories, IsVisible = true }
                };

                ExpensesChart.YAxes = new List<Axis> { new Axis { Labeler = Labelers.Currency } };
            }
        }

        public void RefreshExpenses()
        {
            DataTable expensesTable = GetExpenses();
            PopulateExpenseTable(expensesTable);
            LoadExpenseChart(expensesTable);
        }
    }
}
