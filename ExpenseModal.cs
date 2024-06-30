using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Spend_Smart
{
    public partial class ExpenseModal : Form
    {
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
            this.Close();
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
    }
}
