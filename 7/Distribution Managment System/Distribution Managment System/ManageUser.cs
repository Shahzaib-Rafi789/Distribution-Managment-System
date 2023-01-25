using Distribution_Managment_System.BL;
using Distribution_Managment_System.Data_Logic;
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
    public partial class ManageUser : Form
    {
        List<int> AllEmp;
        Admin Actor;
        string id;
        bool Pressed = false;
        public ManageUser(Admin actor)
        {
            InitializeComponent();
            Actor = actor;

            //pnlWorkingArea.VerticalScroll.Visible = ;
            //vScrollBar1.Value = pnlWorkingArea.VerticalScroll.Value;
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            pnlUpLeftMid.GetControlFromPosition(0, 4).Visible = false;
            pnlUpLeftMid.Controls[0].Visible = false;
            SetSummary();

            FillTableEmp();
            FillTableSaleReps();
        }

        private void FillTableSaleReps()
        {
            DatGVSaleRep.Rows.Clear();
            foreach (Sale_Representative user in UserDL.GetSaleRep())
                DatGVSaleRep.Rows.Add(user.UserID, user.Name, user.Role, user.Email, user.PhoneNum, user.region);
        }

        private void FillTableEmp()
        {
            DatGVSingletonEmp.Rows.Clear();
            foreach(User user in UserDL.GetNonSaleRep())
                DatGVSingletonEmp.Rows.Add(user.UserID, user.Name, user.Role, user.Email, user.PhoneNum);
        }

        private void SetSummary()
        {
            AllEmp = UserDL.GetAllUsers();
            if (AllEmp[0] != 0)
                lblInvSup.Text = "Employed";
            if (AllEmp[1] != 0)
                lblOrdDisp.Text = "Employed";
            if (AllEmp[2] != 0)
                lblTranMan.Text = "Employed";
            if (AllEmp[3] != 0)
                lblSaleRep.Text = AllEmp[3].ToString();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((cmbbxRole.SelectedItem).ToString() == "Sale Representative")
            {
                pnlUpLeftMid.GetControlFromPosition(0, 4).Visible = true;
                pnlUpLeftMid.Controls[0].Visible = true;
            }
            else
            {
                pnlUpLeftMid.GetControlFromPosition(0, 4).Visible = false;
                pnlUpLeftMid.Controls[0].Visible = false;
            }
        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void ClearFields()
        {
            this.lblContactErr.Text = "";
            this.lblEmailErr.Text = "";
            this.lblNameErr.Text = "";
            this.lblRegionErr.Text = "";
            this.lblRoleErr.Text = "";

            this.txtbxContact.Text = "";
            this.txtbxEmail.Text = "";
            this.txtbxName.Text = "";
            this.cmbbxRole.SelectedIndex = 0;
            this.cmbbxRole.Enabled = true;

            if (cmbbxRegion.Visible)
                this.cmbbxRegion.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();

            pnlUpLeftMid.GetControlFromPosition(0, 4).Visible = false;
            pnlUpLeftMid.Controls[0].Visible = false;

            if (btnClear_Cancel.Text == "CANCEL")
            {
                btnAdd_Edit.Text = "ADD";
                btnClear_Cancel.Text = "CLEAR";
            }

        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SetStatus()
        {
            if (AllEmp[0] == 0)
                lblInvSup.Text = "Unemployed";
            else
                lblInvSup.Text = "Employed";

            if (AllEmp[1] == 0)
                lblOrdDisp.Text = "Unemployed";
            else
                lblOrdDisp.Text = "Employed";

            if (AllEmp[2] == 0)
                lblTranMan.Text = "Unemployed";
            else
                lblTranMan.Text = "Employed";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {
                if (btnAdd_Edit.Text == "ADD")
                {
                    List<string> Emp = new List<string>();
                    Emp.Add("Inventory Supervisor"); Emp.Add("Order Dispatcher"); Emp.Add("Transport Manager");

                    this.btnAdd_Edit.Text = "EDIT";
                    this.btnClear_Cancel.Text = "CANCEL";

                    id = DatGVSingletonEmp.Rows[e.RowIndex].Cells[0].Value.ToString();
                    var user = UserDL.RetrieveUser(id);

                    this.txtbxContact.Text = user.PhoneNum;
                    this.txtbxEmail.Text = user.Email;
                    this.txtbxName.Text = user.Name;
                    this.cmbbxRole.SelectedIndex = Emp.IndexOf(user.Role) + 1;
                    this.cmbbxRole.Enabled = false;
                }
            }

            if (e.ColumnIndex == 6  && btnAdd_Edit.Text == "ADD")
            {
                List<string> Emp = new List<string>();
                Emp.Add("Inventory Supervisor"); Emp.Add("Order Dispatcher"); Emp.Add("Transport Manager");

                string message = "Are you sure you want to delete this user?";
                string title = "Prompt Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    id = DatGVSingletonEmp.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (Actor.DeleteUser(id))
                    {
                        MessageBox.Show("Successfully Deleted", "Delete Operation Successful");
                        string Role = DatGVSingletonEmp.Rows[e.RowIndex].Cells[2].Value.ToString();
                        AllEmp[Emp.IndexOf(Role)] -= 1;
                        SetStatus();
                    }
                    else
                        MessageBox.Show("Unsuccessful Process", "Delete Operation Unsuccessful");

                    FillTableEmp();
                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawImage(Properties.Resources.edit, e.CellBounds);
                e.Handled = true;
            }

            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawImage(Properties.Resources.delete, e.CellBounds);
                e.Handled = true;
            }
        }

        private string AssignSRepId()
        {
            string id = "000" + ((++AllEmp[3]).ToString());
            lblSaleRep.Text = (int.Parse(lblSaleRep.Text) + 1).ToString();

            return id.Substring((id.Length - 4),4);
        }

        private bool CheckLen(string str, int min, int max)
        {
            int length = str.Length;
            if (length < min || length > max)
                return true;
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool flag = true;
            lblNameErr.Text = "";
            lblRegionErr.Text = "";
            lblContactErr.Text = "";
            lblEmailErr.Text = "";
            lblRoleErr.Text = "";

            if (!ContainsAlph(txtbxName.Text) || txtbxName.Text == "")
            {
                lblNameErr.Text += "Incorrect Format";
                lblNameErr.ForeColor = Color.Red;
                flag = false;
            }
            else if (CheckLen(txtbxName.Text, 3, 20))
            {
                lblNameErr.Text += "Length should be between 3-20";
                lblNameErr.ForeColor = Color.Red;
                flag = false;
            }

            if (!ContainsNum(txtbxContact.Text) || txtbxContact.Text == "")
            {
                lblContactErr.Text = "Incorrect Format";

                lblContactErr.ForeColor = Color.Red;
                flag = false;
            }
            else if (CheckLen(txtbxContact.Text, 1, 12))
            {
                lblContactErr.Text += "Length should be between 1-11";
                lblContactErr.ForeColor = Color.Red;
                flag = false;
            }

            if (!txtbxEmail.Text.EndsWith(".com") || !txtbxEmail.Text.Contains("@") || txtbxEmail.Text == "")
            {
                lblEmailErr.Text = "Incorrect Format";

                lblEmailErr.ForeColor = Color.Red;
                flag = false;
            }
            else if (CheckLen(txtbxEmail.Text, 8, 25))
            {
                lblEmailErr.Text += "Length should be between 8-25";
                lblEmailErr.ForeColor = Color.Red;
                flag = false;
            }

            if (cmbbxRole.Text == "" || cmbbxRole.Text == "None")
            {
                lblRoleErr.Text = "Choose!";
                lblRoleErr.ForeColor = Color.Red;
                flag = false;
            }

            if (cmbbxRegion.Text == "" || cmbbxRegion.Text == "None")
            {
                lblRegionErr.Text = "Choose!";
                lblRegionErr.ForeColor = Color.Red;
                if (cmbbxRole.Text == "" || cmbbxRole.SelectedItem.ToString() == "Sale Representative")
                    flag = false;
            }


            if (flag && btnAdd_Edit.Text == "ADD")
            {
                if (cmbbxRole.SelectedItem.ToString() == "Sale Representative")
                {
                    string id = "SRep" + AssignSRepId();
                    Actor.AddUser(new Sale_Representative(id, "Password", txtbxName.Text, cmbbxRole.SelectedItem.ToString(), txtbxEmail.Text, txtbxContact.Text, cmbbxRegion.SelectedItem.ToString()));
                    //UserDL.CreateUser(new Sale_Representative(id, "Password", txtbxName.Text, cmbbxRole.SelectedItem.ToString(), txtbxEmail.Text, txtbxContact.Text, cmbbxRegion.SelectedItem.ToString()));
                    MessageBox.Show("Sale Representative Added!", "Operation Successful");
                    DatGVSaleRep.Rows.Add(id, txtbxName.Text, cmbbxRole.SelectedItem.ToString(), txtbxEmail.Text, txtbxContact.Text, cmbbxRegion.SelectedItem.ToString());
                    ClearFields();
                }
                else
                {
                    if (cmbbxRole.SelectedItem.ToString() == "Inventory Supervisor")
                    {
                        if (AllEmp[0] == 0)
                        {
                            AllEmp[0] = 1;
                            lblInvSup.Text = "Employed";
                            Actor.AddUser(new Inventory_Supervisor("InvS0001", "Password", txtbxName.Text, cmbbxRole.SelectedItem.ToString(), txtbxEmail.Text, txtbxContact.Text));
                            //UserDL.CreateUser(new Inventory_Supervisor("InvS0001", "Password", txtbxName.Text, cmbbxRole.SelectedItem.ToString(), txtbxEmail.Text, txtbxContact.Text));
                            MessageBox.Show("Inventory Supervisor Added!", "Operation Successful");
                            DatGVSingletonEmp.Rows.Add("InvS0001", txtbxName.Text, cmbbxRole.SelectedItem.ToString(), txtbxEmail.Text, txtbxContact.Text);
                            ClearFields();
                        }
                        else
                            MessageBox.Show("Inventory Supervisor Already Exists!", "Operation Unsuccessful");
                    }

                    else if (cmbbxRole.SelectedItem.ToString() == "Order Dispatcher")
                    {
                        if (AllEmp[1] == 0)
                        {
                            AllEmp[1] = 1;
                            lblOrdDisp.Text = "Employed";
                            Actor.AddUser(new Order_Dispatcher("ODis0001", "Password", txtbxName.Text, cmbbxRole.SelectedItem.ToString(), txtbxEmail.Text, txtbxContact.Text));
                            //UserDL.CreateUser(new Order_Dispatcher("ODis0001", "Password", txtbxName.Text, cmbbxRole.SelectedItem.ToString(), txtbxEmail.Text, txtbxContact.Text));
                            MessageBox.Show("Order Dispatcher Added!", "Operation Successful");
                            DatGVSingletonEmp.Rows.Add("ODis0001", txtbxName.Text, cmbbxRole.SelectedItem.ToString(), txtbxEmail.Text, txtbxContact.Text);
                            ClearFields();
                        }
                        else
                            MessageBox.Show("Order Dispatcher Already Exists!", "Operation Unsuccessful");
                    }

                    else if (cmbbxRole.SelectedItem.ToString() == "Transport Manager")
                    {
                        if (AllEmp[2] == 0)
                        {
                            AllEmp[2] = 1;
                            lblTranMan.Text = "Employed";
                            Actor.AddUser(new Transport_Manager("TrMg0001", "Password", txtbxName.Text, cmbbxRole.SelectedItem.ToString(), txtbxEmail.Text, txtbxContact.Text));
                            //UserDL.CreateUser(new Transport_Manager("TrMg0001", "Password", txtbxName.Text, cmbbxRole.SelectedItem.ToString(), txtbxEmail.Text, txtbxContact.Text));
                            MessageBox.Show("Transport Manager Added!", "Operation Successful");
                            DatGVSingletonEmp.Rows.Add("TrMg0001", txtbxName.Text, cmbbxRole.SelectedItem.ToString(), txtbxEmail.Text, txtbxContact.Text);
                            ClearFields();
                        }
                        else
                            MessageBox.Show("Transport Manager Already Exists!", "Operation Unsuccessful");
                    }
                }
            }
            else if (flag && btnAdd_Edit.Text == "EDIT")
            {
                if (cmbbxRole.Text == "Sale Representative")
                {
                    Actor.UpdateUser(UserDL.RetrieveUser(id), new Sale_Representative("", "", txtbxName.Text, "Sale Representative", txtbxEmail.Text, txtbxContact.Text, cmbbxRegion.Text));
                    FillTableSaleReps();
                }
                else
                {
                    Actor.UpdateUser(UserDL.RetrieveUser(id), new Admin("", "", txtbxName.Text, cmbbxRole.Text, txtbxEmail.Text, txtbxContact.Text));
                    FillTableEmp();
                }

                ClearFields();
                btnAdd_Edit.Text = "ADD";
                btnClear_Cancel.Text = "Clear";
            }
        }

        private bool ContainsAlph(string str)
        {
            for(int i= 0; i < str.Length; i++)
            {
                if ((Convert.ToInt16(str[i]) < 65 && Convert.ToInt16(str[i]) != 32) || Convert.ToInt16(str[i]) > 122 || (Convert.ToInt16(str[i]) > 90 && Convert.ToInt16(str[i]) < 97))
                {
                    return false;
                }
            }

            return true;
        }

        private bool ContainsNum(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Convert.ToInt32(str[i]) < 48 || Convert.ToInt32(str[i]) > 57 )
                    return false;
            }

            return true;
        }

        private void pnlUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawImage(Properties.Resources.edit, e.CellBounds);
                e.Handled = true;
            }

            if (e.ColumnIndex == 7)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawImage(Properties.Resources.delete, e.CellBounds);
                e.Handled = true;
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
            {
                if (btnAdd_Edit.Text == "ADD")
                {
                    List<string> Region = new List<string>();
                    Region.Add("Johar Town"); Region.Add("Muslim Town"); Region.Add("Ali Town"); Region.Add("Anarkali");

                    this.btnAdd_Edit.Text = "EDIT";
                    this.btnClear_Cancel.Text = "CANCEL";

                    id = DatGVSaleRep.Rows[e.RowIndex].Cells[0].Value.ToString();
                    var user = UserDL.RetrieveUser(id);

                    this.txtbxContact.Text = user.PhoneNum;
                    this.txtbxEmail.Text = user.Email;
                    this.txtbxName.Text = user.Name;
                    this.cmbbxRole.SelectedIndex = 4;
                    this.cmbbxRole.Enabled = false;
                    this.cmbbxRegion.SelectedIndex = Region.IndexOf(((Sale_Representative)user).region) + 1;
                    //this.cmbbxRegion.Enabled = false;
                }
            }

            if (e.ColumnIndex == 7 && btnAdd_Edit.Text == "ADD")
            {
                string message = "Are you sure you want to delete this user?";
                string title = "Prompt Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    id = DatGVSaleRep.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (Actor.DeleteUser(id))
                    {
                        MessageBox.Show("Successfully Deleted", "Delete Operation Successful");
                        AllEmp[3] -= 1;
                        lblSaleRep.Text = (int.Parse(lblSaleRep.Text) - 1).ToString();
                        FillTableSaleReps();
                    }
                    else
                        MessageBox.Show("Unsuccessful Process", "Delete Operation Unsuccessful");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtbxSearch.Text != "" && txtbxSearch.Text != " " && !txtbxSearch.Text.Contains("  ")) 
            {
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                Pressed = true;
                bool isFound = false;
                for (int i = 0; i < DatGVSaleRep.Rows.Count; i++)
                {
                    if (DatGVSaleRep.Rows[i].Cells[1].Value.ToString().Contains(txtbxSearch.Text))
                    {
                        rows.Add(DatGVSaleRep.Rows[i]);
                        isFound = true;
                    }
                }

                if (isFound)
                {
                    DatGVSaleRep.Rows.Clear();
                    foreach(DataGridViewRow row in rows)
                        DatGVSaleRep.Rows.Add(row);

                    txtbxSearch.Text = "";
                }
                else
                    MessageBox.Show("Not Found!", "Unsuccessful");
            }
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            if (Pressed)
            {
                Pressed = false;
                txtbxSearch.Text = "";
                FillTableSaleReps();
            }
        }

        private void lblSaleRep_Click(object sender, EventArgs e)
        {

        }

        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtbxSearch.Text != "")
            {
                Pressed = true;
                //SearchChange1 = true//
                foreach (DataGridViewRow row in DatGVSaleRep.Rows)
                {
                    bool flag = false;
                    for (int i = 0; i < 6; i++)
                    {
                        if (row.Cells[i].Value.ToString().ToUpper().Contains(txtbxSearch.Text.ToUpper()))
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (!flag) row.Visible = false;
                    else row.Visible = true;
                }
            }

            else
            {
                FillTableSaleReps();
            }
        }
    }
}
