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
    public partial class SavingsForm : Form
    {
        readonly string conString = Properties.Resources.ConnectionString;
        int totalSavings, totalFinishedGoals, ongoingGoals = 0;
        decimal totalSavedAmount = 0;
        public SavingsForm()
        {
            InitializeComponent();

            RefreshSavings();
        }

        private DataTable GetSavings()
        {
            DataTable savingsTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                string query = "SELECT SavingId, Goal, AmountSaved, TargetAmount, Status FROM savings WHERE UserId = @UserId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(savingsTable);
                }
            }

            return savingsTable;
        }

        private void PopulateSavingTable(DataTable savingTable)
        {

            totalSavings = savingTable.Rows.Count;

            SavingTable.Controls.Clear();

            SavingTable.Controls.Add(new Label() { Text = "Goal Name", Font = new Font("Arial", 9F, FontStyle.Bold), Margin = new Padding(10, 10, 10, 10), AutoSize = true }, 0, 0);
            SavingTable.Controls.Add(new Label() { Text = "Amount", Font = new Font("Arial", 9F, FontStyle.Bold), Margin = new Padding(10, 10, 10, 10), AutoSize = true }, 1, 0);
            SavingTable.Controls.Add(new Label() { Text = "Saved Amount", Font = new Font("Arial", 9F, FontStyle.Bold), Margin = new Padding(10, 10, 10, 10), AutoSize = true }, 2, 0);
            SavingTable.Controls.Add(new Label() { Text = "Status", Font = new Font("Arial", 9F, FontStyle.Bold), Margin = new Padding(10, 10, 10, 10), AutoSize = true }, 3, 0);
            SavingTable.Controls.Add(new Label() { Text = "Action", Font = new Font("Arial", 9F, FontStyle.Bold), Margin = new Padding(10, 10, 10, 10), AutoSize = true }, 4, 0);

            for (int i = 0; i < savingTable.Rows.Count; i++)
            {
                var row = savingTable.Rows[i];

                if (Convert.ToInt32(row["Status"]) == 1)
                {
                    totalFinishedGoals += 1;
                }
                else
                {
                    ongoingGoals += 1;
                }

                totalSavedAmount += Convert.ToInt32(row["AmountSaved"]);

                SavingTable.Controls.Add(new Label() { Text = row["Goal"].ToString(), Font = new Font("Arial", 9.75F, FontStyle.Regular), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 0, i + 1);
                SavingTable.Controls.Add(new Label() { Text = "$" + Math.Round(Convert.ToDouble(row["TargetAmount"])).ToString(), Font = new Font("Arial", 9.75F, FontStyle.Regular), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 1, i + 1);
                SavingTable.Controls.Add(new Label() { Text = "$" + Math.Round(Convert.ToDouble(row["AmountSaved"])).ToString(), Font = new Font("Arial", 9.75F, FontStyle.Regular), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 2, i + 1);
                SavingTable.Controls.Add(new Label() { Text = Convert.ToInt32(row["Status"]) == 1 ? "DONE" : "Not Finished", Font = new Font("Arial", 9.25F, FontStyle.Bold), Margin = new Padding(10, 10, 0, 0), AutoSize = true }, 3, i + 1);

                FlowLayoutPanel actionPanel = new FlowLayoutPanel()
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight
                };

                LinkLabel editLink = new LinkLabel()
                {
                    Text = "EDIT",
                    Tag = row["SavingId"],
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
                    Tag = row["SavingId"],
                    Font = new Font("Arial", 10F, FontStyle.Regular),
                    LinkColor = Color.FromArgb(134, 146, 255),
                    Margin = new Padding(5, 5, 0, 0),
                    AutoSize = true
                };
                deleteLink.Click += DeleteLink_Click;
                actionPanel.Controls.Add(deleteLink);

                SavingTable.Controls.Add(actionPanel, 4, i + 1);
            }
        }

        private void EditLink_Click(object sender, EventArgs e)
        {
            if (sender is LinkLabel link)
            {
                int savingId = (int)link.Tag;
                SavingsModal.isAdd = false;
                SavingsModal.savingID = savingId;

                Form fm = new SavingsModal();
                fm.ShowDialog();

                RefreshSavings();

            }
        }

        private void DeleteLink_Click(object sender, EventArgs e)
        {
            if (sender is LinkLabel link)
            {
                int savingId = (int)link.Tag;

                if (MessageBox.Show("Do you really want to delete this Saving Goal?", "Confirm Saving Goal delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteSaving(savingId);
                    RefreshSavings();
                }
            }
        }

        private void DeleteSaving(int savingId)
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM savings WHERE SavingId = @SavingId AND UserId = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SavingId", savingId);
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

        public void RefreshSavings()
        {
            DataTable savingsTable = GetSavings();
            PopulateSavingTable(savingsTable);

            GoalCount.Text = totalSavings.ToString();
            TotFinishedGoals.Text = totalFinishedGoals.ToString();
            OngoingGoalsCount.Text = ongoingGoals.ToString();
            TotSavedAmount.Text = "$" + totalSavedAmount.ToString();
        }
    }
}
