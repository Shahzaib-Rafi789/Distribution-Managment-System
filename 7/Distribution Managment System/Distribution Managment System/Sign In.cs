using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Distribution_Managment_System.Data_Logic;
using Distribution_Managment_System.BL;


namespace Distribution_Managment_System
{
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Sign_In_Load(object sender, EventArgs e)
        {

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUserName.Clear();
        }

        private void btnEye_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == 'O')
            {
                txtPassword.PasswordChar = '\0';
            }
        }
        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //VerifyUser();
            }
        }
        private void btnEye_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = 'O';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = UserDL.LogIn(txtUserName.Text, txtPassword.Text);
            if(user!=null){
                if(user.Role=="Admin")
                    {
                    Admin adm=(Admin) user;
                    Admin_DashBoard adminWindow = new Admin_DashBoard(adm);
                    this.Hide();
                    adminWindow.Show();
                }
                else if (user.Role == "Inventory Supervisor")
                {
                    Inventory_Supervisor Invsup = (Inventory_Supervisor)user;
                    MainWindow adminWindow = new MainWindow(Invsup);
                    this.Hide();
                    adminWindow.Show();
                }
                else if(user.Role == "Transport Manager")
                {

                }
                else if (user.Role == "Sale Representative")
                {

                }
                else if (user.Role == "Order Dispatcher")
                {

                }
            }
            else
            {
                MessageBox.Show("Incorrect Credentials");
            }
        }
    }
}
