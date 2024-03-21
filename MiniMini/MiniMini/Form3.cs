using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniMini
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC14\SQLEXPRESS; Initial Catalog=phoney; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // SQL query to select rooms based on the selected room type
                string query = "select * from Reservations ";

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstNameBox.Text) ||
                string.IsNullOrEmpty(EmailBox.Text) ||
                string.IsNullOrEmpty(LastNameBox.Text) ||
                string.IsNullOrEmpty(PhoneBox.Text))
            {
                MessageBox.Show("Please fill all gaps!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (!IsReserved(IDBox.Text))
                {
                    Query("INSERT INTO Reservations VALUES" +
                      $" ('{IDBox.Text}'," +
                      $" '{PhoneBox.Text}'," +
                      $" '{FirstNameBox.Text}'," +
                      $" '{LastNameBox.Text}'," +
                      $" '{EmailBox.Text}'); ");

                    Query($"UPDATE Computers SET availability = 'reserved' WHERE ID = '{IDBox.Text}';");

                    RefreshForm();
                }
                else
                {
                    MessageBox.Show("The computer is already reserved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Query($"UPDATE Computers SET availability = 'available' WHERE ID = '{IDBox.Text}';");
            Query($"DELETE FROM Reservations WHERE ID = '{IDBox.Text}'");

            RefreshForm();
        }

        public void Query(string query)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC14\SQLEXPRESS; Initial Catalog=phoney; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // SQL query to select rooms based on the selected room type

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Went Wrong! Invalid ID?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void RefreshForm()
        {
            this.Close();
            new Form3().Show();
        }

        public bool IsReserved(string ID)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC14\SQLEXPRESS; Initial Catalog=phoney; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection


                string loginQuery = $"SELECT COUNT(1) FROM Computers WHERE ID = '{ID}' AND availability = 'reserved'";
                using (SqlCommand loginCmd = new SqlCommand(loginQuery, sqlCon))
                {

                    int count = Convert.ToInt32(loginCmd.ExecuteScalar());

                    return count == 1 ? true : false;


                }
            }
        }

        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailBox_Validating(object sender, CancelEventArgs e)
        {
            if (EmailBox.Text != string.Empty)
            {
                if (!IsValidEmail(EmailBox.Text))
                {
                    MessageBox.Show("email not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EmailBox.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        private void PhoneBox_Validating(object sender, CancelEventArgs e)
        {
            try { 
                int x = Int32.Parse(PhoneBox.Text);
            } catch (Exception ex) {

                MessageBox.Show("phone not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PhoneBox.SelectAll();
                e.Cancel = true;
            }
        }
    }
}
