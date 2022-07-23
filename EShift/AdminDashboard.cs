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
    public partial class AdminDashboard : Form
    {
        MySqlConnection connection = DBConnection.getInstance().getConnection();

        public AdminDashboard()
        {
            InitializeComponent();
        }
        //navigate to cutomer management
        private void customerMngt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCustomer mngCustomer = new ManageCustomer();
            mngCustomer.Show();
        }
        //navigate to employee management
        private void btnEmpMngt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageEmployee mngEmployee = new ManageEmployee();
            mngEmployee.Show();

        }
        //navigate to lorry management
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageLorry mngLorry = new ManageLorry();
            mngLorry.Show();
        }
        //navigate to product management
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportManagement reportManagement = new ReportManagement();
            reportManagement.Show();
        }
        //navigate to user management
        private void btnUserMngt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUser manageUser = new ManageUser();
            manageUser.Show();
        }
        //navigate to job management
        private void btnJobMngt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageJob manageJob = new ManageJob();
            manageJob.Show();
        }
        //navigate to container management
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageContainer manageContainer = new ManageContainer();
            manageContainer.Show();
        }
        //navigate to unit management
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUnit manageUnit = new ManageUnit();
            manageUnit.Show();
        }
        //navigate to login
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            
            if (connection != null)
            {
                connection.Close();
            }

            MySqlCommand cmd = new MySqlCommand("select COUNT(id) AS emps From employee", connection);
            MySqlCommand cmd1 = new MySqlCommand("select COUNT(id) AS cus From customer", connection);
            MySqlCommand cmd2 = new MySqlCommand("select COUNT(id) AS jobs From job", connection);

            connection.Open();
                           
                MySqlDataReader reader = cmd.ExecuteReader();
                
               
                Boolean b = reader.Read();               
                String emps = reader["emps"].ToString();
                reader.Close();
            
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                Boolean b3 = reader1.Read();
                String cus = reader1["cus"].ToString();
                reader1.Close();

                 MySqlDataReader reader2 = cmd2.ExecuteReader();
                 Boolean b2 = reader2.Read();
                 String jobs = reader2["jobs"].ToString();
             
                connection.Close();
                reader2.Close();

            chart2.Series["jobsbarSeries"].Points.AddXY("Employees", Int16.Parse(emps));
            chart2.Series["jobsbarSeries"].Points.AddXY("Customers", Int16.Parse(cus));
            chart2.Series["jobsbarSeries"].Points.AddXY("Jobs", Int16.Parse(jobs));

            chart1.Series["jobsPi"].Points.AddXY("Employees", Int16.Parse(emps));
            chart1.Series["jobsPi"].Points.AddXY("Customers", Int16.Parse(cus));
            chart1.Series["jobsPi"].Points.AddXY("Jobs", Int16.Parse(jobs));
        }
    }
}
