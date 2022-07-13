﻿using MySql.Data.MySqlClient;
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
    public partial class ManageProduct : Form
    {

        private DataTable dt;
        private MySqlConnection connection = DBConnection.getInstance().getConnection();

        public ManageProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

            btnUpdate.Enabled = true;
            btnDelete.Enabled = false;
            clearAll();          
            btnUpdate.Text = "Save";
            loadTableDta();
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
            using (MySqlCommand cmd = new MySqlCommand("select * From product", connection))
            {
                connection.Open();
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                dtCustomer.Load(mySqlDataReader);
            }
            return dtCustomer;
        }

        private void clearAll()
        {

            txtJobId.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();            

            btnUpdate.Text = "Update";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                connection.Close();
            }           

            if (btnUpdate.Text == "Update")
            {

                connection.Open();
                string updateProduct = ("UPDATE `eshift`.`product` SET `quantity`='" + txtQuantity.Text + "' WHERE `job_id`  = '" + txtJobId.Text + "' AND `product_name`  = '" + txtProductName.Text + "' ");
                MySqlCommand update_cmd = new MySqlCommand(updateProduct, connection);
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
                MySqlCommand com_customer = new MySqlCommand("insert into product (job_id,product_name,quantity) values ('" + txtJobId.Text + "','" +txtProductName.Text + "','" + txtQuantity.Text + "')", connection);
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
                    MessageBox.Show("Failed To Inser The Recpord...!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();
                String jid = txtProductName.Text;
                String pname = txtProductName.Text;
                string deleteCmd = ("Delete from product where job_id='" + jid + "' AND product_name='" + pname + "' ");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtJobId.Text = dt.Rows[e.RowIndex].Field<String>(0).ToString();
                txtProductName.Text = dt.Rows[e.RowIndex].Field<String>(1).ToString();
                txtQuantity.Text = dt.Rows[e.RowIndex].Field<int>(2).ToString();

                btnUpdate.Text = "Update";
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Exception has occurred : {0}", ex.Message);
            }
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            loadTableDta();
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;


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
        }

       
    }
}
