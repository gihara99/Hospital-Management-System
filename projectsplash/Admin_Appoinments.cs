using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectsplash
{
    public partial class Admin_Appoinments : Form
    {
        public Admin_Appoinments()
        {
            InitializeComponent();
        }

        private void Admin_Appoinments_Load(object sender, EventArgs e)
        {
            

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hide();
            Admin a = new Admin();
            a.Show();
        }
    }
}
