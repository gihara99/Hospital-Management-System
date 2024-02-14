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
    public partial class DoctorDash : Form
    {
        public DoctorDash()
        {
            InitializeComponent();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Hide();
            Doctor_AdminSign da = new Doctor_AdminSign();
            da.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Hide();
            Patient_Appointmments pa = new Patient_Appointmments();
            pa.Show();
        }
    }
}
