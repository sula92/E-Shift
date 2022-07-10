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

        private void customerMngt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCustomer mngCustomer = new ManageCustomer();
            mngCustomer.Show();
        }

        private void btnEmpMngt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageEmployee mngEmployee = new ManageEmployee();
            mngEmployee.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageLorry mngLorry = new ManageLorry();
            mngLorry.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageProduct mngProduct = new ManageProduct();
            mngProduct.Show();
        }

        private void btnUserMngt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUser manageUser = new ManageUser();
            manageUser.Show();
        }

        private void btnJobMngt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageJob manageJob = new ManageJob();
            manageJob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageContainer manageContainer = new ManageContainer();
            manageContainer.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUnit manageUnit = new ManageUnit();
            manageUnit.Show();
        }
    }
}
