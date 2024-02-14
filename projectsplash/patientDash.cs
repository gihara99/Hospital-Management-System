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
    public partial class patientDash : Form
    {
        public patientDash()
        {
            InitializeComponent();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hide();
            Appointments a = new Appointments();
            a.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Hide();
            PatientSettings ps = new PatientSettings();
            ps.Show();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            Hide();
            Services s = new Services();
            s.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            Hide();
            LabTest lt = new LabTest();
            lt.Show();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            Hide();
            Services s = new Services();
            s.Show();
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            Home_menu hm = new Home_menu();
            hm.Show();
            this.Close();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Hide();
            Contact c = new Contact();
            c.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Hide();
            Services ps = new Services();
            ps.Show();
        }
    }
}
