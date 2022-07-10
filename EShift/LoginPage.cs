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
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDBoard = new AdminDashboard();
            adminDBoard.Show();
                
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MySqlConnection connection=DBConnection.getInstance().getConnection();

            // MySqlConnection connection =new MySqlConnection("DataSource ='localhost'; Database='eshift'; User ID='root'; Password='';");
            MessageBox.Show(connection.ToString());
            connection.Open();
            Console.WriteLine(connection);
            Console.ReadLine();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
