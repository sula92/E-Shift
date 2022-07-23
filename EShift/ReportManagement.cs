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

namespace EShift
{
    public partial class ReportManagement : Form
    {
        private DataTable dt;
        private MySqlConnection connection = DBConnection.getInstance().getConnection();

        public ReportManagement()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void ReportManagement_Load(object sender, EventArgs e)
        {
            loadTableDta();
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Blue;
            //dataGridView1.Columns[5].DefaultCellStyle.ForeColor = Color.Blue;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonShadow;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;


            List<String> status = new List<String>() { "pending", "cancel", "approved", "completed" };
            foreach (string role in status)
            {
                cmbStatus.Items.Add(role);
            }

            if (connection != null)
            {
                connection.Close();
            }

            using (MySqlCommand cmd = new MySqlCommand("select * From customer ", connection))
            {
                cmbCustomer.Items.Add("");
                connection.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    
                    String uid = reader["id"].ToString();

                    cmbCustomer.Items.Add(uid);

                }

                reader.Close();
            }
        }

        //load data to the table
        private void loadTableDta()
        {
            dt = GetCustomerList();
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
        }

        // fetch data from the db
        private DataTable GetCustomerList()
        {
            if (connection != null)
            {
                connection.Close();
            }

            Boolean b = dateTimePicker1.Value.ToString() == DateTime.Now.ToString() && dateTimePicker2.Value.ToString() == DateTime.Now.ToString() && cmbStatus.Text == "" && cmbCustomer.Text == "";
         
            String sql="";

            if (b)
            {
                sql = "select * From job";
            }    
            else
            {
                sql = "select * From job  WHERE  `status`  = '" + cmbStatus.Text + "' AND  `customer_id`  = '" + cmbCustomer.Text + "'";
            }
           
            DataTable dtCustomer = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
            {
                connection.Open();
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                dtCustomer.Load(mySqlDataReader);
            }
            return dtCustomer;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTableDta();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            loadTableDta();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            loadTableDta();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTableDta();
        }

        private void refresh_report()
        {
            cmbCustomer.Text = "";
            cmbStatus.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            loadTableDta();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            refresh_report();
        }
    }
}
