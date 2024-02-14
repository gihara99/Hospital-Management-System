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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            Hide();
            LabTest lt = new LabTest();
            lt.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            patientDash pd = new patientDash();
            pd.Show();
        }   
    }
}
