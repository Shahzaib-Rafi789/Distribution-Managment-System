using DevExpress.Utils.Extensions;
using DevExpress.XtraRichEdit.Model;
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
using System.Xml.Linq;

namespace Distribution_Managment_System
{
    public partial class ViewBill : Form
    {
        public ViewBill()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitt_Click(object sender, EventArgs e)
        {
            gvProducts.DataSource = CRUD_Orders.ordersInADurationbyShop(datPStart.Value, datPEnd.Value, cmbShop.SelectedValue.ToString().Split(':')[0]);

        }



        public void GridColor()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "VIEW";
            buttonColumn.Text = "VIEW";
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.FlatStyle= FlatStyle.System;
            gvProducts.Columns.Add(buttonColumn);
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
        public void DataBind(List<Order> allOrder)
        {
            gvProducts.DataSource = null;
            gvProducts.Rows.Clear();

            gvProducts.DataSource = allOrder;
            gvProducts.Refresh();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = Shops_CRUD.getShopsWithID();
            this.cmbShop.DataSource = bindingSource1;
            /*foreach (var a in Source)
            {
                this.cmbShop.Items.Add(a);
            }*/
            
            DataBind(CRUD_Orders.GetOrderList());
            datPStart.CalendarFont = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            GridColor();

            Graphics g = btnSubmitt.CreateGraphics();
            float w = g.MeasureString(btnSubmitt.Text, btnSubmitt.Font).Width;
            float h = g.MeasureString(btnSubmitt.Text, btnSubmitt.Font).Height;
            g.Dispose();
            btnSubmitt.Width = (int)w + 24;
            btnSubmitt.Height= (int)h + 24;
            btnClear.Width = (int)w + 24;
            btnClear.Height = (int)h + 24;

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.Width<621)
            {
                tbLayControls.ColumnStyles[3].SizeType = SizeType.Absolute;
                tbLayControls.ColumnStyles[3].Width = 0;
                tbLayControls.ColumnStyles[0].SizeType = SizeType.Absolute;
                tbLayControls.ColumnStyles[0].Width = 0;
                tbLayControls.RowStyles[3].SizeType = SizeType.Absolute;
                tbLayControls.RowStyles[3].Height = pnlButtons.Height;
            }
            else
            {
                tbLayControls.ColumnStyles[3].SizeType = SizeType.Percent;
                tbLayControls.ColumnStyles[3].Width = 12.96f;
                tbLayControls.ColumnStyles[0].SizeType = SizeType.Percent;
                tbLayControls.ColumnStyles[0].Width = 12.96f;
                tbLayControls.RowStyles[3].SizeType = SizeType.Percent;
                tbLayControls.RowStyles[3].Height = 25;
            }
        }

        private void gvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Order record = (Order)gvProducts.CurrentRow.DataBoundItem;
            if (gvProducts.Columns["VIEW"].Index == e.ColumnIndex)
            {
                Form2 childForm = new Form2(record,Shops_CRUD.getNamebyID(record.ShopId));
                childForm.ShowDialog(this);

            }

        }
    }
}
