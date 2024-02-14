using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projectsplash
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
       
        

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hide();
            AdminUserSignData ap = new AdminUserSignData();
            ap.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Hide();
            AdminDoctor ad = new AdminDoctor();
            ad.Show();
;            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Hide();
            Admin_Appoinments aa = new Admin_Appoinments();
            aa.Show();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {
           
            SqlConnection con=new SqlConnection("Data Source = DESKTOP - R2VBIN1; Initial Catalog = Hospital; Integrated Security = True");
            SqlCommand cmd;
            string query = "Select count(Patient_Name) from patient_Registration";
            con.Open();
            cmd = new SqlCommand(query, con);
            Int32 row_count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            patient_count.Text = row_count.ToString();

        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            Hide();
            Doctor_AdminSign da = new Doctor_AdminSign();
            da.Show();
;            
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            Admin_Patient ap = new Admin_Patient();
            ap.Show();
        }
    }
}
