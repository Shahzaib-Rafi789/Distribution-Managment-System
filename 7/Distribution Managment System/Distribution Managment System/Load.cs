using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribution_Managment_System
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void Load_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int initialpoint = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            initialpoint += 10;
            PBLoad.Value = initialpoint;
            if (PBLoad.Value == 100)
            {
                timer1.Stop();
                //SignInForm logIn = new SignInForm();
                Sign_In logIn = new Sign_In();
                this.Hide();
                logIn.Show();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
