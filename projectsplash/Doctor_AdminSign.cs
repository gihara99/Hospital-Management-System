using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace projectsplash
{
    public partial class Doctor_AdminSign : Form
    {
        public Doctor_AdminSign()
        {
            InitializeComponent();
        }
        private void Doctor_AdminSign_Load(object sender, EventArgs e)
        {
            
        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ANJANA;Initial Catalog=Hospital;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from User_login_info where  UserName='" + txt_userName.Text + "'and Userpassword='" + txt_userPassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string cmbItemValue = com_userType.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["UserRole"].ToString() == cmbItemValue);
                    {
                        if (com_userType.SelectedIndex == 0)
                        {
                            Hide();
                            Admin a = new Admin();
                            a.Show();
                        }
                        else
                        {
                            Hide();
                            DoctorDash dd = new DoctorDash();
                            dd.Show();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("User name or password not in correct please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void passCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(passCheck.Checked)
            {
                txt_userPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txt_userPassword.UseSystemPasswordChar = false;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hide();
            Home_menu hm = new Home_menu();
            hm.Show();
        }

        private void com_userType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
