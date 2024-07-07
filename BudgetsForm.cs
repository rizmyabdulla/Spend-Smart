using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spend_Smart
{
    public partial class BudgetsForm : Form
    {
        string conString = Properties.Resources.ConnectionString;

        public BudgetsForm()
        {
            InitializeComponent();

            BudgetsCount.Text = GetTotalBudgetCount().ToString();
            SumOfBudgets.Text = "$" + Math.Round(GetTotalBudgetAmount()).ToString();
            DataTable budgetsTable = GetBudgets();

            PopulateBudgetTable(budgetsTable);

        }

        private void AddBudgetBtn_Click(object sender, EventArgs e)
        {
            BudgetModal.isAdd = true;
            Form fm = new BudgetModal();
            fm.ShowDialog();
        }

        private DataTable GetBudgets()
        {
            DataTable expensesTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                string query = "SELECT BudgetId, ExpenseName, Amount, DueDate, IsRecurring FROM Budgets WHERE UserId = @UserId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(expensesTable);
                }
            }

            return expensesTable;
        }

        private void PopulateBudgetTable(DataTable budgetsTable)
        {

            BudgetTable.Controls.Clear();

            BudgetTable.Controls.Add(new Label() { Text = "Budget Name", Font = new Font("Arial", 10F, FontStyle.Bold), Margin = new Padding(10, 10, 10, 10), AutoSize = true }, 0, 0);
            BudgetTable.Controls.Add(new Label() { Text = "Amount", Font = new Font("Arial", 10F, FontStyle.Bold), Margin = new Padding(10, 10, 10, 10), AutoSize = true }, 1, 0);
            BudgetTable.Controls.Add(new Label() { Text = "Due Date", Font = new Font("Arial", 11F, FontStyle.Bold), Margin = new Padding(10, 10, 10, 10), AutoSize = true }, 2, 0);
            BudgetTable.Controls.Add(new Label() { Text = "Recurring", Font = new Font("Arial", 10F, FontStyle.Bold), Margin = new Padding(10, 10, 10, 10), AutoSize = true }, 3, 0);
            BudgetTable.Controls.Add(new Label() { Text = "Action", Font = new Font("Arial", 10F, FontStyle.Bold), Margin = new Padding(10, 10, 10, 10), AutoSize = true }, 4, 0);

            for (int i = 0; i < budgetsTable.Rows.Count; i++)
            {
                var row = budgetsTable.Rows[i];

                DateTime dateTime = (DateTime)row["DueDate"];

                BudgetTable.Controls.Add(new Label() { Text = row["ExpenseName"].ToString(), Font = new Font("Arial", 9.25F, FontStyle.Regular), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 0, i + 1);
                BudgetTable.Controls.Add(new Label() { Text = "$" + Math.Round(Convert.ToDouble(row["Amount"])).ToString(), Font = new Font("Arial", 9.25F, FontStyle.Regular), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 1, i + 1);
                BudgetTable.Controls.Add(new Label() { Text = dateTime.ToString("yyyy-MM-dd"), Font = new Font("Arial", 9.25F, FontStyle.Regular), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 2, i + 1);
                BudgetTable.Controls.Add(new Label() { Text = Convert.ToInt32(row["IsRecurring"]) == 1 ? "YES" : "NO", Font = new Font("Arial", 9.25F, FontStyle.Regular), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 3, i + 1);

                FlowLayoutPanel actionPanel = new FlowLayoutPanel()
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight
                };

                LinkLabel editLink = new LinkLabel()
                {
                    Text = "EDIT",
                    Tag = row["BudgetId"],
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
                    Tag = row["BudgetId"],
                    Font = new Font("Arial", 10F, FontStyle.Regular),
                    LinkColor = Color.FromArgb(134, 146, 255),
                    Margin = new Padding(5, 5, 0, 0),
                    AutoSize = true
                };
                deleteLink.Click += DeleteLink_Click;
                actionPanel.Controls.Add(deleteLink);

                BudgetTable.Controls.Add(actionPanel, 4, i + 1);
            }
        }

        private void EditLink_Click(object sender, EventArgs e)
        {
            if (sender is LinkLabel link)
            {
                int budgetId = (int)link.Tag;
                BudgetModal.isAdd = false;
                BudgetModal.budgetID = budgetId;

                Form fm = new BudgetModal();
                fm.ShowDialog();

                RefreshExpenses();

            }
        }

        private void DeleteLink_Click(object sender, EventArgs e)
        {
            if (sender is LinkLabel link)
            {
                int budgetId = (int)link.Tag;

                if (MessageBox.Show("Do you really want to delete this budget?", "Confirm Budget delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteBudget(budgetId);
                    RefreshExpenses();
                }
            }
        }

        private void DeleteBudget(int budgetId)
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM Budgets WHERE BudgetId = @BudgetId AND UserId = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@BudgetId", budgetId);
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

        private int GetTotalBudgetCount()
        {
            int count = 0;

            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM budgets WHERE UserId = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return count;
        }

        private decimal GetTotalBudgetAmount()
        {
            decimal totalAmount = 0;

            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT SUM(Amount) FROM budgets WHERE UserId = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);
                        var result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalAmount = Convert.ToDecimal(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return totalAmount;
        }


        public void RefreshExpenses()
        {
            DataTable budgetsTable = GetBudgets();
            PopulateBudgetTable(budgetsTable);
        }

    }
}
