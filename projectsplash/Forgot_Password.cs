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
    public partial class Forgot_Password : Form
    {
        public Forgot_Password()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Home_menu hm = new Home_menu();
            hm.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_addAppoinments_Click(object sender, EventArgs e)
        {
            if (txt_password.Text != txt_comPassword.Text)
            {
                err_msg.Text = "Confirm password must same as the password";
                txt_comPassword.Focus();
            }
            else
            {
                err_msg.Text = "";

                string query = "Update patient_Registration set Patient_Password='" + txt_comPassword.Text + "' where Patient_Name='" + txt_userName.Text + "' ";
                int i = db.save_update_delete(query);
                if (i == 1)
                {
                    MessageBox.Show("Update sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update unsucessfull", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            Home_menu hm = new Home_menu();
            hm.Show();
        }
    }
}
