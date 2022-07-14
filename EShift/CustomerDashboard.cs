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
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerProfile customerProfile = new CustomerProfile();
            customerProfile.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerJobRequest customerJobRequest = new CustomerJobRequest();
            customerJobRequest.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerJobStatus customerJobStatus = new CustomerJobStatus();
            customerJobStatus.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
