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
    }
}
