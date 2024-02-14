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
    public partial class AdminDoctor : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ANJANA;Initial Catalog=Hospital;Integrated Security=True");
        public AdminDoctor()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "Insert into Doctors values('" + txt_DocName.Text + "','" + txt_Specialisty.Text + "')";
                int i = db.save_update_delete(query);
                if (i == 1)
                {
                    MessageBox.Show("Doctor add sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data cannot save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_searchDoc.Text.Length == 0)
                {
                    datagrid_AddDoc.DataSource = db.getData("Select * from Doctors");
                }
                else
                {
                    datagrid_AddDoc.DataSource = db.getData("Select * from Doctors where Doctor_Name LIKE '" + txt_searchDoc.Text + "%'");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            string query = "Delete from  Doctors where Doctor_Name='"+txt_DocName.Text+"' ";
            int i = db.save_update_delete(query);
            if (i == 1)
            {
                MessageBox.Show("Are you sure you want to delete this record ", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cannot delete please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AdminDoctor_Load(object sender, EventArgs e)
        {
            
         
            

        }

        private void datagrid_AddDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            


                




            
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //try
            //{
            string query = "Update Doctors set Specialisty='" + txt_Specialisty.SelectedItem + "' where Doctor_Name='" + txt_DocName.Text + "'";
            int i = db.save_update_delete(query);
            if (i == 1)
            {
                MessageBox.Show("Update sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update unsucessfull", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //}
            //catch(Exception)
            // {
            //MessageBox.Show("Something error please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }
    }
}