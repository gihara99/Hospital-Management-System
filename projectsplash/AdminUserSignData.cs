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
    public partial class AdminUserSignData : Form
    {
        public AdminUserSignData()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Close();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btn_userAdd_Click(object sender, EventArgs e)
        {
            string query = "Insert into User_login_info values('"+txt_userName.Text+"','"+txt_userPassword.Text+"','"+com_userType.SelectedItem+"')";
            int i = db.save_update_delete(query);
            if(i==1)
            {
                MessageBox.Show("User add sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User cannot add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminUserSignData_Load(object sender, EventArgs e)
        {

        }
    }
}
