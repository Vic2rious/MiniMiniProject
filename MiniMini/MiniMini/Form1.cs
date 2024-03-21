using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MiniMini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC14\SQLEXPRESS; Initial Catalog=phoney; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection


                string loginQuery = "SELECT COUNT(1) FROM Loginfo WHERE Username=@Username AND Password=@Password";
                using (SqlCommand loginCmd = new SqlCommand(loginQuery, sqlCon))
                {


                    loginCmd.Parameters.AddWithValue("@Username", usernameBox.Text);
                    loginCmd.Parameters.AddWithValue("@Password", PasswordBox.Text);

                    int count = Convert.ToInt32(loginCmd.ExecuteScalar());

                    if (count == 1)
                    {

                        Form2 SearchForm = new Form2(usernameBox.Text);
                        SearchForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

        }
    }
}