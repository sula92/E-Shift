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
    public partial class CustomerProfile : Form
    {
      
        private MySqlConnection connection = DBConnection.getInstance().getConnection();

        private String cusId = Login.customerId;

        public CustomerProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Regex rx1 = new Regex(@"\d{10}");
            Regex rx2 = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            if (!rx1.IsMatch(txtContact.Text))
            {
                MessageBox.Show("Please Enter A Valid Contact Number...");
                return;
            }
            if (!rx2.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Please Enter A Valid Email...");
                return;
            }
            if (txtPwd1.Text!=txtPwd2.Text)
            {
                MessageBox.Show("Incompatible Passwords...");
                return;
            }
            if (connection != null)
            {
                connection.Close();
            }

            connection.Open();
            string updateCustomer = ("UPDATE `eshift`.`customer` SET `name`='" + txtName.Text + "',  `contact_number`='" + txtContact.Text + "', `email`='" + txtEmail.Text + "', `address`='" + txtAddress.Text + "' WHERE `id`  = '" + txtId.Text + "' ");
            MySqlCommand update_cmd = new MySqlCommand(updateCustomer, connection);
            int res_update = update_cmd.ExecuteNonQuery();
            connection.Close();
            if (res_update == 1)
            {
                
                MessageBox.Show("Profile updated sucessfully...");
            }
            else
            {
                MessageBox.Show("Failed to update profile....");
            }
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            txtPwd1.UseSystemPasswordChar = true;
            txtPwd2.UseSystemPasswordChar = true;
            using (MySqlCommand cmd = new MySqlCommand("select * From customer  WHERE `id`  = '" + cusId + "'", connection))
            {
              
                connection.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Boolean b = reader.Read();
                txtName.Text = reader["name"].ToString();
                txtContact.Text = reader["contact_number"].ToString();
                txtEmail.Text = reader["email"].ToString();
                txtAddress.Text = reader["address"].ToString();
                txtId.Text = reader["id"].ToString();
                txtUID.Text = reader["id"].ToString();

                lblWelcome.Text = "Wecome To Your Profile" + " " + reader["name"].ToString();

                connection.Close();
                reader.Close();

            }
            

            using (MySqlCommand cmd = new MySqlCommand("select * From user  WHERE `userId`  = '" + cusId + "'", connection))
            {
                connection.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Boolean b = reader.Read();
                txtPwd1.Text = reader["password"].ToString();
                txtPwd2.Text = reader["password"].ToString();
                txtUnm.Text = reader["user_name"].ToString();

                connection.Close();

            }

        }
    }
}

