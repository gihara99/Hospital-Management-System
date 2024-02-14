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


namespace projectsplash
{
    public partial class Home_menu : Form
    {
        public Home_menu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=ANJANA;Initial Catalog=Hospital;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;


        private void Home_menu_Load(object sender, EventArgs e)
        {
             
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter Username and Password", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else 
            {
                cmd = new SqlCommand("Select * from patient_Registration where Patient_Name='" + txtUsername.Text + "' and Patient_Password='" + txtPassword.Text + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Hide();
                    patientDash pd = new patientDash();
                    pd.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Login Information! Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
           













           
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Doctor_AdminSign das = new Doctor_AdminSign();
            das.Show();
            
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Forgot_Password fp = new Forgot_Password();
            fp.Show();
        }

        private void btn_patientRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientRegister pr = new PatientRegister();
            pr.Show();
            
            
        }

        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }

        }

        private void btn_fogotPass_Click(object sender, EventArgs e)
        {
            Hide();
            Forgot_Password fp = new Forgot_Password();
            fp.Show();
        }
    }
}
