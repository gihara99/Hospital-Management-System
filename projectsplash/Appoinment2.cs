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
    public partial class Appoinment2 : Form
    {
        public Appoinment2()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hide();
            Appointments a = new Appointments();
            a.Show();
        }

        private void btn_addAppoinments_Click(object sender, EventArgs e)
        {
            
            
                String query = "Insert into Appoinments values('"+txt_name.Text+"','"+txt_conNumber.Text+"','"+txt_email.Text+"','"+dateTimePicker.Value+"','"+com_speciality.SelectedItem+"','"+txt_docName.Text+"')";
                int i = db.save_update_delete(query);
                if (i == 1)
                {
                    MessageBox.Show("Appoinment add sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Appoinment cannot add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
            
            
        }
    }
}
