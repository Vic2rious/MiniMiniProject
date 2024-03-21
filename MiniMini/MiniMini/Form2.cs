using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniMini
{
    public partial class Form2 : Form
    {
        bool CPU_ON, GPU_ON, RAM_ON, Availabilty_ON = false;
        public Form2(string username)
        {
            InitializeComponent();
            label1.Text = "Welcome " + username;

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC14\SQLEXPRESS; Initial Catalog=phoney; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // SQL query to select rooms based on the selected room type
                string query = "select ID, CPU, GPU, RAM, availability from Computers ";

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

        private void button1_Click(object sender, EventArgs e) // exit
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // search
        {

        }

        public void Search()
        {
            // Establish a connection to the database
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC14\SQLEXPRESS; Initial Catalog=phoney; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // SQL query to select rooms based on the selected room type
                string query = selectQuery();

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                if (CPU_ON)
                {
                    cmd.Parameters.AddWithValue("@CPUBrand", CPUbox.SelectedItem.ToString());
                }
                if (GPU_ON)
                {
                    cmd.Parameters.AddWithValue("@GPUBrand", GPUbox.SelectedItem.ToString());
                }
                if (RAM_ON)
                {
                    cmd.Parameters.AddWithValue("@RAM", RAMbox.SelectedItem.ToString());
                }
                if (Availabilty_ON)
                {
                    cmd.Parameters.AddWithValue("@Availability", AvailabilityBox.SelectedItem.ToString());
                }

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private string selectQuery()
        {

            string cpu, gpu, ram, availability;
            string Table = "Computers";
            string selection = "ID, CPU, GPU, RAM, availability";
            cpu = CPUbox.SelectedItem == null ? "" : "CPUBrand = @CPUBrand";
            CPU_ON = CPUbox.SelectedItem == null ? false : true;

            gpu = GPUbox.SelectedItem == null ? "" : "AND GPUBrand = @GPUBrand";
            GPU_ON = GPUbox.SelectedItem == null ? false : true;

            ram = RAMbox.SelectedItem == null ? "" : "AND RAM = @RAM";
            RAM_ON = RAMbox.SelectedItem == null ? false : true;

            availability = AvailabilityBox.SelectedItem == null ? "" : "AND availability = @Availability";
            Availabilty_ON = AvailabilityBox.SelectedItem == null ? false : true;

            return CPU_ON ? $"select {selection} from {Table} where {cpu} {gpu} {ram} {availability}" :
                GPU_ON ? $"select {selection} from {Table} where GPUBrand = @GPUBrand {ram} {availability}" :
                RAM_ON ? $"select {selection} from {Table} where RAM = @RAM {availability}" :
                RAM_ON ? $"select {selection} from {Table} where RAM = @RAM {availability}" :
                Availabilty_ON ? $"select {selection} from {Table} where availability = @Availability" :
                         $"select {selection} from {Table}";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            CPUbox.SelectedItem = null;
            CPUbox.Text = "CPU";

            GPUbox.SelectedItem = null;
            GPUbox.Text = "GPU";

            RAMbox.SelectedItem = null;
            RAMbox.Text = "RAM";

            AvailabilityBox.SelectedItem = null;
            AvailabilityBox.Text = "Availability";
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void AvailabilityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void RAMbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void GPUbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void CPUbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
