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

namespace Distribution_Managment_System
{
    public partial class ChangePassword : Form
    {
        User Actor;
        public ChangePassword(User actor)
        {
            InitializeComponent();
            Actor = actor;
        }

        private void ClearFields()
        {
            txtbxNewP.Text = "";
            txtbxConfirmP.Text = "";
            txtbxOldP.Text = "";
            lblNewPErr.Text = "";
            lblOldPErr.Text = "";
            lblConfirmPErr.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            bool flag = true; ;
            lblNewPErr.Text = "";
            lblOldPErr.Text = "";
            lblConfirmPErr.Text = "";

            //Verification
            if (CheckLen(txtbxNewP.Text, 8, 15))
            {
                flag = false;
                lblNewPErr.Text = "Password length should be between 8 - 15";
                lblNewPErr.ForeColor = Color.Red;
            }

            if (txtbxNewP.Text != txtbxConfirmP.Text)
            {
                flag = false;
                lblConfirmPErr.Text = "Passwords don't match";
                lblConfirmPErr.ForeColor = Color.Red;
            }

            //Main task
            if (flag)
            {
                if (Actor.UpdatePassword(txtbxOldP.Text, txtbxNewP.Text))
                {
                    MessageBox.Show("Password Updated Successfully!!", "Operation Successful");
                    ClearFields();
                }
                else
                    MessageBox.Show("Old and New Password don't match!!", "Operation Unsuccessful");

            }
        }

        private bool CheckLen(string str, int min, int max)
        {
            int length = str.Length;
            if (length < min || length > max)
                return true;
            return false;
        }
    }
}
