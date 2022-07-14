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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            List<String> months = new List<String>() { "A","B" };
            foreach (string month in months)
            {
                comboPrivilege.Items.Add(month);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
