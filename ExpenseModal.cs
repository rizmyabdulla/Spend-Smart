using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Spend_Smart
{
    public partial class ExpenseModal : Form
    {
        public static bool isAdd;
        public static int expenseID;
        readonly string conString = Properties.Resources.ConnectionString;

        private readonly Dictionary<int, List<string>> categories = new Dictionary<int, List<string>>()
        {
            { 0, new List<string> { "Housing", "Utilities", "Food", "Transportation", "Healthcare" } },
            { 1, new List<string> { "Entertainment", "Recreation", "Dining Out", "Shopping" } },
            { 2, new List<string> { "Emergency Fund", "Retirement", "Investments" } },
            { 3, new List<string> { "Credit Cards", "Loans" } },
            { 4, new List<string> { "Gifts and Donations", "Education", "Insurance", "Other" } }
        };

        public ExpenseModal()
        {
            InitializeComponent();

            if (isAdd)
            {
                ModalTitle.Text = "ADD EXPENSE";
                AddExpense.Text = "ADD EXPENSE";
            }
            else
            {
                ModalTitle.Text = "UPDATE EXPENSE";
                AddExpense.Text = "UPDATE EXPENSE";
                GetExpense();
            }

            CenterControl(ModalTitle, horizontal: true, vertical: false);
        }

        private void AddExpense_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                InsertExpense();
            }
            else
            {
                UpdateExpense();
            }
        }

        private void MainCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSubCategories(MainCat.SelectedIndex);
        }

        private void UpdateSubCategories(int selectedIndex)
        {
            SubCat.Items.Clear();
            SubCat.Text = string.Empty;

            if (categories.ContainsKey(selectedIndex))
            {
                foreach (var item in categories[selectedIndex])
                {
                    SubCat.Items.Add(item);
                }
            }
        }

        private void InsertExpense()
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO expenses (UserId, Category, SubCategory, Name,  Amount, IsRecurring) VALUES (@UserId, @Category, @SubCategory, @Name, @Amount, @IsRecurring)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);
                        cmd.Parameters.AddWithValue("@Category", MainCat.Text);
                        cmd.Parameters.AddWithValue("@SubCategory", SubCat.Text);
                        cmd.Parameters.AddWithValue("@Name", NameBox.Text);
                        cmd.Parameters.AddWithValue("@Amount", Amount.Text);
                        cmd.Parameters.AddWithValue("@IsRecurring", Recuring.Checked ? 1 : 0);

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

        private void UpdateExpense()
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Expenses SET Category = @Category, SubCategory = @SubCategory, Name = @Name, Amount = @Amount, IsRecurring = @IsRecurring WHERE ExpenseId = @ExpenseId AND UserId = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ExpenseId", expenseID);
                        cmd.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);
                        cmd.Parameters.AddWithValue("@Category", MainCat.Text);
                        cmd.Parameters.AddWithValue("@SubCategory", SubCat.Text);
                        cmd.Parameters.AddWithValue("@Name", NameBox.Text);
                        cmd.Parameters.AddWithValue("@Amount", Amount.Text);
                        cmd.Parameters.AddWithValue("@IsRecurring", Recuring.Checked ? 1 : 0);

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

        private void GetExpense()
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Category, SubCategory, Name, Amount, IsRecurring FROM Expenses WHERE ExpenseId = @ExpenseId AND UserId = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ExpenseId", expenseID);
                        cmd.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MainCat.Text = reader["Category"].ToString();
                                SubCat.Text = reader["SubCategory"].ToString();
                                NameBox.Text = reader["Name"].ToString();
                                Amount.Text = reader["Amount"].ToString();
                                Recuring.Checked = Convert.ToBoolean(reader["IsRecurring"]);
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
