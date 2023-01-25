using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Distribution_Managment_System.BL;
using Distribution_Managment_System.Data_Logic;

namespace Distribution_Managment_System
{
    public partial class Admin_DashBoard : Form
    {
        private Form activeForm;
        Admin Actor;
        public Admin_DashBoard(User actor)
        {
            InitializeComponent();
            Actor = (Admin)actor;
        }

        private void label1_Click(object sender, EventArgs e)
        { 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlWorkarea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlWorkArea.Controls.Add(childForm);
            this.pnlWorkArea.Tag = childForm;
            //this.pnlWorkArea.Anchor = AnchorStyles.None;
            childForm.BringToFront();
            childForm.Show();
            //lblTtleBar.Text = childForm.Text;
        }


        private void btnManageUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageUser(Actor));
            //lblTtleBar.Text = "Manage Users";
        }

        private void btnManageUser_MouseEnter(object sender, EventArgs e)
        {
            btnManageUser.BackColor = Color.FromArgb(0, 151, 136);
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.Transparent;
        }

        private void btnchagePassword_MouseEnter(object sender, EventArgs e)
        {
            this.btnchagePassword.BackColor = Color.FromArgb(0, 151, 136);
        }

        private void btnManageUser_MouseLeave(object sender, EventArgs e)
        {
            btnManageUser.BackColor = Color.Transparent;
        }

        private void btnReports_MouseEnter(object sender, EventArgs e)
        {
            btnReports.BackColor = Color.FromArgb(0, 151, 136);
        }

        private void btnReports_MouseLeave(object sender, EventArgs e)
        {
            btnReports.BackColor = Color.Transparent;
        }

        private void btnchagePassword_MouseLeave(object sender, EventArgs e)
        {
            btnchagePassword.BackColor = Color.Transparent;
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.FromArgb(0, 151, 136);
        }

        private void btnchagePassword_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangePassword(Actor));
        }
    }
}
