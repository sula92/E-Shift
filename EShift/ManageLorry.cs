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
    public partial class ManageLorry : Form
    {
        private DataTable dt;
        private MySqlConnection connection = DBConnection.getInstance().getConnection();

        public ManageLorry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dt.Rows[e.RowIndex].Field<String>(0).ToString();
                txtModel.Text = dt.Rows[e.RowIndex].Field<String>(1).ToString();
                txtStaus.Text = dt.Rows[e.RowIndex].Field<String>(1).ToString();

                btnUpdate.Text = "Update";
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Exception has occurred : {0}", ex.Message);
            }
        }

        private void ManageLorry_Load(object sender, EventArgs e)
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
            using (MySqlCommand cmd = new MySqlCommand("select * From lorry", connection))
            {
                connection.Open();
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                dtCustomer.Load(mySqlDataReader);
            }
            return dtCustomer;
        }

        private void clearAll()
        {

            txtModel.Clear();
            txtStaus.Clear();
            txtId.Clear();

            btnUpdate.Text = "Update";
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
                unitId = int.Parse(dt.Rows[dataGridView1.RowCount - 2]
                .Field<String>(0).ToString().Replace("L", ""));
            }

            String newunitId;

            if (unitId < 1000 && unitId >= 100)
            {
                newunitId = "L" + (unitId + 1);
            }
            else if (unitId < 100 && unitId >= 10)
            {
                newunitId = "L0" + (unitId + 1);
            }
            else
            {
                newunitId = "L00" + (unitId + 1);
            }

            btnUpdate.Enabled = true;
            btnDelete.Enabled = false;
            clearAll();
            txtId.Text = newunitId;
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
                string updateCommand = ("UPDATE `eshift`.`lorry` SET `model`='" + txtModel.Text + "',  `status`='" + txtStaus.Text + "' WHERE `id`  = '" + txtId.Text + "' ");
                MySqlCommand update_cmd = new MySqlCommand(updateCommand, connection);
                int res_update = update_cmd.ExecuteNonQuery();
                connection.Close();
                if (res_update == 1)
                {
                    loadTableDta();
                    dataGridView1.Refresh();
                    MessageBox.Show("Record updated sucessfully...");
                }
                else
                {
                    MessageBox.Show("Failed to update record....");
                }

            }
            else
            {
                connection.Open();
                MySqlCommand com_customer = new MySqlCommand("insert into lorry (id,model,status) values ('" + txtId.Text + "','" + txtModel.Text + "','" + txtStaus.Text + "')", connection);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();
                String id = txtId.Text;
                string deleteCustomer = ("Delete from lorry where id='" + id + "' ");
                MySqlCommand delete_cmd = new MySqlCommand(deleteCustomer, connection);

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
    }
}
