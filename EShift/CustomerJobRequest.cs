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
    public partial class CustomerJobRequest : Form
    {

        private DataTable dt;
        private MySqlConnection connection = DBConnection.getInstance().getConnection();

        public CustomerJobRequest()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {


            int unitId;
            if (dataGridView1.RowCount - 1 <= 0)
            {
                unitId = 000;
            }
            else
            {
                unitId = int.Parse(dt.Rows[dataGridView1.RowCount - 1]
                .Field<String>(0).ToString().Replace("R", ""));
            }

            String newunitId;

            if (unitId < 1000 && unitId >= 100)
            {
                newunitId = "R" + (unitId + 1);
            }
            else if (unitId < 100 && unitId >= 10)
            {
                newunitId = "R0" + (unitId + 1);
            }
            else
            {
                newunitId = "R00" + (unitId + 1);
            }

            btnUpdate.Enabled = true;
            btnDelete.Enabled = false;
            clearAll();
            txtRequestId.Text = newunitId;
            btnUpdate.Text = "Save";
            loadTableDta();
            txtCustomerId.Text = Login.customerId;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.Show();
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
                string updateCustomer = ("UPDATE `eshift`.`request` SET `customer_id`='" + txtCustomerId.Text + "'  `product_inf`='" + txtProductInfo.Text + "' WHERE `id`  = '" + txtRequestId.Text + "' ");
                MySqlCommand update_cmd = new MySqlCommand(updateCustomer, connection);
                int res_update = update_cmd.ExecuteNonQuery();
                connection.Close();
                if (res_update == 1)
                {
                    loadTableDta();
                    dataGridView1.Refresh();
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
                MySqlCommand com_customer = new MySqlCommand("insert into request (request_id,customer_id,product_inf,status) values ('" + txtRequestId.Text + "','" + txtCustomerId.Text + "','" + txtProductInfo.Text + "','" + "pending" + "')", connection);
                int resSave = com_customer.ExecuteNonQuery();
                connection.Close();
                if (resSave == 1)
                {
                    clearAll();
                    txtRequestId.Text = "";
                    txtProductInfo.Text = "";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            

            if (connection != null)
            {
                connection.Close();
            }

            if (lblStatus.Text == "pending" || lblStatus.Text =="approved")
            {
                btnDelete.Text = "Cancel";

                connection.Open();
                string updateCmd = ("UPDATE `eshift`.`request` SET `status`='" + "cancel" + "' WHERE `id`  = '" + txtRequestId.Text + "' ");
                MySqlCommand update_cmd = new MySqlCommand(updateCmd, connection);
                int res_update = update_cmd.ExecuteNonQuery();
                connection.Close();
                if (res_update == 1)
                {
                    loadTableDta();
                    dataGridView1.Refresh();
                    MessageBox.Show("Requestr updated sucessfully...");
                }
                else
                {
                    MessageBox.Show("Failed to update record....");
                }

            }
            else
            {
                btnDelete.Text = "ReOpen";

                connection.Open();
                string updateRequest = ("UPDATE `eshift`.`request` SET `status`='" + "pending" + "'");
                MySqlCommand update_cmd = new MySqlCommand(updateRequest, connection);
                int res_update = update_cmd.ExecuteNonQuery();
                connection.Close();
                if (res_update == 1)
                {
                    loadTableDta();
                    dataGridView1.Refresh();
                    MessageBox.Show("Request updated sucessfully...");
                }
                else
                {
                    MessageBox.Show("Failed to update record....");
                }
            }
        }

        private void CustomerJobRequest_Load(object sender, EventArgs e)
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

            txtCustomerId.Text = Login.customerId;
            txtCustomerId.ReadOnly = true;
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
            using (MySqlCommand cmd = new MySqlCommand("select * From request  WHERE `customer_id`  = '" + txtCustomerId.Text + "'", connection))
            {
                connection.Open();
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                dtCustomer.Load(mySqlDataReader);
            }
            return dtCustomer;
        }

        private void clearAll()
        {

            txtCustomerId.Clear();
            
            

            btnUpdate.Text = "Update";
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtRequestId.Text = dt.Rows[e.RowIndex].Field<String>(0).ToString();
                txtCustomerId.Text = dt.Rows[e.RowIndex].Field<String>(1).ToString();
                txtProductInfo.Text = dt.Rows[e.RowIndex].Field<String>(2).ToString();
                lblStatus.Text = dt.Rows[e.RowIndex].Field<String>(3).ToString();
               
               

                btnUpdate.Text = "Update";
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Exception has occurred : {0}", ex.Message);
            }
        }
    }
}
