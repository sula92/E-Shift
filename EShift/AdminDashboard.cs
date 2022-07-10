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
    }
}
