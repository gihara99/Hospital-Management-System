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
    public partial class Patient_Appointmments : Form
    {
        public Patient_Appointmments()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            //Error
            dataGridView_Appoinments.DataSource = db.getData("Select * from Appoinments where Ddoctor LIKE   '" + txt_docName.Text+" %'");
        }

        private void Patient_Appointmments_Load(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DoctorDash dd = new DoctorDash();
            dd.Show();
            this.Close();
        }
    }
}
