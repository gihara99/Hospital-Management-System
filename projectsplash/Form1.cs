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
    public partial class splash_screen : Form
    {
        public splash_screen()
        {
            InitializeComponent();
        }

        

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ProgressBar.Value == 100)
            {
                timer1.Stop();
                Home_menu hm = new Home_menu();
                hm.Show();
                this.Hide();
            }
            else
            {
                ProgressBar.Value += 1;
                Label1.Text ="Loading.." + ProgressBar.Value.ToString() + "%";

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

