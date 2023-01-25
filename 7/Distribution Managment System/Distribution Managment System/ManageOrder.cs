using DevExpress.Utils.Extensions;
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
    public partial class ManageOrder : Form
    {
        //TO-DO 3rd line in manageOrder constructor
        //TO-DO Region for all orders, shop, sale Reps

        Sale_Representative Actor;
        string id, shop;
        bool SearchChange1 = false, SearchChange2 = false, OrderChange = false; // Handled Data grid view while searching like edit & delete
        string Mode = "Normal"; //Adding, Viewing, Editiing, Searching
        string SecondMode = ""; //Inserting or Updating
        List<Order> CurrOrders = new List<Order>();

        public ManageOrder(Sale_Representative actor)
        {
            InitializeComponent();
            Actor = actor;
            Actor = new Sale_Representative("", "", "", "", "", "", "");
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            Mode = "Normal";
            lblProcess.Text = "Current Process: ";
            lblMode.Text = Mode;

            cmbbxProd.DataSource = Products_CRUD.GetAllProdName();
            txtbxOrderId.Text = CRUD_Orders.GenNewID();

            //cmbbxShops.DataSource = Shopkeepers_CRUD.GetAllShops();
            CurrOrders = CRUD_Orders.GetCurrentOrder(Actor.region);
            FillTableOrders(CurrOrders);
        }

        private void FillTableOrders(List<Order> CurrentOrders) //0 for All, 1 for filtered
        {
            DatGVDayOrder.Rows.Clear();
            foreach (Order order in CurrentOrders)
            {
                DatGVDayOrder.Rows.Add(order.Date.ToString("dd/MM/yyyy"), order.OrderId, Shops_CRUD.GetShopInfo(order.ShopId), order.Order_Status);
                //RealRowsOrder.Add(order.Date.ToString("dd/MM/yyyy"), order.OrderId, Shops_CRUD.GetShopInfo(order.ShopId), order.Order_Status);
            }

        }

        private void ProdIntoTable(List<OrderLine> lst) // //0 for All, 1 for filtered
        {
            foreach (OrderLine orderLine in lst)
                DatGVOrderProducts.Rows.Add(orderLine.ProductName, orderLine.QuantityGiven);
        }

        private DataGridViewColumn UpdateCol()
        {
            DataGridViewColumn Update = new DataGridViewColumn();
            Update.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Update.CellTemplate = new DataGridViewButtonCell();
            Update.Name = "Update";
            Update.HeaderText = "UPDATE";
            Update.DefaultCellStyle.Font = new Font("Century Gothic", 8.25F);

            return Update;
        }

        private DataGridViewColumn DeleteCol()
        {
            DataGridViewColumn Delete = new DataGridViewColumn();
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.CellTemplate = new DataGridViewButtonCell();
            Delete.Name = "Delete";
            Delete.HeaderText = "DELETE";
            Delete.DefaultCellStyle.Font = new Font("Century Gothic", 8.25F);

            return Delete;
        }

        private void ChangeMode(string mode)
        {
            string OldMod = Mode;
            Mode = mode;
            lblMode.Text = Mode;

            if (mode == "Normal" || mode == "Viewing")
            {
                cmbbxProd.SelectedIndex = -1;
                txtbxQuantity.Value = 0;
                btnAdd__Edit.Text = "START";
                btnEdit.Enabled = false;
                btnEdit.Visible = false;
                btnADDProd.Enabled = true;

                if (OldMod != "Viewing")
                    cmbbxShops.SelectedIndex = -1;

                if (mode == "Normal")
                {
                    ChngEnableProdPanels(false);
                    txtbxOrderId.Text = CRUD_Orders.GenNewID();
                }
                else
                    ChngEnablePnl(true);

                if (DatGVOrderProducts.Columns.Count > 3)
                    DatGVOrderProducts.Columns.RemoveAt(3);
                if (DatGVOrderProducts.Columns.Count > 2)
                    DatGVOrderProducts.Columns.RemoveAt(2);
            }

            else if (mode == "Adding")
            {
                btnAdd__Edit.Text = "SAVE ORDER";
                ChngEnableProdPanels(true);

                DatGVOrderProducts.Rows.Clear();
                DatGVOrderProducts.Columns.Insert(2, DeleteCol());
            }

            else if (mode == "Editing")
            {
                ChngEnableProdPanels(true);
                btnClear_Cancel.Text = "CANCEL";
                btnAdd__Edit.Text = "SAVE CHANGES";
                btnEdit.Enabled = false;
                btnEdit.Visible = true;
                ChangeSecondaryMode("Inserting");

                DatGVOrderProducts.Columns.Insert(2, UpdateCol());
                DatGVOrderProducts.Columns.Insert(3, DeleteCol());
            }
        }

        private void ChangeSecondaryMode(string mode)
        {
            SecondMode = mode;
            if (mode == "Inserting")
            {
                cmbbxProd.Enabled = true;
                cmbbxProd.SelectedIndex = -1;
                txtbxQuantity.Value = 0;
                btnEdit.Enabled = false;
                btnEdit.Visible = true;
                btnADDProd.Enabled = true;
                btnClr.Text = "CLEAR";
            }
            else if (mode == "Updating")
            {
                cmbbxProd.Enabled = false;
                cmbbxProd.SelectedIndex = -1;
                btnEdit.Enabled = true;
                btnEdit.Visible = true;
                btnADDProd.Enabled = false;
                btnClr.Text = "CANCEL";
            }
            else if (mode == "")
            {
                btnClear.Text = "Clear";
                ChangeMode("Normal");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ChangeMode("Normal");
            ChangeSecondaryMode("");
        }

        private void ChngEnableProdPanels(bool flag)
        {
            btnClear_Cancel.Enabled = flag;
            pnlAddProd.Enabled = flag;
            ChngEnablePnl(flag);
        }

        private void ChngEnablePnl(bool flag)
        {
            pnlOrderItems.Enabled = flag;
            DatGVOrderProducts.Rows.Clear();
            btnClr.Enabled = flag;
        }

        private List<OrderLine> OrderLineListFromTable()
        {
            List<OrderLine> list = new List<OrderLine>();

            foreach (DataGridViewRow row in DatGVOrderProducts.Rows)
            {
                float Price = Products_CRUD.GetProdByName(row.Cells["ProdName"].Value.ToString()).SalePrice;
                list.Add(new OrderLine(txtbxOrderId.Text, int.Parse(row.Cells["Quantity"].Value.ToString()), row.Cells["ProdName"].Value.ToString(), Price));
            }
            return list;
        }

        private void GiveErrMsg()
        {
            if (Mode == "Viewing")
                MessageBox.Show("Current Process: Viewing\nPress CLEAR on ORDER LINES table to end this process. ", "Error!!");

            else if (Mode == "Adding")
                MessageBox.Show("Current Process: Adding\nPress CANCEL ORDER or SAVE ORDER on ADD AN ORDER form to end this process. ", "Error!!");

            else if (Mode == "Editing")
                MessageBox.Show("Current Process: Editing\nPress CANCEL CHANGES or SAVE CHANGES on ADD AN ORDER form to end this process. ", "Error!!");
        }

        private string sliceId(string id)
        {
            List<string> n = id.Split(',').ToList();
            if (n.Count == 1) return id;
            else
                if (n[2][0] == ' ') return n[2].Substring(1);
                else return n[2];
        }

        private bool ShpAlreadyOrdered(string id) // One shop can place one order per day
        {
            string ID = sliceId(id);
            for (int i = 0; i < DatGVDayOrder.Rows.Count; i++)
            {
                if (DatGVDayOrder.Rows[i].Cells["SHOP_NAME"].Value == null) return false;
                if (sliceId(DatGVDayOrder.Rows[i].Cells["SHOP_NAME"].Value.ToString()).Contains(ID))
                    return true;
            }

            return false;
        }

        private void bthSave_Edit_Click(object sender, EventArgs e)
        {
            lblShopErr.Text = "";

            if (Mode == "Normal" && btnAdd__Edit.Text == "START")
            {
                if (cmbbxShops.Text != "" && cmbbxShops.SelectedIndex != -1)
                {
                    string id = (cmbbxShops.Text.Split(',')[2]).Substring(1);
                    if (!ShpAlreadyOrdered(id))
                        ChangeMode("Adding");
                    else
                        MessageBox.Show("Shop has already placed Order.", "Error!");
                }
                else
                {
                    lblShopErr.Text = "Please Select a Shop!!";
                    lblShopErr.ForeColor = Color.Red;
                }
            }

            else if (Mode == "Adding" && btnAdd__Edit.Text == "SAVE ORDER")
            {
                if (cmbbxShops.Text != "" && cmbbxShops.SelectedIndex != -1)
                {
                    if (DatGVOrderProducts.Rows.Count == 0)
                    {
                        MessageBox.Show("No products Added!!\nAdd atleast one product to continue.", "Operation Unsuccessful");
                    }
                    else
                    {
                        string id = (cmbbxShops.Text.Split(',')[2]).Substring(1);                                                
                        Order NewOrder = new Order(txtbxOrderId.Text, id, DateTime.Now, OrderLineListFromTable());
                        Actor.AddOrder(NewOrder);
                        CurrOrders.Add(NewOrder);
                        if (SearchChange1) ClearSrch();

                        DatGVDayOrder.Rows.Add(DateTime.Now.ToString("dd/MM/yyyy"), txtbxOrderId.Text, cmbbxShops.Text, OrderStatus.Processing);
                        ChangeMode("Normal");

                        txtbxOrderId.Text = CRUD_Orders.GenNewID();
                        
                    }
                }
                else
                {
                    lblShopErr.Text = "Please Select a Shop!!";
                    lblShopErr.ForeColor = Color.Red;
                }
            }

            else if (Mode == "Editing")
            {
                bool Flag = true;
                if (cmbbxShops.Text == "" || cmbbxShops.SelectedIndex == -1)
                {
                    lblShopErr.Text = "Please Select a Shop!!";
                    lblShopErr.ForeColor = Color.Red;
                    Flag = false;
                }
                else if (DatGVOrderProducts.Rows.Count == 0)
                {
                    MessageBox.Show("Order must have a product!!", "Error!");
                    Flag = false;
                }

                if (Flag)            
                {
                    bool flag = true;
                    //DatGVDayOrder.Rows[DatGVDayOrder]
                    if (cmbbxShops.Text.EndsWith(shop)) { flag = false; } 
                    
                    if (flag && ShpAlreadyOrdered((cmbbxShops.Text.Split(',')[2]).Substring(1)))
                        MessageBox.Show("Shop has already placed Order.", "Error!");

                    else
                    {
                        bool tableError = true;
                        if (flag)
                        {
                            int index = indexById(id);
                            if (index != -1)
                            {
                                 tableError = false;
                                DatGVDayOrder.Rows[index].Cells["SHOP_NAME"].Value = cmbbxShops.Text;
                            }
                        }

                        Actor.UpdateOrder(CRUD_Orders.RetrieveOrder(id), new Order("", (cmbbxShops.Text.Split(',')[2]).Substring(1), DateTime.Now, OrderLineListFromTable()), flag, OrderChange);
                        CurrOrders = CRUD_Orders.GetCurrentOrder(Actor.region);
                        if (SearchChange1) ClearSrch();
                        else if (tableError) FillTableOrders( CurrOrders);
                        
                        ChangeMode("Normal");
                    }
                }
            }

            else
            {
                GiveErrMsg();
            }
            
        }

        private void pnlUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DatGvDayOrders_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (DatGVDayOrder.Columns[e.ColumnIndex].Name == "View")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawImage(Properties.Resources.detail, e.CellBounds);
                e.Handled = true;
            }

            if (DatGVDayOrder.Columns[e.ColumnIndex].Name == "Update")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawImage(Properties.Resources.edit, e.CellBounds);
                e.Handled = true;
            }

            if (DatGVDayOrder.Columns[e.ColumnIndex].Name == "Delete")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawImage(Properties.Resources.delete, e.CellBounds);
                e.Handled = true;
            }
        }
               
        private void DatGvDayOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            
            if (DatGVDayOrder.Columns[e.ColumnIndex].Name == "View")
            {
                if (Mode == "Normal" || Mode == "Viewing")
                {
                    //btnClr.Enabled = true;
                    ChangeMode("Viewing");

                    string id = DatGVDayOrder.Rows[e.RowIndex].Cells["OrderId"].Value.ToString();
                    List<OrderLine> orderLines = new List<OrderLine>();
                    orderLines = CRUD_Orders.RetrieveOrder(id).OrderLineList;
                    ProdIntoTable(orderLines);
                    //Mode = "Viewing";
                }
                else
                    GiveErrMsg();
                    //MessageBox.Show("Unable To View!!\nAnother operation under process","Error");
            }


            if (DatGVDayOrder.Columns[e.ColumnIndex].Name == "Update")
            {
                if (Mode == "Normal")
                {
                    string status = DatGVDayOrder.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                    if (status != OrderStatus.Processing.ToString())
                    { 
                        MessageBox.Show("Updation not allowed after Order Status has changed", "Operation Unsuccessful");
                        return;
                    }

                    ChangeMode("Editing");

                    id = DatGVDayOrder.Rows[e.RowIndex].Cells["OrderId"].Value.ToString();
                    shop = DatGVDayOrder.Rows[e.RowIndex].Cells["SHOP_NAME"].Value.ToString();
                    OrderChange = false;

                    txtbxOrderId.Text = id;
                    int sindex = cmbbxShops.Items.IndexOf(shop);
                    if (sindex == -1)
                    {
                        int count = 0;
                        foreach (string i in cmbbxShops.Items) { 
                            if (i.EndsWith(shop)){ sindex = count; break;}
                            count++;
                        }
                    }

                    cmbbxShops.SelectedIndex = sindex;
                    List<OrderLine> orderLines = new List<OrderLine>();
                    orderLines = CRUD_Orders.RetrieveOrder(id).OrderLineList;
                    ProdIntoTable(orderLines);
                }
                else
                    GiveErrMsg();
            } 
            

            if (DatGVDayOrder.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (Mode == "Normal")
                {
                    //string status = DatGVDayOrder.Rows[e.ColumnIndex].Cells["Status"].ToString();
                    //if (status == "Awaiting Confirmation" || status == "Canceled")
                    string message = "Remove Order?";
                    string title = "Prompt Window";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        if (Actor.DeleteOrder(DatGVDayOrder.Rows[e.RowIndex].Cells["OrderId"].Value.ToString()))
                        {
                            CurrOrders = CRUD_Orders.GetCurrentOrder(Actor.region);
                            DatGVDayOrder.Rows.RemoveAt(e.RowIndex);
                            if (SearchChange1) ClearSrch();
                            MessageBox.Show("Order Deleted Successfully", "Operation Successful");
                        }
                        else
                            MessageBox.Show("Order Deletion Unsuccessful", "Operation Unsuccessful");
                    }
                }
                else
                {
                    GiveErrMsg();
                }
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //if(txtbxSearch.Text != "" && txtbxSearch.Text != " " && !txtbxSearch.Text.Contains("  ")) 
            //{
            //    SearchRowsOrder = new List<DataGridViewRow>();
            //    Pressed = true;
            //    bool isFound = false;

            //    for (int i = 0; i < DatGVDayOrder.Rows.Count; i++)
            //    {
            //        if (DatGVDayOrder.Rows[i].Cells["SHOP_NAME"].Value == null) continue;
            //        if (DatGVDayOrder.Rows[i].Cells["SHOP_NAME"].Value.ToString().Contains(txtbxSearch.Text))
            //        {
            //            SearchRowsOrder.Add(DatGVDayOrder.Rows[i]);
            //            isFound = true;
            //        }
            //    }

            //    if (isFound)
            //    {
            //        FillTableOrders(SearchRowsOrder);
            //        txtbxSearch.Text = "";
            //    }
            //    else
            //        MessageBox.Show("Not Found!", "Unsuccessful");
            //}
        }

        private void ClearSrch()
        {
            txtbxSearch.Text = "";
            SearchChange1 = false;
            FillTableOrders(CurrOrders);
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            if (SearchChange1)
            {
                ClearSrch();
            }
        }

        private int indexById(string id)
        {
            int count = 0;
            foreach (DataGridViewRow row in DatGVDayOrder.Rows)
            {
                if (row.Cells["OrderId"].Value.ToString() == id)
                    return count;
                count++;
            }

            return -1;
        }

        private int ProdAlreadyPresent(string ProdName)
        {
            int index = -1;
            for (int i = 0; i < DatGVOrderProducts.Rows.Count; i++)
            {
                if (DatGVOrderProducts.Rows[i].Cells["ProdName"].Value.ToString() == ProdName)
                    return i;
            }

            return index;
        }

        private void ClearProdFields()
        {
            cmbbxProd.SelectedIndex = -1;
            txtbxQuantity.Value = 0;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            bool flag = true;
            lblProdErr.Text = "";
            lblQuantityErr.Text = "";

            if (cmbbxProd.SelectedIndex == -1)
            {
                lblProdErr.Text = "Select a Product!";
                lblProdErr.ForeColor = Color.Red;
                flag = false;
            }

            if (txtbxQuantity.Value.ToString() == "0")
            {
                lblQuantityErr.Text = "Quantity must be between 1-250";
                lblQuantityErr.ForeColor = Color.Red;
                flag = false;
            }

            if (flag && (Mode == "Adding" || Mode == "Editing"))
            {
                int index = ProdAlreadyPresent(cmbbxProd.Text);
                if (index == -1) //Product not already added.
                {
                    DatGVOrderProducts.Rows.Add(cmbbxProd.Text, txtbxQuantity.Value);
                    ClearProdFields();
                    OrderChange = true;
                }
                else
                {
                    string message = "Product Already Added!!\nYes to Consolidte and No to Overwrite";
                    string title = "Prompt Window";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DatGVOrderProducts.Rows[index].Cells["Quantity"].Value = ( int.Parse(DatGVOrderProducts.Rows[index].Cells["Quantity"].Value.ToString()) + int.Parse(txtbxQuantity.Value.ToString())).ToString();
                        ClearProdFields();
                        OrderChange = true;
                    }
                    else if (result == DialogResult.No)
                    {
                        DatGVOrderProducts.Rows[index].Cells["Quantity"].Value = txtbxQuantity.Value.ToString();
                        ClearProdFields();
                        OrderChange = true;
                    }
                }
            }
        }

        private void DatGVOrderProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (DatGVOrderProducts.Columns[e.ColumnIndex].Name == "Update")
            {
                ChangeSecondaryMode("Updating");
                cmbbxProd.SelectedIndex= cmbbxProd.Items.IndexOf(DatGVOrderProducts.Rows[e.RowIndex].Cells["ProdName"].Value);
                if (SearchChange2) ClearProdSrch();
            }

            if (DatGVOrderProducts.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (SecondMode == "Inserting" || Mode == "Adding")
                {
                    OrderChange = true;

                    string message = "Remove Product from Order Line?";
                    string title = "Prompt Window";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DatGVOrderProducts.Rows.RemoveAt(e.RowIndex);
                    }

                    if (SearchChange2) ClearProdSrch();
                }
                else
                    MessageBox.Show("Current Process: Updating Products\nClick on Clear or Edit to end current Process.", "Error!!");
            }
        }

        private void DatGVOrderProducts_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (DatGVOrderProducts.Columns[e.ColumnIndex].Name == "Update")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawImage(Properties.Resources.edit, e.CellBounds);
                e.Handled = true;
            }

            if (DatGVOrderProducts.Columns[e.ColumnIndex].Name == "Delete")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawImage(Properties.Resources.delete, e.CellBounds);
                e.Handled = true;
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            if (Mode == "Viewing")
            {
                ChangeMode("Normal");
                //btnClr.Enabled = false;
            }
            else if (Mode == "Adding" || Mode == "Editing")
                DatGVOrderProducts.Rows.Clear();
        }

        private void ClearProdSrch()
        {
            txtbxProdSeatch.Text = "";
            foreach (DataGridViewRow row in DatGVOrderProducts.Rows)
            {
                row.Visible = true;
            }
            SearchChange2 = false;
        }

        private void txtbxProdSeatch_TextChanged(object sender, EventArgs e)
        {
            if (txtbxProdSeatch.Text != "")
            {
                SearchChange2 = true;
                foreach (DataGridViewRow row in DatGVOrderProducts.Rows)
                {
                    bool flag = false;
                    for (int i = 0; i < 2; i++)
                    {
                        if (row.Cells[i].Value.ToString().ToUpper().Contains(txtbxProdSeatch.Text.ToUpper()))
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
                ClearProdSrch();
            }
        }

        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtbxSearch.Text != "")
            {
                SearchChange1 = true;
                foreach (DataGridViewRow row in DatGVDayOrder.Rows)
                {
                    bool flag = false;
                    for (int i=0; i < 4; i++)
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
                FillTableOrders(CurrOrders);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            if (btnClear.Text == "CLEAR")
            {
                txtbxQuantity.Value = 0;
                if (cmbbxProd.Enabled) cmbbxProd.SelectedIndex = -1;
            }

            else
            {
                ChangeSecondaryMode("Inserting");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lblQuantityErr.Text = "";
            if (txtbxQuantity.Value == 0)
            {
                lblQuantityErr.Text = "Quantity must be between 1-250";
                lblQuantityErr.ForeColor = Color.Red;
            }

            else
            {
                DatGVOrderProducts.Rows[ProdAlreadyPresent(cmbbxProd.Text)].Cells["Quantity"].Value = txtbxQuantity.Value;
                ChangeSecondaryMode("Inserting");
                OrderChange = true;
            }
        }
    }
}
