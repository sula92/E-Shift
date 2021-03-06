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
    public partial class ManageProduct : Form
    {
        private DataTable dt;
        private MySqlConnection connection = DBConnection.getInstance().getConnection();
        private String jobId = ManageJob.jobId;

        public ManageProduct()
        {
            InitializeComponent();
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
            txtJobID.Text = jobId;
            txtJobID.ReadOnly = true;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            btnUpdate.Enabled = true;
            btnDelete.Enabled = false;
            clearAll();
            btnUpdate.Text = "Save";
            loadTableDta();
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
                string updateProduct = ("UPDATE `eshift`.`product` SET `quantity`='" + txtQuantity.Text + "' WHERE `job_id`  = '" + txtJobID.Text + "' AND `product_name`  = '" + txtProductName.Text + "' ");
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
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        if (txtProductName.Text == row.Cells["product_name"].Value.ToString())
                        {
                            MessageBox.Show("You cant duplicate the same product");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        connection.Open();
                        MySqlCommand com1 = new MySqlCommand("insert into product (job_id,product_name,quantity) values ('" + txtJobID.Text + "','" + txtProductName.Text + "','" + txtQuantity.Text + "')", connection);
                        int resIns = com1.ExecuteNonQuery();
                        connection.Close();
                        if (resIns == 1)
                        {
                            clearAll();
                            loadTableDta();
                            dataGridView1.Refresh();
                            MessageBox.Show("Record Inserted Successfully...!");
                        }
                        else
                        {
                            MessageBox.Show("Failed To Inser The Record...!");
                        }

                        return;
                    }
                }

                connection.Open();
                MySqlCommand com_customer = new MySqlCommand("insert into product (job_id,product_name,quantity) values ('" + txtJobID.Text + "','" + txtProductName.Text + "','" + txtQuantity.Text + "')", connection);
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
                    MessageBox.Show("Failed To Inser The Record...!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HI");
            try
            {
                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();

                string deleteCmd = ("DELETE FROM `product` WHERE `product`.`job_id` = '"+txtJobID.Text+"' AND `product`.`product_name` = '"+txtProductName.Text+"'");
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageJob manageJob = new ManageJob();
            manageJob.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dt.Rows[e.RowIndex].Field<int>(2).ToString());
            txtJobID.Text = dt.Rows[e.RowIndex].Field<String>(0).ToString();
            txtProductName.Text = dt.Rows[e.RowIndex].Field<String>(1).ToString();
            txtQuantity.Text = dt.Rows[e.RowIndex].Field<int>(2).ToString();

            btnUpdate.Text = "Update";
            btnUpdate.Enabled = true;
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
            using (MySqlCommand cmd = new MySqlCommand("select * From product where `job_id`  = '" + jobId + "'", connection))
            {
                connection.Open();
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                dtCustomer.Load(mySqlDataReader);
            }
            return dtCustomer;
        }

        private void clearAll()
        {
            txtProductName.Clear();
            txtQuantity.Clear();
            btnUpdate.Text = "Update";
        }
    }
}
