using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spend_Smart
{
    public partial class SavingsModal : Form
    {

        public static bool isAdd;
        public static int savingID;
        readonly string conString = Properties.Resources.ConnectionString;

        public SavingsModal()
        {
            InitializeComponent();
            if (isAdd)
            {
                ModalTitle.Text = "ADD SAVING";
                AddSaving.Text = "ADD SAVING";
            }
            else
            {
                ModalTitle.Text = "UPDATE SAVING";
                AddSaving.Text = "UPDATE SAVING";
                GetSaving();
            }

            CenterControl(ModalTitle, horizontal: true, vertical: false);
        }

        private void AddSaving_Click(object sender, EventArgs e)
        {

            if (ValidateFields())
            {
                if (isAdd)
                {
                    InsertSaving();
                }
                else
                {
                    UpdateSaving();
                }
            }
        }

        private void InsertSaving()
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Savings (UserId, Goal, AmountSaved, TargetAmount, Status) VALUES (@UserId, @Goal, @AmountSaved, @TargetAmount, @Status)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);
                        cmd.Parameters.AddWithValue("@Goal", SavingName.Text);
                        cmd.Parameters.AddWithValue("@AmountSaved", Convert.ToInt32(AmountSaved.Text));
                        cmd.Parameters.AddWithValue("@TargetAmount", Convert.ToInt32(Amount.Text));
                        cmd.Parameters.AddWithValue("@Status", Convert.ToInt32(AmountSaved.Text) >= Convert.ToInt32(Amount.Text)?1:0);

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

        private void UpdateSaving()
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Savings SET Goal = @Goal, AmountSaved = @AmountSaved, TargetAmount = @TargetAmount, Status = @Status WHERE SavingId = @SavingId AND UserId = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SavingId", savingID);
                        cmd.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);
                        cmd.Parameters.AddWithValue("@Goal", SavingName.Text);
                        cmd.Parameters.AddWithValue("@AmountSaved", Convert.ToInt32(AmountSaved.Text));
                        cmd.Parameters.AddWithValue("@TargetAmount", Convert.ToInt32(Amount.Text));
                        cmd.Parameters.AddWithValue("@Status", Convert.ToInt32(AmountSaved.Text) >= Convert.ToInt32(Amount.Text) ? 1 : 0);

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

        private void GetSaving()
        {
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Goal, AmountSaved, TargetAmount, Status FROM Savings WHERE SavingId = @SavingId AND UserId = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SavingId", savingID);
                        cmd.Parameters.AddWithValue("@UserId", Properties.Settings.Default.UserId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SavingName.Text = reader["Goal"].ToString();
                                Amount.Text = reader["TargetAmount"].ToString();
                                AmountSaved.Text = reader["AmountSaved"].ToString();
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

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(SavingName.Text) ||
                string.IsNullOrWhiteSpace(Amount.Text) ||
                string.IsNullOrWhiteSpace(AmountSaved.Text))
            {
                MessageBox.Show("Please fill in every field!");
                return false;
            }

            if (!Regex.IsMatch(SavingName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Saving Name must contain only alphabets and spaces!");
                return false;
            }

            if (Convert.ToInt32(Amount.Text) <= 0 || Convert.ToInt32(AmountSaved.Text) <= 0)
            {
                MessageBox.Show("Amount must be Greater than 1");
                return false;
            }
            return true;
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
