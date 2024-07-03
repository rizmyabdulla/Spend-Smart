using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Spend_Smart
{
    public partial class ExpenseModal : Form
    {
        readonly string conString = "server=localhost;uid=root;pwd=;database=spend_smart";

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
        }

        private void AddExpense_Click(object sender, EventArgs e)
        {
            InsertExpense();
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

                    string query = "INSERT INTO expenses (UserId, Category, SubCategory, Amount, IsRecurring) VALUES (@UserId, @Category, @SubCategory, @Amount, @IsRecurring)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);
                        cmd.Parameters.AddWithValue("@Category", MainCat.Text);
                        cmd.Parameters.AddWithValue("@SubCategory", SubCat.Text);
                        cmd.Parameters.AddWithValue("@Amount", Amount.Text);
                        cmd.Parameters.AddWithValue("@IsRecurring", Recuring.Checked?1:0);

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
    }
}
