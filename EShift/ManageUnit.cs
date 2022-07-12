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
    public partial class ManageUnit : Form
    {
        private DataTable dt;
        private MySqlConnection connection = DBConnection.getInstance().getConnection();

        public ManageUnit()
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
            txtContainer.Clear();
            txtAssistant.Clear();
            txtId.Clear();
            txtDriver.Clear();
            txtLorry.Clear();

            btnUpdate.Text = "Update";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dt.Rows[e.RowIndex].Field<String>(0).ToString();
                txtContainer.Text = dt.Rows[e.RowIndex].Field<String>(1).ToString();
                txtLorry.Text = dt.Rows[e.RowIndex].Field<String>(2).ToString();
                txtDriver.Text = dt.Rows[e.RowIndex].Field<String>(3).ToString();
                txtAssistant.Text = dt.Rows[e.RowIndex].Field<String>(4).ToString();

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
            dt = GetUnitList();
            dataGridViewUnit.DataSource = dt;
            dataGridViewUnit.ClearSelection();


        }

        private DataTable GetUnitList()
        {
            if (connection != null)
            {
                connection.Close();
            }
            DataTable dtCustomer = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("select * From unit", connection))
            {
                connection.Open();
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                dtCustomer.Load(mySqlDataReader);
            }
            return dtCustomer;
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
                string updateCustomer = ("UPDATE `eshift`.`unit` SET `container_id`='" + txtContainer.Text + "',  `lorry_id`='" + txtLorry.Text + "', `driver_id`='" + txtDriver.Text + "', `assistant_id`='" + txtAssistant.Text + "' WHERE `id`  = '" + txtId.Text + "' ");
                MySqlCommand update_cmd = new MySqlCommand(updateCustomer, connection);
                int res_update = update_cmd.ExecuteNonQuery();
                connection.Close();
                if (res_update == 1)
                {
                    loadTableDta();
                    dataGridViewUnit.Refresh();
                    MessageBox.Show("Unit updated sucessfully...");
                }
                else
                {
                    MessageBox.Show("Failed to update record....");
                }

            }
            else
            {
                connection.Open();
                MySqlCommand com_customer = new MySqlCommand("insert into unit (id,container_id,lorry_id,driver_id,assistant_id) values ('" + txtId.Text + "','" + txtContainer.Text + "','" + txtLorry.Text + "','" + txtDriver.Text + "','" + txtAssistant.Text + "')", connection);
                int resSave = com_customer.ExecuteNonQuery();
                connection.Close();
                if (resSave == 1)
                {
                    clearAll();
                    loadTableDta();
                    dataGridViewUnit.Refresh();
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
            try
            {
                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();
                String id = txtId.Text;
                string deleteCustomer = ("Delete from unit where id='" + id + "' ");
                MySqlCommand delete_cmd = new MySqlCommand(deleteCustomer, connection);

                int res_update = delete_cmd.ExecuteNonQuery();
                connection.Close();
                if (res_update == 1)
                {
                    clearAll();
                    loadTableDta();
                    dataGridViewUnit.Refresh();
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

        private void button2_Click(object sender, EventArgs e)
        {
            int unitId;
            if (dataGridViewUnit.RowCount - 1 <= 0)
            {
                unitId = 000;
            }
            else
            {
                unitId = int.Parse(dt.Rows[dataGridViewUnit.RowCount - 1]
                .Field<String>(0).ToString().Replace("U", ""));
            }

            String newunitId;

            if (unitId < 1000 && unitId >= 100)
            {
                newunitId = "U" + (unitId + 1);
            }
            else if (unitId < 100 && unitId >= 10)
            {
                newunitId = "U0" + (unitId + 1);
            }
            else
            {
                newunitId = "U00" + (unitId + 1);
            }

            btnUpdate.Enabled = true;
            btnDelete.Enabled = false;
            clearAll();
            txtId.Text = newunitId;
            btnUpdate.Text = "Save";
            loadTableDta();
        }

        private void ManageUnit_Load(object sender, EventArgs e)
        {
            loadTableDta();
            dataGridViewUnit.Columns[0].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridViewUnit.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridViewUnit.Columns[2].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridViewUnit.Columns[3].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridViewUnit.Columns[4].DefaultCellStyle.ForeColor = Color.Blue;

            dataGridViewUnit.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridViewUnit.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewUnit.EnableHeadersVisualStyles = false;

            dataGridViewUnit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewUnit.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewUnit.BackgroundColor = SystemColors.ButtonShadow;
            dataGridViewUnit.BorderStyle = BorderStyle.None;
            dataGridViewUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
    }
}
