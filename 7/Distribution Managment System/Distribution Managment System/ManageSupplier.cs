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
    public partial class ManageSupplier : Form
    {
        List<int> AllEmp;
        Inventory_Supervisor Actor;
        string id;
        bool Pressed = false;
        public ManageSupplier(Inventory_Supervisor actor)
        {
            InitializeComponent();
            Actor = actor;
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            SetSummary();
            FillTableSuppliers();
        }

        private void FillTableSuppliers()
        {
            DatGVSuppliers.Rows.Clear();
            foreach (Supplier suppl in Supplier_CRUD.Suppliers)
                DatGVSuppliers.Rows.Add(suppl.SupplierID, suppl.Name, suppl.Email, suppl.PhoneNum, suppl.ProdInString(','));
        }


        private void SetSummary()
        {
            //AllEmp = UserDL.GetAllUsers();
            //if (AllEmp[0] != 0)
            //    lblInvSup.Text = "Employed";
            //if (AllEmp[1] != 0)
            //    lblOrdDisp.Text = "Employed";
            //if (AllEmp[2] != 0)
            //    lblTranMan.Text = "Employed";
            //if (AllEmp[3] != 0)
            //    lblSaleRep.Text = AllEmp[3].ToString();
        }

        private void ClearFields()
        {
            this.lblContactErr.Text = "";
            this.lblEmailErr.Text = "";
            this.lblNameErr.Text = "";
            this.lblProdErr.Text = "";

            this.txtbxContact.Text = "";
            this.txtbxEmail.Text = "";
            this.txtbxName.Text = "";
            this.ChkBoxsProd.ClearSelection();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();

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
            //if (AllEmp[0] == 0)
            //    lblInvSup.Text = "Unemployed";
            //else
            //    lblInvSup.Text = "Employed";

            //if (AllEmp[1] == 0)
            //    lblOrdDisp.Text = "Unemployed";
            //else
            //    lblOrdDisp.Text = "Employed";

            //if (AllEmp[2] == 0)
            //    lblTranMan.Text = "Unemployed";
            //else
            //    lblTranMan.Text = "Employed";

        }


        private string AssignSuppId()
        {
            string id = "000" + ((++AllEmp[3]).ToString());
            //lblSaleRep.Text = (int.Parse(lblSaleRep.Text) + 1).ToString();

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
            lblContactErr.Text = "";
            lblEmailErr.Text = "";
            lblProdErr.Text = "";

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
            else if (CheckLen(txtbxContact.Text, 9, 11))
            {
                lblContactErr.Text += "Length should be between 8-11";
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

            if (ChkBoxsProd.Text == "")
            {
                lblProdErr.Text  = "Check atleast one item.";
                lblProdErr.ForeColor = Color.Red;
                flag = false;

            }


            if (flag && btnAdd_Edit.Text == "ADD")
            {
                Actor.AddSupplier(new Supplier("", txtbxName.Text, txtbxEmail.Text, txtbxContact.Text, Supplier_CRUD.getProdList(ChkBoxsProd.Text.Split(',').ToList())));
                DatGVSuppliers.Rows.Add("", txtbxName.Text, txtbxEmail.Text, txtbxContact.Text, ChkBoxsProd.Text);
                ClearFields();
            }

            else if (flag && btnAdd_Edit.Text == "EDIT")
            {
                Actor.UpdateSupplier(Supplier_CRUD.RetrieveSupplier(id), new Supplier("", txtbxName.Text, txtbxEmail.Text, txtbxContact.Text, Supplier_CRUD.getProdList(ChkBoxsProd.Text.Split(',').ToList())));
                FillTableSuppliers();
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

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {
                if (btnAdd_Edit.Text == "ADD")
                {
                    this.btnAdd_Edit.Text = "EDIT";
                    this.btnClear_Cancel.Text = "CANCEL";

                    id = DatGVSuppliers.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.txtbxContact.Text = DatGVSuppliers.Rows[e.RowIndex].Cells[3].Value.ToString(); 
                    this.txtbxEmail.Text = DatGVSuppliers.Rows[e.RowIndex].Cells[2].Value.ToString(); 
                    this.txtbxName.Text = DatGVSuppliers.Rows[e.RowIndex].Cells[1].Value.ToString();

                    List<string> prods = DatGVSuppliers.Rows[e.RowIndex].Cells[4].Value.ToString().Split(',').ToList();
                    for (int s = 0; s < prods.Count; s++)
                    {
                        try{
                            if (prods[s][0] == ' ') { prods[s] = prods[s].Substring(1, prods[s].Length - 1); }
                            if (prods[s][prods[s].Length - 1] == ' ') { prods[s] = prods[s].Substring(0, prods[s].Length - 1); }
                            this.ChkBoxsProd.CheckBoxItems[prods[s]].Checked = true;
                        }
                        catch { }
                    }
                }
            }

            if (e.ColumnIndex == 6 && btnAdd_Edit.Text == "ADD")
            {
                string message = "Are you sure you want to delete this supplier?";
                string title = "Prompt Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    id = DatGVSuppliers.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (Actor.DeleteSupplier(id))
                    {
                        MessageBox.Show("Successfully Deleted", "Delete Operation Successful");
                        FillTableSuppliers();
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
                for (int i = 0; i < DatGVSuppliers.Rows.Count; i++)
                {
                    if (DatGVSuppliers.Rows[i].Cells[1].Value.ToString().Contains(txtbxSearch.Text))
                    {
                        rows.Add(DatGVSuppliers.Rows[i]);
                        isFound = true;
                    }
                }

                if (isFound)
                {
                    DatGVSuppliers.Rows.Clear();
                    foreach(DataGridViewRow row in rows)
                        DatGVSuppliers.Rows.Add(row);

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
                FillTableSuppliers();
            }
        }

        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtbxSearch.Text != "")
            {
                Pressed = true;
                //SearchChange1 = true//
                foreach (DataGridViewRow row in DatGVSuppliers.Rows)
                {
                    bool flag = false;
                    for (int i = 0; i < 5; i++)
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
                FillTableSuppliers();
            }
        }
    }
}
