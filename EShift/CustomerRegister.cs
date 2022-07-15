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
    public partial class CustomerRegister : Form
    {

        MySqlConnection connection = DBConnection.getInstance().getConnection();
        public CustomerRegister()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            using (MySqlCommand cmd = new MySqlCommand("SELECT id FROM customer ORDER BY id DESC LIMIT 1;", connection))
            {

                int cutomerId;
                String cid;

                connection.Open();

                MySqlDataReader reader = cmd.ExecuteReader();


                Boolean b= reader.Read();

                cid = reader["id"].ToString();
                       
                    
                cutomerId= int.Parse(cid.Replace("C", ""));

                String newCustomerId;

                if (cutomerId < 1000 && cutomerId >= 100)
                {
                    newCustomerId = "C" + (cutomerId + 1);
                }
                else if (cutomerId < 100 && cutomerId >= 10)
                {
                    newCustomerId = "C0" + (cutomerId + 1);
                }
                else
                {
                    newCustomerId = "C00" + (cutomerId + 1);
                }

                reader.Close();
                
                MySqlCommand com_customer = new MySqlCommand("insert into customer (id,name,contact_number,email,address) values ('" + newCustomerId + "','" + txtName.Text + "','" + txtContact.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "')", connection);
                int resSave = com_customer.ExecuteNonQuery();
                connection.Close();
                if (resSave == 1)
                {
                    clearAll();
                   
                    MessageBox.Show("Registered Successfully...Your CutomerId is"+newCustomerId);
                }
                else
                {
                    MessageBox.Show("Failed To Inser The Recpord...!");
                }

            }
         
        }

        private void clearAll()
        {
            txtAddress.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtName.Clear();
        }
    }
}
