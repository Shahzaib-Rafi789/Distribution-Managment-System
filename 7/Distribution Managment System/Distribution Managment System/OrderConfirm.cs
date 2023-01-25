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
    

    public partial class OrderConfirm : Form
    {
        List<Order> Orders= new List<Order>();
        List<Prod> Stock = new List<Prod>();
        List<OrderLine> OrderLines = new List<OrderLine>();
        List<int> status = new List<int>();

        public OrderConfirm()
        {
            InitializeComponent();
        }

        private void createAvailList()
        {
            List<Product> Prods = Products_CRUD.AllProducts();
            foreach  (Product p in Prods)
            {
                Stock.Add(new Prod(p.ProductID, p.ProductName, p.Quantity));
            }
        }

        private void ChangeStatus(int n)
        {
            if (n == 0) lblMode.Text = "None(No Order Found To Confirm)";
            else if (n == 1) lblMode.Text = "Fetching Orders";
            else if (n == 2) lblMode.Text = "Displaying Orders.....";
            else if (n == 3) lblMode.Text = "Setting Orders States.....";
            else if (n == 4) lblMode.Text = "Done!!";
        }

        private bool TakeQuantities(OrderLine line)
        {
            foreach (Prod prod in Stock)
            {
                if (prod.ProductName == line.ProductName)
                {
                    if (prod.Available >= line.QuantityDemand)
                    {
                        prod.Available -= line.QuantityDemand;
                        line.QuantityGiven = line.QuantityDemand;
                        line.Status = true;
                        return true;
                    }
                    else
                    {
                        line.QuantityGiven = prod.Available;
                        prod.Available = 0;
                        line.Status = false;
                        return false; 
                    }
                }
            }

            line.QuantityGiven = 0;
            return false;
        }

        private void ConfirmOrdersWindow_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void Reload()
        {
            ChangeStatus(1);
            Orders = CRUD_Orders.GetOrders();

            if (Orders == null || Orders.Count == 0)
            {
                ChangeStatus(0);
            }
            else
            {
                ChangeStatus(2);
                FillOrderTable();
                createAvailList();

                ChangeStatus(3);
                SetAllStatus();
                UpdateTable();

                ChangeStatus(4);
            }
        }

        private void UpdateTable()
        {
            int count = 0;
            foreach (int val in status)
            {
                if (val == 2) DatGVOrder.Rows[count].Cells["OrdStatus"].Value = Properties.Resources.green;
                else if (val == 1) DatGVOrder.Rows[count].Cells["OrdStatus"].Value = Properties.Resources.yellow;
                else DatGVOrder.Rows[count].Cells["OrdStatus"].Value = Properties.Resources.red;
            }
        }

        private void SetAllStatus()
        {
            status = new List<int>();
            foreach (Order order in Orders)
            {
                status.Add(SetStatus(order));
            }
        }

        private int SetStatus(Order order)
        {
            int flag = 0;
            foreach (OrderLine line in order.GetOrderLineList())
            {
                if (TakeQuantities(line))
                    flag += 1;
            }

            if (flag == 0)
                return 0;
            else if (flag < order.OrderLineList.Count)
                return 1;
            return 2;
        }

        private void FillOrderTable()
        {
            DatGVOrder.Rows.Clear();
            foreach (Order order in Orders)
            {
                if (order.Order_Status != OrderStatus.Canceled.ToString())
                    DatGVOrder.Rows.Add("", order.OrderId, Shops_CRUD.GetShopInfo(order.ShopId));
            }
        }

        private void FillOrderLineTable(List<OrderLine> lst)
        {
            OrderLines = lst;
            DatGVProduct.Rows.Clear();
            foreach (OrderLine orderLine in OrderLines)
                DatGVProduct.Rows.Add(orderLine.ProductName, orderLine.QuantityDemand, orderLine.QuantityGiven);
        }

        private Order RetrieveOrder(string id)
        {
            foreach (Order o in Orders)
                if (o.OrderId == id)
                    return o;

            return null;
        }

        private int GetIndexById(string id)
        {
            int count = -1;
            foreach (Order order in Orders)
            {
                count++;
                if (order.OrderId == id)
                    return count;
            }

            return -1;
        }

        private void DatGVOrder_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            //if (DatGVOrder.Columns[e.ColumnIndex].Name == "Undo")
            //{
            //    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            //    e.Graphics.DrawImage(Properties.Resources.undo, e.CellBounds);
            //    e.Handled = true;
            //}

            if (DatGVOrder.Columns[e.ColumnIndex].Name == "Cancel")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawImage(Properties.Resources.cancel, e.CellBounds);
                e.Handled = true;
            }

            if (DatGVOrder.Columns[e.ColumnIndex].Name == "View")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawImage(Properties.Resources.detail, e.CellBounds);
                e.Handled = true;
            }

            if (DatGVOrder.Columns[e.ColumnIndex].Name == "OrdSTATUS")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawImage(Properties.Resources.green, e.CellBounds);
                e.Handled = true;
            }
        }

        private void DatGVOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (DatGVOrder.Columns[e.ColumnIndex].Name == "Cancel")
            {
                int index = GetIndexById(DatGVOrder.Rows[e.RowIndex].Cells["OrderId"].Value.ToString());
                if (index != -1) Orders[index].ChangeStatusCancel();
                DatGVOrder.Rows.RemoveAt(e.RowIndex);
                FillOrderTable();
            }

            if (DatGVOrder.Columns[e.ColumnIndex].Name == "View")
            {
                string id = DatGVOrder.Rows[e.RowIndex].Cells["View"].Value.ToString();
                OrderLines = CRUD_Orders.RetrieveOrder(id).GetOrderLineList();
                //FillOrderLineTable();
            }
        }
    }

    internal class Prod
    {
        string productId, productName;
        int available, total;

        public Prod(string productId, string productName, int available)
        {
            ProductId = productId;
            ProductName = productName;
            Available = available;
            Total = available;
        }

        public string ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int Available { get => available; set => available = value; }
        public int Total { get => total; set => total = value; }

        public bool HasQuan(int Quantity)
        {
            return Quantity >= Available;
        }
    }
}
