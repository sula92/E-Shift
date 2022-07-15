using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EShift
{
    public partial class Login : Form
    {
        public static String customerId;
        public static String employeeId;

        MySqlConnection connection = DBConnection.getInstance().getConnection();

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection!=null)
            {
                connection.Close();
            }

            using (MySqlCommand cmd = new MySqlCommand("select * From user  WHERE `user_name`  = '" + txtUserName.Text + "' AND  `password`  = '" + txtPassword.Text + "'", connection))
            {
                connection.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Boolean b = reader.Read();
                if (!b)
                {
                    MessageBox.Show("access denied! Please Register");
                }


                try
                {
                    while (b)
                    {

                        String unm = reader["user_name"].ToString();
                        String pwd = reader["password"].ToString();
                        String role = reader["privilege"].ToString();
                        String uid = reader["userId"].ToString();

                        if (role == "admin")
                        {
                            employeeId = uid;

                            this.Hide();
                            AdminDashboard adminDBoard = new AdminDashboard();
                            adminDBoard.Show();
                        }
                        else if (role == "customer")
                        {
                            customerId = uid;

                            this.Hide();
                            CustomerDashboard customerDashboard = new CustomerDashboard();
                            customerDashboard.Show();
                        }
                        else if (unm == null || unm == "" || pwd == null || pwd == "")
                        {
                            MessageBox.Show("you dont have the access");
                        }
                        else
                        {
                            MessageBox.Show("access is pending");
                        }

                        break;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("access denied");
                }

            }
           
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Text = "";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRegister customerRegister = new CustomerRegister();
            customerRegister.Show();
        }
    }
}
