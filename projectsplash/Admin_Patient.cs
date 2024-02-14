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
    public partial class Admin_Patient : Form
    {
        public Admin_Patient()
        {
            InitializeComponent();
        }
        Database db = new Database();

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            Admin a = new Admin();
            a.Show();
        }

        private void btn_SearchAdmPatient_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_searchPatient.Text.Length==0)
                {
                    DataGridView_AdminPatient.DataSource = db.getData("Select * from patient_Registration");
                }
                else
                {
                    DataGridView_AdminPatient.DataSource = db.getData("Select * from patient_Registration where Patient_Name LIKE '" + txt_searchPatient.Text + "%'");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Admin_Patient_Load(object sender, EventArgs e)
        {
            
            

        }
    }
}
