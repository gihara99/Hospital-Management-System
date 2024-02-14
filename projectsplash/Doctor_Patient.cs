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
    public partial class Doctor_Patient : Form
    {
        public Doctor_Patient()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            DoctorDash dd = new DoctorDash();
            dd.Show();
        }
    }
}
