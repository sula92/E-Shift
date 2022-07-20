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
    public partial class ManageUser : Form
    {
        private DataTable dt;
        MySqlConnection connection = DBConnection.getInstance().getConnection();

        public ManageUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            loadTableDta();
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Blue;
           
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


            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            txtPassword.UseSystemPasswordChar = true;

            List<String> roles = new List<String>() { "admin","customer","denied" };
            foreach (string role in roles)
            {
                comboPrivilege.Items.Add(role);
            }

            if (connection != null)
            {
                connection.Close();
            }

            using (MySqlCommand cmd = new MySqlCommand("select * From employee ", connection))
            {
                comboUserId.Items.Add("");
                connection.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                  
                    String eid = reader["id"].ToString();

                    comboUserId.Items.Add(eid);

                }

                reader.Close();
            }

            using (MySqlCommand cmd = new MySqlCommand("select * From customer ", connection))
            {
                
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {


                    String cid = reader["id"].ToString();

                    comboUserId.Items.Add(cid);

                }

                reader.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {              
                txtUserName.Text = dt.Rows[e.RowIndex].Field<String>(1).ToString();
                comboUserId.Text= dt.Rows[e.RowIndex].Field<String>(0).ToString();
                comboPrivilege.Text= dt.Rows[e.RowIndex].Field<String>(2).ToString();

                btnUpdate.Text = "Update";
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Exception has occurred : {0}", ex.Message);
            }
        }

        private void loadTableDta()
        {
            dt = GetCustomerList();
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();


        }

        private DataTable GetCustomerList()
        {
            if (connection != null)
            {
                connection.Close();
            }
            DataTable dtCustomer = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("select * From user", connection))
            {
                connection.Open();
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                dtCustomer.Load(mySqlDataReader);
            }
            return dtCustomer;
        }

        private void clearAll()
        {

            txtPassword.Clear();
            txtUserName.Clear();
            txtUserName.Clear();
            comboPrivilege.Text = "";
            comboUserId.Text = "";
         
            btnUpdate.Text = "Update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();
                String id = comboUserId.Text;
                string deleteCmd = ("Delete from user where id='" + id + "' ");
                MySqlCommand delete_cmd = new MySqlCommand(deleteCmd, connection);

                int res_update = delete_cmd.ExecuteNonQuery();
                connection.Close();
                if (res_update == 1)
                {
                    clearAll();
                    loadTableDta();
                    dataGridView1.Refresh();
                    MessageBox.Show("Record deleted sucessfully...");
                }
                else
                {
                    MessageBox.Show("Failed to remove record...");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Exception has occurred : {0}", ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                connection.Close();
            }

           
            if (btnUpdate.Text == "Update")
            {

                connection.Open();
                string updateCustomer = ("UPDATE `eshift`.`user` SET `user_name`='" + txtUserName.Text + "', `privilege`='" + comboPrivilege.Text + "',  `password`='" + txtPassword.Text + "' WHERE `id`  = '" + comboUserId.Text + "' ");
                MySqlCommand update_cmd = new MySqlCommand(updateCustomer, connection);
                int res_update = update_cmd.ExecuteNonQuery();
                connection.Close();
                if (res_update == 1)
                {
                    loadTableDta();
                    dataGridView1.Refresh();
                    MessageBox.Show("Job updated sucessfully...");
                }
                else
                {
                    MessageBox.Show("Failed to update record....");
                }

            }
            else
            {

                connection.Open();
                MySqlCommand com_customer = new MySqlCommand("insert into user (userId,user_name,privilege,password) values ('" + comboUserId.Text + "','" + txtUserName.Text + "','" + comboPrivilege.Text + "','" + txtPassword.Text + "')", connection);
                int resSave = com_customer.ExecuteNonQuery();
                connection.Close();
                if (resSave == 1)
                {
                    clearAll();
                    loadTableDta();
                    dataGridView1.Refresh();
                    MessageBox.Show("Record Inserted Successfully...!");
                }
                else
                {
                    MessageBox.Show("Failed To Insert The Record...!");
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            btnUpdate.Text = "Save";
            txtPassword.Text = "";
            txtUserName.Text = "";
            comboPrivilege.Text = "";
            comboUserId.Text = "";
            btnDelete.Enabled = false;
            dataGridView1.ClearSelection();
        }
    }
}
