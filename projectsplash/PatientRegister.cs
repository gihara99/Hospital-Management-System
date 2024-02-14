using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace projectsplash
{
    public partial class PatientRegister : Form
    {
        public PatientRegister()
        {
            InitializeComponent();
        }
        Database db = new Database();
        

        private void dob_picker_ValueChanged(object sender, EventArgs e)
        {
            txt_age.Text = (DateTime.Now.Year - dob_picker.Value.Year).ToString();
        }

        private void PatientRegister_Load(object sender, EventArgs e)
        {

        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_name.Text))
            {
                error_msg1.Text = "Namme can't be blank";
                txt_name.Focus();
            }
            else if (txt_name.Text.Any(char.IsDigit))
            {
                error_msg1.Text = "Name can't have Numbers";
                txt_name.Focus();
            }
            else if (txt_password.Text.Length == 0)
            {
                error_msg2.Text = "Please enter password";
                txt_password.Focus();
            }
            else if (txt_conPassword.Text.Length == 0)
            {
                error_msg3.Text = "Please enter your confirm password";
                txt_conPassword.Focus();
            }
            else if (txt_password.Text != txt_conPassword.Text)
            {
                error_msg3.Text = "Confirm password must same as the password";
                txt_conPassword.Focus();
            }
            else if (string.IsNullOrEmpty(txt_address.Text))
            {
                error_msg4.Text = "Address can't be blank";
                txt_address.Focus();
            }
            else if (!Regex.IsMatch(txt_mbNumber.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                error_msg5.Text = "Mobile number must have 10 numbers";
                txt_mbNumber.Focus();
            }
            else if (txt_email.Text.Length == 0)
            {
                error_msg6.Text = "please enter Email Address";
                txt_email.Focus();
            }
            //else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w.-][a-zA-Z0-9]@[a-zA-Z0-9][\w.-][a-zA-Z0-9].[a-zA-Z][a-zA-Z.]*[a-zA-Z]$"))
            //{
            //error_msg7.Text = "Enter a valid Email . Ex: name@gmail.com";
            //txt_email.Focus();
            //}
            else
            {
                error_msg1.Text = "";

                error_msg2.Text = "";
                error_msg3.Text = "";
                error_msg4.Text = "";
                error_msg5.Text = "";
                error_msg6.Text = "";
                
                string query = "Insert into patient_Registration values('" + txt_name.Text + "','" + dob_picker.Value + "','" + txt_age.Text + "','" + txt_password.Text + "','" + txt_address.Text + "','" + txt_mbNumber.Text + "','" + txt_email.Text + "')";
                int i = db.save_update_delete(query);
                if (i == 1)
                {
                    MessageBox.Show("Account create successfully", "Inforrmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something wrong, Please try again ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                   

            



            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_age.Clear();
            txt_password.Clear();
            txt_conPassword.Clear();
            txt_address.Clear();
            txt_mbNumber.Clear();
            txt_email.Clear();
            
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            Home_menu hm = new Home_menu();
            hm.Show();
        }
    }
}
