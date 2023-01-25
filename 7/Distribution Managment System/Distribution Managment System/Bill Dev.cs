using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Distribution_Managment_System.Data_Logic;
using Distribution_Managment_System.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribution_Managment_System
{
    public partial class Form2 : XtraForm
    {
        public Form2(Order currentOrder,string ShopName)
        {
            InitializeComponent();

            gridControl.DataSource = currentOrder.OrderLineList;
            lblDate.Text = currentOrder.Date.ToString();
            lblShop.Text = currentOrder.OrderId+ "\""+ShopName;
            lblOrderNo.Text = currentOrder.OrderId;
            lblDate.AppearanceItemCaption.Font=new Font("Century Gothic", 9);
            lblShop.AppearanceItemCaption.Font=new Font("Century Gothic", 9);
            lblOrderNo.AppearanceItemCaption.Font = new Font("Century Gothic", 9);
            SetGridFont(this.gridView, new Font("TeXGyreAdventor", 9));
        }

        void SetGridFont(GridView view, Font font)
        {
            foreach (AppearanceObject ap in view.Appearance)
            {
                ap.Font = font;
            }

            if (view.FormatConditions.Count > 0)
            {
                for (int i = 0; i < view.FormatConditions.Count; i++)
                {
                    view.FormatConditions[i].Appearance.Font = new Font(font.FontFamily, font.Size, view.FormatConditions[i].Appearance.Font.Style);
                }
            }
        }
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Print") gridControl.PrintDialog();
        }
       
        private void labelControl_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
