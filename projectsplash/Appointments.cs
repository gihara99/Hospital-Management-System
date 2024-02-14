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
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            patientDash pd = new patientDash();
            pd.Show();
            this.Close();
        }

        private void btn_applyAppoinment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appoinment2 ap2 = new Appoinment2();
            ap2.Show();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            
            dataGrid_docAppoinments.DataSource = db.getData("Select * from Doctors where Specialisty LIKE '" + com_selectSpecialities.SelectedItem+ "%'");
        }
    }
}
