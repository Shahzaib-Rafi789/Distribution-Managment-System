using Distribution_Managment_System.BL;
using Distribution_Managment_System.Data_Logic;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Distribution_Managment_System
{
    public partial class ShopkeeperWindow : Form
    {
        System.Data.DataTable shop_table = new System.Data.DataTable("Shop_table");
        int idx;
        Bitmap print;
        Shop vendor;

        public ShopkeeperWindow()
        {
            InitializeComponent();
        }

        private void phone_num_lbl_Click(object sender, EventArgs e)
        {

        }

        private void shop_id_txtbox_Enter(object sender, EventArgs e)
        {
            if (shop_id_txtbox.Text == "ID")
            {
                shop_id_txtbox.Text = "";
            }
            shop_id_txtbox.ForeColor = Color.Black;
        }

        private void shop_name_txtbox_Enter(object sender, EventArgs e)
        {
            if (shop_name_txtbox.Text == "Name")
            {
                shop_name_txtbox.Text = "";
            }
            shop_name_txtbox.ForeColor = Color.Black;

        }

        private void shop_landline_txtbox_Enter(object sender, EventArgs e)
        {
            if (shop_landline_txtbox.Text == "Land-Line")
            {
                shop_landline_txtbox.Text = "";
            }
            shop_landline_txtbox.ForeColor = Color.Black;
        }

        private void shop_address_txtbox_Enter(object sender, EventArgs e)
        {
            if (shop_address_txtbox.Text == "Address")
            {
                shop_address_txtbox.Text = "";
            }
            shop_address_txtbox.ForeColor = Color.Black;
        }

        private void shopkeeper_name_Enter(object sender, EventArgs e)
        {
            if (shopkeeper_name.Text == "Name")
            {
                shopkeeper_name.Text = "";
            }
            shopkeeper_name.ForeColor = Color.Black;
        }

        private void shopkeeper_email_Enter(object sender, EventArgs e)
        {
            if (shopkeeper_email.Text == "Email")
            {
                shopkeeper_email.Text = "";
            }
            shopkeeper_email.ForeColor = Color.Black;
        }

        private void shopkeeper_email_MouseEnter(object sender, EventArgs e)
        {

        }

        private void shop_phone_Enter(object sender, EventArgs e)
        {
            if (shop_phone.Text == "Phone #")
            {
                shop_phone.Text = "";
            }
            shop_phone.ForeColor = Color.Black;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            shopkeeper_name.Clear();
            shop_phone.Clear();
            shopkeeper_email.Clear();
            shop_id_txtbox.Clear();
            shop_name_txtbox.Clear();
            shop_region_combox.SelectedIndex = -1;
            shop_landline_txtbox.Clear();
            shop_address_txtbox.Clear();

            shop_id_indicator_lblr.ForeColor = Color.White;
            shop_name_indicator_lblr.ForeColor = Color.White;
            shop_region_indicator_lblr.ForeColor = Color.White;
            shop_landline_indicator_lblr.ForeColor = Color.White;
            shop_address_indicator_lblr.ForeColor = Color.White;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "SEARCH")
            {
                textBox4.Text = "";
            }
            textBox4.ForeColor = Color.Black;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (shop_id_txtbox.Text == string.Empty || shop_name_txtbox.Text == string.Empty || shop_region_combox.Text == string.Empty || shop_landline_txtbox.Text == string.Empty || shop_address_txtbox.Text == string.Empty)
                {
                    shop_id_indicator_lblr.Text = "Invalid Input";
                    shop_name_indicator_lblr.Text = "Invalid Input";
                    shop_region_indicator_lblr.Text = "Invalid Input";
                    shop_landline_indicator_lblr.Text = "Invalid Input";
                    shop_address_indicator_lblr.Text = "Invalid Input";

                    shop_id_indicator_lblr.ForeColor = Color.Red;
                    shop_name_indicator_lblr.ForeColor = Color.Red;
                    shop_region_indicator_lblr.ForeColor = Color.Red;
                    shop_landline_indicator_lblr.ForeColor = Color.Red;
                    shop_address_indicator_lblr.ForeColor = Color.Red;


                }
                else if (shop_landline_txtbox.TextLength != 12 || double.Parse(shop_landline_txtbox.Text) < 0 || double.Parse(shop_landline_txtbox.Text) == 0)
                {
                    shop_landline_indicator_lblr.Text = "Invalid Land line Number Format";
                    shop_landline_indicator_lblr.ForeColor = Color.Red;
                }
                /*else if(shop_address_txtbox.Text!=string.Empty)
                {
                    bool addressfound = false;
                    shop_datagrid.ClearSelection();
                    foreach (DataGridViewRow row in shop_datagrid.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value.ToString().Contains(shop_address_txtbox.Text))
                            {
                                row.Selected = true;
                                addressfound = true;
                            }
                        }
                    }
                    if (addressfound)
                    {
                        shop_address_indicator_lbl.ForeColor = Color.Red;
                        shop_address_indicator_lbl.Text ="Address must be unique";
                    }
                }*/
                else
                {
                    vendor = new Shop(shop_id_txtbox.Text, shop_name_txtbox.Text, shop_region_combox.Text, shop_landline_txtbox.Text, shop_address_txtbox.Text);
                    Shops_CRUD.Add(vendor);
                    MessageBox.Show("Shop Added");
                    shop_table.Rows.Add(shop_id_txtbox.Text, shop_name_txtbox.Text, shop_region_combox.Text, shop_landline_txtbox.Text, shop_address_txtbox.Text);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Name must only contain letters", err.Message);
                shop_name_indicator_lblr.Text = "Invalid Input";
                shop_name_indicator_lblr.ForeColor = Color.Red;
            }
            /*address validation
                
                    */
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void ShopkeeperWindow_Load(object sender, EventArgs e)
        {
            /*shop_table.Columns.Add("Shop ID");
            shop_table.Columns.Add("Shop Name");
            shop_table.Columns.Add("Shop Region");
            shop_table.Columns.Add("Shop Landline");
            shop_table.Columns.Add("Shop Address");
            shop_datagrid.DataSource = shop_table;*/

            try
            {
                loadshopkeeper();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (shop_id_txtbox.Text == string.Empty || shop_name_txtbox.Text == string.Empty || shop_region_combox.Text == string.Empty || shop_landline_txtbox.Text == string.Empty || shop_address_txtbox.Text == string.Empty)
                {
                    shop_id_indicator_lblr.Text = "Invalid Input";
                    shop_name_indicator_lblr.Text = "Invalid Input";
                    shop_region_indicator_lblr.Text = "Invalid Input";
                    shop_landline_indicator_lblr.Text = "Invalid Input";
                    shop_address_indicator_lblr.Text = "Invalid Input";

                    shop_id_indicator_lblr.ForeColor = Color.Red;
                    shop_name_indicator_lblr.ForeColor = Color.Red;
                    shop_region_indicator_lblr.ForeColor = Color.Red;
                    shop_landline_indicator_lblr.ForeColor = Color.Red;
                    shop_address_indicator_lblr.ForeColor = Color.Red;


                }
                else if (shop_landline_txtbox.TextLength != 12 || double.Parse(shop_landline_txtbox.Text) < 0 || double.Parse(shop_landline_txtbox.Text) == 0)
                {
                    shop_landline_indicator_lblr.Text = "Invalid Land line Number Format";
                    shop_landline_indicator_lblr.ForeColor = Color.Red;
                }
                //address validation
                else
                {
                    DataGridViewRow newitem = shop_datagrid.Rows[idx];
                    newitem.Cells[0].Value = shop_id_txtbox.Text;
                    newitem.Cells[1].Value = shop_name_txtbox.Text;
                    newitem.Cells[2].Value = shop_region_combox.Text;
                    newitem.Cells[3].Value = shop_landline_txtbox.Text;
                    newitem.Cells[4].Value = shop_address_txtbox.Text;
                    Shop updatedshop = new Shop(shop_id_txtbox.Text, shop_name_txtbox.Text, shop_region_combox.Text, shop_landline_txtbox.Text, shop_address_txtbox.Text);
                    Shops_CRUD.Update(vendor, updatedshop);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Name must only contain letters", err.Message);
                shop_name_indicator_lblr.Text = "Invalid Input";
                shop_name_indicator_lblr.ForeColor = Color.Red;
            }
        }

        private void shop_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void shop_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idx = e.RowIndex;
                DataGridViewRow row = shop_datagrid.Rows[idx];
                shop_id_txtbox.Text = row.Cells[0].Value.ToString();
                shop_name_txtbox.Text = row.Cells[1].Value.ToString();
                shop_region_combox.Text = row.Cells[2].Value.ToString();
                shop_landline_txtbox.Text = row.Cells[3].Value.ToString();
                shop_address_txtbox.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("No row selected yet", err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                delshop();
            }
            catch (Exception err)
            {
                MessageBox.Show("Unable to delete an empty row", err.Message);
            }
        }

        private void delshop()
        {
            bool deleted = Shops_CRUD.Delete(shop_id_txtbox.Text);
            if (deleted)
            {
                MessageBox.Show("Shop Deleted");
            }
            foreach (DataGridViewRow item in this.shop_datagrid.SelectedRows)
            {
                shop_datagrid.Rows.RemoveAt(item.Index);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                saveshop();
            }
            catch (Exception err)
            {
                MessageBox.Show("Something went wrong", err.Message);
            }
        }

        private void saveshop()
        {
            if (shop_datagrid.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Not possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = shop_datagrid.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[shop_datagrid.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += shop_datagrid.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < shop_datagrid.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += shop_datagrid.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Saved Successfully", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Something went wrong :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export", "Info");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (shop_datagrid.Rows.Count > 0)
                {
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "PDF (*.pdf)|*.pdf";
                    save.FileName = "Result.pdf";
                    bool ErrorMessage = false;

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(save.FileName))
                        {
                            try
                            {
                                File.Delete(save.FileName);
                            }
                            catch (Exception ex)
                            {
                                ErrorMessage = true;
                                MessageBox.Show("Unable to write data in disk" + ex.Message);
                            }
                        }

                        if (!ErrorMessage)
                        {
                            try
                            {
                                PdfPTable pTable = new PdfPTable(shop_datagrid.Columns.Count);
                                pTable.DefaultCell.Padding = 2;
                                pTable.WidthPercentage = 100;
                                pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                                foreach (DataGridViewColumn col in shop_datagrid.Columns)
                                {
                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                    pTable.AddCell(pCell);
                                }

                                foreach (DataGridViewRow viewRow in shop_datagrid.Rows)
                                {
                                    foreach (DataGridViewCell dcell in viewRow.Cells)
                                    {
                                        pTable.AddCell(dcell.Value.ToString());
                                    }
                                }

                                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                                {
                                    Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                    PdfWriter.GetInstance(document, fileStream);

                                    document.Open();
                                    document.Add(pTable);
                                    document.Close();
                                    fileStream.Close();
                                }
                                MessageBox.Show("Data Export Successfully", "info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error while exporting Data" + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Record Found", "Info");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Something went wrong", err.Message);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string searchtxt = textBox4.Text;
                if (string.IsNullOrEmpty(searchtxt))
                {
                    MessageBox.Show("Nothing to Search");

                }
                else
                {
                    searchdgv(searchtxt);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Something went wrong", err.Message);
            }
        }

        private void searchdgv(string searchtxt)
        {
            bool found = false;
            shop_datagrid.ClearSelection();
            foreach (DataGridViewRow row in shop_datagrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString().Contains(searchtxt))
                    {
                        row.Selected = true;
                        found = true;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("Item not found");
            }

        }

        private void loadshopkeeper()
        {
            string[] text = System.IO.File.ReadAllLines("E:\\Semester 3\\final\\Distribution Managment System\\shopkeepers.csv");
            string[] datacol = null;
            int x = 0;

            foreach (string text_line in text)
            {
                datacol = text_line.Split(',');
                if (x == 0)
                {
                    for (int i = 0; i <= datacol.Count() - 1; i++)
                    {
                        shop_table.Columns.Add(datacol[i]);
                    }
                    x++;
                }
                else
                {
                    shop_table.Rows.Add(datacol);
                }
            }
            shop_table.Columns.Remove("Column1");
            shop_datagrid.DataSource = shop_table;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void shop_landline_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void region_lbl_Click(object sender, EventArgs e)
        {

        }

        private void shop_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void shop_address_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_num_lbl_Click_1(object sender, EventArgs e)
        {

        }

        private void shop_region_combox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vehicle_id_lbl_Click(object sender, EventArgs e)
        {

        }

        private void shop_name_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rider_name_lbl_Click(object sender, EventArgs e)
        {

        }

        private void shop_id_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rider_id_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void vehicle_id_combox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void shopkeeper_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void shopkeeper_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void shop_id_indicator_lblr_Click(object sender, EventArgs e)
        {

        }

        private void shop_name_indicator_lblr_Click(object sender, EventArgs e)
        {

        }

        private void shop_region_indicator_lblr_Click(object sender, EventArgs e)
        {

        }

        private void shop_landline_indicator_lblr_Click(object sender, EventArgs e)
        {

        }

        private void shop_address_indicator_lblr_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void shop_datagrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
