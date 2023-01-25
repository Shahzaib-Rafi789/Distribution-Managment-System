using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Distribution_Managment_System.BL;
using Distribution_Managment_System.Data_Logic;
using Distribution_Managment_System.UI;

namespace Distribution_Managment_System
{
    public partial class Product_Dashboard : Form
    {
        Product record;
        Inventory_Supervisor Actor=new Inventory_Supervisor("IS0001","123","Subhan","Inventory SUpervisor","mail.com","03248495069");
        public Product_Dashboard()
        {
            InitializeComponent();
        }
        public Product_Dashboard(Inventory_Supervisor Actor)
        {
            InitializeComponent();
            this.Actor = Actor;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Product_Dashboard_Load(object sender, EventArgs e)
        {
            GenID();
            BindDataWithSuplliersComboBox();
            DataBind();
            GridColor();
        }
        private void GenID()
        {
            txtID.Enabled = false;
            string value = ((int)Products_CRUD.TotalProducts() / 10 == 0) ? "000" + Products_CRUD.TotalProducts().ToString() : ((int)Products_CRUD.TotalProducts() / 100 == 0) ? "00" + (Products_CRUD.TotalProducts().ToString()) : ((int)Products_CRUD.TotalProducts() / 1000 == 0) ? "0" + (Products_CRUD.TotalProducts().ToString()) : Products_CRUD.TotalProducts().ToString();
            txtID.Text = "PR" + value;
        }
        private void BindDataWithSuplliersComboBox()
        {

            List<string> nameofSupllier = new List<string> { "Apple Inc.", "Samsung Electronics Co. Ltd.", "Hon Hai Precision Industry Co. Ltd.", "Microsoft Corp.", "Dell Technologies Inc.", "Sony Corp.", "International Business Machines Corp.", "Intel Corp.", "Panasonic Corp.", "HP Inc." };
            //nameofSupllier = SupplerCRUD.NameofAllSuplliers();
            foreach (string sup in nameofSupllier)
            {
                cmbSupplier.Items.Add(sup);

            }
        }
        public void DataBind()
        {
            gvProducts.DataSource = null;
            gvProducts.Rows.Clear();
            gvProducts.DataSource = Products_CRUD.AllProducts();
            // gvProducts.DataSource = this._controller.OrderActionData;
            gvProducts.Refresh();
        }

        private void btnSubmitt_Click(object sender, EventArgs e)
        {
            if (btnSubmitt.Text == "SAVE")
            {

                string Error = CheckEmpty();
                if (Error == "")
                {
                    Product rec = new Product(txtID.Text, txtName.Text, txtBrand.Text, (float)numUDSale.Value, (float)numUDCost.Value, (int)numUDThreshold.Value);
                    Actor.AddProduct(rec);
                    MessageBox.Show("Product added Sucessfully...");
                    Erase();
                    GenID();
                    DataBind();
                    GridColor();
                }
                else
                {
                    MessageBox.Show(Error);
                }
            }
            else
            {
                DialogResult save = MessageBox.Show("Do you want to update record?", "CONFIRM UPDATION", MessageBoxButtons.YesNo);
                if (save == DialogResult.Yes)
                {
                    Product record = new Product(txtID.Text, txtName.Text, txtBrand.Text, (float)numUDSale.Value, (float)numUDCost.Value, (int)numUDThreshold.Value);
                    Actor.UpdateProduct(record);
                    btnSubmitt.Text = "SAVE";
                    btnClear.Text = "CLEAR";
                    Erase();
                    GenID();
                    DataBind();
                    GridColor();
                }
            }
        }




        private string CheckEmpty()
        {
            string error = "";
            if (txtName.Text == "")
            {
                error += "Name Text Box is empty\n";
            }
            if (txtBrand.Text == "")
            {
                error += "Brand Text Box is empty\n";
            }
            if (numUDCost.Value > numUDSale.Value)
            {
                error += "Cost Price can never be greater than Sale Price\n";
            }
            if (numUDCost.Value == 0)
            {
                error += "Cost Price can never be zero\n";
            }
            if (numUDSale.Value == 0)
            {
                error += "Cost Price can never be zero\n";
            }
            /*if (cmbSupllier.SelectedIndex < 0)
            {
                error += "Selcet Supplier\n";
            }*/

            return error;
        }
        public void GridColor()
        {
            for (int i = 0; i < gvProducts.Columns.Count; i++)
            {
                gvProducts.Columns[i].HeaderCell.Style.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
                gvProducts.Columns[i].HeaderCell.Style.ForeColor = Color.Black;
                gvProducts.Columns[i].DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular);

                if (i % 2 == 0)
                {
                    gvProducts.Columns[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
                else
                {
                    gvProducts.Columns[i].DefaultCellStyle.BackColor = Color.Gainsboro;
                }
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            Erase();
            GenID();
            btnSubmitt.Text = "SAVE";
            btnClear.Text = "CLEAR";
        }
        public void Erase()
        {
            txtName.Text = "";
            txtBrand.Text = "";
            numUDCost.Value = 0;
            numUDThreshold.Value = 0;
            numUDSale.Value = 0;
            numUDCost.ResetText();
            numUDThreshold.ResetText();
            numUDSale.ResetText();
            cmbSupplier.ClearSelection();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 32 && e.KeyChar != 13 && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtBrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 32 && e.KeyChar != 13 && e.KeyChar != 8)
                e.Handled = true;
        }

        private void numUDCost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numUDSale_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvProducts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            record = (Product)gvProducts.CurrentRow.DataBoundItem;
            if (gvProducts.Columns["EDIT"].Index == e.ColumnIndex)
            {
                lblTtleBar.Text = "Edit Products";
                txtID.Text = record.ProductID;
                txtName.Text = record.ProductName;
                txtBrand.Text = record.Brand;
                numUDThreshold.Value = record.ThresholdValue;
                numUDCost.Value = (decimal)record.CostPrice;
                numUDSale.Value = (decimal)record.SalePrice;
                btnSubmitt.Text = "UPDATE";
                btnClear.Text = "CANCEL";
            }
            else if (gvProducts.Columns["DELETE"].Index == e.ColumnIndex)
            {
                DialogResult delete = MessageBox.Show("Do you want to delete record?", "CONFIRM DELETION", MessageBoxButtons.YesNo);
                if (delete == DialogResult.Yes)
                {
                    Products_CRUD.DeleteaRec(record);
                    //UserDL.StoreAllData(path);
                    DataBind();
                    GridColor();
                }
            }
        }

        private void Product_Dashboard_Resize(object sender, EventArgs e)
        {
            float newSize =12.2f;
            if (this.Width < 825)
            {
                if (this.Width < 615)
                {
                    newSize = 10.2f;
                }
            }
            else
            { 
                newSize = 16f; 
            }
            lblProductID.Font = new Font(lblProduct.Font.FontFamily, newSize, lblProduct.Font.Style);
            lblProduct.Font = new Font(lblProduct.Font.FontFamily, newSize, lblProduct.Font.Style);
            lblBrand.Font = new Font(lblProduct.Font.FontFamily, newSize, lblProduct.Font.Style);
            lblThreshold.Font = new Font(lblProduct.Font.FontFamily, newSize, lblProduct.Font.Style);
            lblSalePrice.Font = new Font(lblProduct.Font.FontFamily, newSize, lblProduct.Font.Style);
            lblCostPrice.Font = new Font(lblProduct.Font.FontFamily, newSize, lblProduct.Font.Style);
            lblSupplier.Font = new Font(lblProduct.Font.FontFamily, newSize, lblProduct.Font.Style);
            txtID.Font=new Font(lblProduct.Font.FontFamily, newSize, lblProduct.Font.Style);
            txtName.Font=new Font(lblProduct.Font.FontFamily, newSize, lblProduct.Font.Style);
            txtBrand.Font=new Font(lblProduct.Font.FontFamily, newSize, lblProduct.Font.Style);
            numUDCost.Font=new Font(lblProduct.Font.FontFamily, newSize, lblProduct.Font.Style);
            numUDSale.Font=new Font(lblProduct.Font.FontFamily, newSize, lblProduct.Font.Style);
            numUDThreshold.Font=new Font(lblProduct.Font.FontFamily, newSize, lblProduct.Font.Style);
            cmbSupplier.Font = new Font(lblProduct.Font.FontFamily, newSize, lblProduct.Font.Style);
            btnClear.Font = new Font(btnClear.Font.FontFamily, newSize, btnClear.Font.Style);
            btnSubmitt.Font = new Font(btnClear.Font.FontFamily, newSize, btnClear.Font.Style);
            
        }

        private void lblTtleBar_Click(object sender, EventArgs e)
        {

        }
    }
}
