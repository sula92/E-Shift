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
    public partial class ManageEmployee : Form
    {
        public ManageEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
    }
}
