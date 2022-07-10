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

namespace EShift
{
    public partial class ManageCustomer : Form
    {
        private DataTable dt;
        private MySqlConnection connection = DBConnection.getInstance().getConnection();

        public ManageCustomer()
        {
            InitializeComponent();
            btnDelete.IsAccessible = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                connection.Close();
            }
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();

        }

        private void clearAll()
        {
            txtAddress.Clear();
            txtName.Clear();
            txtId.Clear();
            txtContactNumber.Clear();
            txtEmail.Clear();

            btnUpdate.Text = "Update";
        }

        private void manageCustomer_Load(object sender, EventArgs e)
        {
           
            loadTableDta();
            dataGridViewCustomer.Columns[0].DefaultCellStyle.ForeColor = Color.Blue; 
            dataGridViewCustomer.Columns[1].DefaultCellStyle.ForeColor = Color.Blue; 
            dataGridViewCustomer.Columns[2].DefaultCellStyle.ForeColor = Color.Blue; 
            dataGridViewCustomer.Columns[3].DefaultCellStyle.ForeColor = Color.Blue; 
            dataGridViewCustomer.Columns[4].DefaultCellStyle.ForeColor = Color.Blue;

            dataGridViewCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridViewCustomer.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;           
            dataGridViewCustomer.EnableHeadersVisualStyles = false;

            dataGridViewCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCustomer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCustomer.BackgroundColor = SystemColors.ButtonShadow;
            dataGridViewCustomer.BorderStyle = BorderStyle.None;
            dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

        }

        private void loadTableDta()
        {
            dt = GetCustomerList();
            dataGridViewCustomer.DataSource = dt;
            dataGridViewCustomer.ClearSelection();


        }

        private DataTable GetCustomerList()
        {
            if (connection != null)
            {
                connection.Close();
            }
            DataTable dtCustomer = new DataTable();
            using(MySqlCommand cmd=new MySqlCommand("select * From Customer", connection))
            {               
                connection.Open();               
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                dtCustomer.Load(mySqlDataReader);
            }
                return dtCustomer;
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dt.Rows[e.RowIndex].Field<String>(0).ToString();
                txtName.Text = dt.Rows[e.RowIndex].Field<String>(1).ToString();
                txtContactNumber.Text = dt.Rows[e.RowIndex].Field<String>(2).ToString();
                txtEmail.Text = dt.Rows[e.RowIndex].Field<String>(3).ToString();
                txtAddress.Text = dt.Rows[e.RowIndex].Field<String>(4).ToString();

                btnUpdate.Text = "Update";
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("An Exception has occurred : {0}", ex.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Regex rx1 = new Regex(@"\d{10}");
            Regex rx2 = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            if (!rx1.IsMatch(txtContactNumber.Text))
            {
                MessageBox.Show("Please Enter A Valid Contact Number...");
                return;
            }
            if (!rx2.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Please Enter A Valid Email...");
                return;
            }
            if (connection != null)
            {
                connection.Close();
            }
           
                if (btnUpdate.Text == "Update")
                {

                    connection.Open();
                    string updateCustomer = ("UPDATE `eshift`.`customer` SET `name`='" + txtName.Text + "',  `contact_number`='" + txtContactNumber.Text + "', `email`='" + txtEmail.Text + "', `address`='" + txtAddress.Text + "' WHERE `id`  = '" + txtId.Text + "' ");
                    MySqlCommand update_cmd = new MySqlCommand(updateCustomer, connection);
                    int res_update = update_cmd.ExecuteNonQuery();
                    connection.Close();
                    if (res_update == 1)
                    {
                        loadTableDta();
                        dataGridViewCustomer.Refresh();
                        MessageBox.Show("Customer updated sucessfully...");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update record....");
                    }

                }
                else
                {
                    connection.Open();
                    MySqlCommand com_customer = new MySqlCommand("insert into customer (id,name,contact_number,email,address) values ('" + txtId.Text + "','" + txtName.Text + "','" + txtContactNumber.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "')", connection);
                    int resSave = com_customer.ExecuteNonQuery();
                    connection.Close();
                    if (resSave == 1)
                    {
                        clearAll();
                        loadTableDta();
                        dataGridViewCustomer.Refresh();
                        MessageBox.Show("Record Inserted Successfully...!");
                    }
                    else
                    {
                        MessageBox.Show("Failed To Inser The Recpord...!");
                    }
                }
               
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();
                String id = txtId.Text;
                string deleteCustomer = ("Delete from Customer where id='" + id + "' ");
                MySqlCommand delete_cmd = new MySqlCommand(deleteCustomer, connection);

                int res_update = delete_cmd.ExecuteNonQuery();
                connection.Close();
                if (res_update == 1)
                {
                    clearAll();
                    loadTableDta();
                    dataGridViewCustomer.Refresh();
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {           
            int cutomerId= int.Parse(dt.Rows[dataGridViewCustomer.RowCount-1]
                .Field<String>(0).ToString().Replace("C",""));          

            String newCustomerId;

            if (cutomerId<1000 && cutomerId>=100)
            {
                newCustomerId = "C"+(cutomerId + 1);
            }
            else if(cutomerId<100 && cutomerId>=10){
                newCustomerId = "C0" + (cutomerId + 1);
            }
            else
            {
                newCustomerId = "C00" + (cutomerId + 1);
            }           

            btnUpdate.Enabled = true;
            btnDelete.Enabled = false;
            clearAll();
            txtId.Text = newCustomerId;
            btnUpdate.Text = "Save";
            loadTableDta();

        }
    }
}
