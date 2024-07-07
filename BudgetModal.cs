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
    public partial class BudgetModal : Form
    {

        public static bool isAdd;
        public static int budgetID;
        readonly string conString = Properties.Resources.ConnectionString;

        List<string> Expenses = new List<string>();


        public BudgetModal()
        {
            InitializeComponent();
            if (isAdd)
            {
                ModalTitle.Text = "ADD BUDGET";
                AddBudget.Text = "ADD BUDGET";
            }
            else
            {
                ModalTitle.Text = "UPDATE BUDGET";
                AddBudget.Text = "UPDATE BUDGET";
                GetBudget();
            }

            CenterControl(ModalTitle, horizontal: true, vertical: false);
            LoadExpensesList();
        }

        private void LoadExpensesList()
        {
            List<string> expensesList = GetExpensesList();

            foreach (string expense in expensesList)
            {
                ExpenseChooser.Items.Add(expense);
            }
        }

        private List<string> GetExpensesList()
        {
            List<string> expensesList = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT DISTINCT Name FROM Expenses WHERE UserId = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                expensesList.Add(reader.GetString("Name"));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return expensesList;
        }

        private void AddBudget_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                InsertBudget();
            }
            else
            {
                UpdateBudgets();
            }
        }

        private void InsertBudget()
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO budgets (UserId, ExpenseName, Amount, DueDate, IsRecurring) VALUES (@UserId, @ExpenseName, @Amount, @DueDate, @IsRecurring)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);
                        cmd.Parameters.AddWithValue("@ExpenseName", ExpenseChooser.Text);
                        cmd.Parameters.AddWithValue("@Amount", Amount.Text);
                        if (DateTime.TryParse(DueDate.Text, out DateTime dueDate))
                        {
                            cmd.Parameters.AddWithValue("@DueDate", dueDate);
                        }
                        else
                        {
                            MessageBox.Show("Invalid date format. Please enter a valid date.");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@IsRecurring", Recurring.Checked ? 1 : 0);

                        cmd.ExecuteNonQuery();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void UpdateBudgets()
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Budgets SET ExpenseName = @ExpenseName, Amount = @Amount, DueDate = @DueDate, IsRecurring = @IsRecurring WHERE BudgetId = @BudgetId AND UserId = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@BudgetId", budgetID);
                        cmd.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);
                        cmd.Parameters.AddWithValue("@ExpenseName", ExpenseChooser.Text);
                        cmd.Parameters.AddWithValue("@Amount", Amount.Text);
                        if (DateTime.TryParse(DueDate.Text, out DateTime dueDate))
                        {
                            cmd.Parameters.AddWithValue("@DueDate", dueDate);
                        }
                        else
                        {
                            MessageBox.Show("Invalid date format. Please enter a valid date.");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@IsRecurring", Recurring.Checked ? 1 : 0);

                        cmd.ExecuteNonQuery();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void GetBudget()
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT ExpenseName, Amount, DueDate, IsRecurring FROM Budgets WHERE BudgetId = @BudgetId AND UserId = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@BudgetId", budgetID);
                        cmd.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ExpenseChooser.Text = reader["ExpenseName"].ToString();
                                Amount.Text = reader["Amount"].ToString();
                                DueDate.Text = reader["DueDate"].ToString();
                                Recurring.Checked = Convert.ToBoolean(reader["IsRecurring"]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void CenterControl(Control control, bool horizontal, bool vertical)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            int controlWidth = control.Width;
            int controlHeight = control.Height;

            int newX = control.Location.X;
            int newY = control.Location.Y;

            if (horizontal)
            {
                newX = (formWidth - controlWidth) / 2;
            }

            if (vertical)
            {
                newY = (formHeight - controlHeight) / 2;
            }

            control.Location = new Point(newX, newY);
        }
    }
}
