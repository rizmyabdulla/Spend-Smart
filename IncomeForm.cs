using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using MySql.Data.MySqlClient;


namespace Spend_Smart
{
    public partial class IncomeForm : Form
    {

        readonly string conString = Properties.Resources.ConnectionString;
        int sourcesCount = 0;
        int totalIncomeAmount = 0;
        public IncomeForm()
        {
            InitializeComponent();
            RefreshIncomes();
        }


        private DataTable GetIncomes()
        {
            DataTable incomeTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                string query = "SELECT IncomeId, Source, Amount, IsRecurring FROM income WHERE UserId = @UserId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(incomeTable);
                }
            }

            return incomeTable;
        }

        private void PopulateIncomeTable(DataTable incomeTable)
        {

            sourcesCount = incomeTable.Rows.Count;

            IncomeTable.Controls.Clear();

            IncomeTable.Controls.Add(new Label() { Text = "Income Source", Font = new Font("Arial", 11.25F, FontStyle.Bold), Margin = new Padding(10, 10, 10, 10), AutoSize = true }, 0, 0);
            IncomeTable.Controls.Add(new Label() { Text = "Amount", Font = new Font("Arial", 11.25F, FontStyle.Bold), Margin = new Padding(10, 10, 10, 10), AutoSize = true }, 1, 0);
            IncomeTable.Controls.Add(new Label() { Text = "Recurring", Font = new Font("Arial", 11.25F, FontStyle.Bold), Margin = new Padding(10, 10, 10, 10), AutoSize = true }, 2, 0);
            IncomeTable.Controls.Add(new Label() { Text = "Action", Font = new Font("Arial", 11.25F, FontStyle.Bold), Margin = new Padding(10, 10, 10, 10), AutoSize = true }, 3, 0);

            for (int i = 0; i < incomeTable.Rows.Count; i++)
            {
                var row = incomeTable.Rows[i];

                totalIncomeAmount += Convert.ToInt32(row["Amount"]);

                IncomeTable.Controls.Add(new Label() { Text = row["Source"].ToString(), Font = new Font("Arial", 9.75F, FontStyle.Regular), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 0, i + 1);
                IncomeTable.Controls.Add(new Label() { Text = "$" + Math.Round(Convert.ToDouble(row["Amount"])).ToString(), Font = new Font("Arial", 9.75F, FontStyle.Regular), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 1, i + 1);
                IncomeTable.Controls.Add(new Label() { Text = Convert.ToInt32(row["IsRecurring"]) == 1 ? "YES" : "NO", Font = new Font("Arial", 9.75F, FontStyle.Regular), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 2, i + 1);

                FlowLayoutPanel actionPanel = new FlowLayoutPanel()
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight
                };

                LinkLabel editLink = new LinkLabel()
                {
                    Text = "EDIT",
                    Tag = row["IncomeId"],
                    Font = new Font("Arial", 10F, FontStyle.Regular),
                    LinkColor = Color.FromArgb(134, 146, 255),
                    Margin = new Padding(5, 5, 0, 0),
                    AutoSize = true
                };
                editLink.Click += EditLink_Click;
                actionPanel.Controls.Add(editLink);


                LinkLabel deleteLink = new LinkLabel()
                {
                    Text = "DELETE",
                    Tag = row["IncomeId"],
                    Font = new Font("Arial", 10F, FontStyle.Regular),
                    LinkColor = Color.FromArgb(134, 146, 255),
                    Margin = new Padding(5, 5, 0, 0),
                    AutoSize = true
                };
                deleteLink.Click += DeleteLink_Click;
                actionPanel.Controls.Add(deleteLink);

                IncomeTable.Controls.Add(actionPanel, 3, i + 1);
            }
        }

        private void EditLink_Click(object sender, EventArgs e)
        {
            if (sender is LinkLabel link)
            {
                int incomeId = (int)link.Tag;
                IncomeModal.isAdd = false;
                IncomeModal.incomeID = incomeId;

                Form fm = new IncomeModal();
                fm.ShowDialog();

                RefreshIncomes();

            }
        }

        private void DeleteLink_Click(object sender, EventArgs e)
        {
            if (sender is LinkLabel link)
            {
                int incomeId = (int)link.Tag;

                if (MessageBox.Show("Do you really want to delete this income?", "Confirm Income delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteIncome(incomeId);
                    RefreshIncomes();
                }
            }
        }

        private void DeleteIncome(int incomeId)
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM income WHERE IncomeId = @IncomeId AND UserId = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IncomeId", incomeId);
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

        private void LoadPieChart()
        {
            DataTable incomeData = GetIncomes();

            if (incomeData.Rows.Count < 2)
            {
                IncomeChart.Visible = false;
                ChartMessageLabel.Visible = true;
            }
            else
            {
                IncomeChart.Visible = true;
                ChartMessageLabel.Visible = false;

                var seriesList = new List<PieSeries<double>>();

                foreach (DataRow row in incomeData.Rows)
                {
                    seriesList.Add(new PieSeries<double>
                    {
                        Name =  row["Source"].ToString(),
                        Values = new double[] { Convert.ToInt32(row["Amount"]) },
                        ToolTipLabelFormatter = point => $"${point.Coordinate.PrimaryValue}"
                    });
                }

                IncomeChart.Series = seriesList.ToArray();
            }
        }

        public void RefreshIncomes()
        {
            DataTable IncomeTable = GetIncomes();
            PopulateIncomeTable(IncomeTable);
            LoadPieChart();

            SourcesCount.Text = sourcesCount.ToString();
            TotalIncomeAmount.Text = "$" + totalIncomeAmount.ToString();
        }
    }
}
