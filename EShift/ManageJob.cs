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
    public partial class ManageJob : Form
    {
        public static String jobId;
        private DataTable dt;
        private MySqlConnection connection = DBConnection.getInstance().getConnection();

        public ManageJob()
        {
            InitializeComponent();
        }

        //navigate to dashboard
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }

        //set initial property values
        private void ManageJob_Load(object sender, EventArgs e)
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

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            List<String> status = new List<String>() { "pending", "cancel", "approved","completed" };
            foreach (string role in status)
            {
                cmbStatus.Items.Add(role);
            }

            if (connection != null)
            {
                connection.Close();
            }

            using (MySqlCommand cmd = new MySqlCommand("select * From unit ", connection))
            {
                cmbUID.Items.Add("");
                connection.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {


                    String uid = reader["id"].ToString();

                    cmbUID.Items.Add(uid);

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
            DataTable dtCustomer = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("select * From job", connection))
            {
                connection.Open();
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                dtCustomer.Load(mySqlDataReader);
            }
            return dtCustomer;
        }
        //clear txt boxes
        private void clearAll()
        {

            txtDesAdd.Clear();
            txtStartingAdd.Clear();
            txtId.Clear();
            txtCId.Clear();
            cmbUID.Text = "";
            cmbStatus.Text = "pending";
            btnUpdate.Text = "Update";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //select table row
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {               

                txtId.Text = dt.Rows[e.RowIndex].Field<String>(0).ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[e.RowIndex].Field<String>(1).ToString());
                txtDesAdd.Text = dt.Rows[e.RowIndex].Field<String>(2).ToString();
                txtStartingAdd.Text = dt.Rows[e.RowIndex].Field<String>(3).ToString();
                txtCId.Text = dt.Rows[e.RowIndex].Field<String>(4).ToString();
                cmbUID.Text = dt.Rows[e.RowIndex].Field<String>(5).ToString();
                cmbStatus.Text = dt.Rows[e.RowIndex].Field<String>(6).ToString();

                jobId= dt.Rows[e.RowIndex].Field<String>(0).ToString();

                btnUpdate.Text = "Update";
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Exception has occurred : {0}", ex.Message);
            }
        }
        //generate new id
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            int unitId;
            if (dataGridView1.RowCount <= 0)
            {
                unitId = 000;
            }
            else
            {
                unitId = int.Parse(dt.Rows[dataGridView1.RowCount - 1]
                .Field<String>(0).ToString().Replace("J", ""));
            }

            String newunitId;

            if (unitId < 1000 && unitId >= 100)
            {
                newunitId = "J" + (unitId + 1);
            }
            else if (unitId < 100 && unitId >= 10)
            {
                newunitId = "J0" + (unitId + 1);
            }
            else
            {
                newunitId = "J00" + (unitId + 1);
            }

            btnUpdate.Enabled = true;
            btnDelete.Enabled = false;
            clearAll();
            txtId.Text = newunitId;
            btnUpdate.Text = "Save";
            loadTableDta();
            cmbStatus.Text = "pending";
            jobId = newunitId;
        }

        //upadate the job
        private void button2_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                connection.Close();
            }

            string theDate = dateTimePicker1.Value.ToShortDateString();

            if (btnUpdate.Text == "Update")
            {

                connection.Open();
                string updateCustomer = ("UPDATE `eshift`.`job` SET `customer_id`='" + txtCId.Text + "', `date`='" + dateTimePicker1.Value.ToString() + "',  `unit_id`='" + cmbUID.Text + "', `starting_address`='" + txtStartingAdd.Text + "', `destination_address`='" + txtDesAdd.Text + "', `status`='" + cmbStatus.Text + "' WHERE `id`  = '" + txtId.Text + "' ");
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
                MySqlCommand com_customer = new MySqlCommand("insert into job (id,date,destination_address,starting_address,customer_id,unit_id,status) values ('" + txtId.Text + "','" + dateTimePicker1.Value.ToString() + "','" + txtDesAdd.Text + "','" + txtStartingAdd.Text + "','" + txtCId.Text + "','" + cmbUID.Text + "','" + cmbStatus.Text + "')", connection);
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
            loadTableDta();
        }
        //delete job
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
                string deleteCmd = ("Delete from job where id='" + id + "' ");
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cmbFromDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbToDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCustomerFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                txtId.Text = jobId;
                ManageProduct manageProduct = new ManageProduct();
                this.Close();
                manageProduct.Show();
            }
            else
            {
                MessageBox.Show("Job ID is Empty");
            }
        }
    }
}
