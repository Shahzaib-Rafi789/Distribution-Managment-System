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
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Distribution_Managment_System
{
    public partial class RiderWindow : Form
    {
        DataTable rider_table = new DataTable("Rider_table");
        int totalvehicles,totalriders = 0;
        int idx;
        Bitmap print;
        Rider driver;


        public RiderWindow()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RiderWindow_Load(object sender, EventArgs e)
        {
            /*rider_table.Columns.Add("RIDER ID");
            rider_table.Columns.Add("NAME");
            rider_table.Columns.Add("VEHICLE ID");
            rider_table.Columns.Add("REGION");
            rider_table.Columns.Add("PHONE NUMBER");
            rider_datagrid.DataSource = rider_table;*/
            try
            {
                loadrider();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Something went wrong", ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rider_id_txtbox.Text == string.Empty || rider_name_txtbox.Text == string.Empty || vehicle_id_combox.Text == string.Empty || region_combox.Text == string.Empty || rider_number_txtbox.Text == string.Empty)
                {
                    rider_id_indicator_lblr.Text = "Invalid Input";
                    rider_id_indicator_lblr.ForeColor = Color.Red;
                    rider_name_indicator_lblr.Text = "Invalid Input";
                    rider_name_indicator_lblr.ForeColor = Color.Red;
                    rider_number_indicator_lblr.Text = "Invalid Input";
                    rider_number_indicator_lblr.ForeColor = Color.Red;
                }
                else if (rider_number_txtbox.TextLength != 12 || double.Parse(rider_number_txtbox.Text) < 0 || double.Parse(rider_number_txtbox.Text) == 0)
                {
                    rider_number_indicator_lblr.Text = "Invalid Phone Number Format";
                    rider_number_indicator_lblr.ForeColor = Color.Red;
                }
                else
                {
                    driver = new Rider(rider_id_txtbox.Text, rider_name_txtbox.Text, vehicle_id_combox.Text, region_combox.Text, double.Parse(rider_number_txtbox.Text));
                    Riders_CRUD.Add(driver);
                    MessageBox.Show("Rider Added");
                    totalriders += 1;
                    //total_rider_count_lbl.Text = totalriders;
                    rider_table.Rows.Add(rider_id_txtbox.Text, rider_name_txtbox.Text, vehicle_id_combox.Text, region_combox.Text, double.Parse(rider_number_txtbox.Text));
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No numbers in Name", err.Message);
                rider_name_indicator_lblr.Text = "Invalid Input";
                rider_name_indicator_lblr.ForeColor = Color.Red;
            }
        }

        private void rider_number_txtbox_Enter(object sender, EventArgs e)
        {
            if (rider_number_txtbox.Text == "NUMBER")
            {
                rider_number_txtbox.Text = "";
            }
            rider_number_txtbox.ForeColor = Color.Black;
        }

        private void rider_name_txtbox_Enter(object sender, EventArgs e)
        {
            if (rider_name_txtbox.Text == "NAME")
            {
                rider_name_txtbox.Text = "";
            }
            rider_name_txtbox.ForeColor = Color.Black;
        }

        private void rider_id_txtbox_Enter(object sender, EventArgs e)
        {
            if (rider_id_txtbox.Text == "ID")
            {
                rider_id_txtbox.Text = "";
            }
            rider_id_txtbox.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rider_id_txtbox.Clear();
            rider_number_txtbox.Clear();
            vehicle_id_combox.SelectedIndex = -1;
            region_combox.SelectedIndex = -1;
            rider_name_txtbox.Clear();

            rider_id_indicator_lblr.Text = "";
            rider_id_indicator_lblr.ForeColor = Color.White;
            rider_name_indicator_lblr.Text = "";
            rider_name_indicator_lblr.ForeColor = Color.White;
            rider_number_indicator_lblr.Text = "";
            rider_number_indicator_lblr.ForeColor = Color.White;

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "SEARCH")
            {
                textBox5.Text = "";
            }
            textBox5.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                del();
            }
            catch (Exception err)
            {
                MessageBox.Show("Unable to delete an empty row", err.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (rider_datagrid.Rows.Count > 0)
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
                                PdfPTable pTable = new PdfPTable(rider_datagrid.Columns.Count);
                                pTable.DefaultCell.Padding = 2;
                                pTable.WidthPercentage = 100;
                                pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                                foreach (DataGridViewColumn col in rider_datagrid.Columns)
                                {
                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                    pTable.AddCell(pCell);
                                }

                                foreach (DataGridViewRow viewRow in rider_datagrid.Rows)
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                save();
            }
            catch (Exception err)
            {
                MessageBox.Show("Something went wrong", err.Message);
            }
        }


        private void save()
        {
            if (rider_datagrid.Rows.Count > 0)
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
                            int columnCount = rider_datagrid.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[rider_datagrid.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += rider_datagrid.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < rider_datagrid.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += rider_datagrid.Rows[i - 1].Cells[j].Value.ToString() + ",";
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

        private void rider_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idx = e.RowIndex;
                DataGridViewRow row = rider_datagrid.Rows[idx];
                rider_id_txtbox.Text = row.Cells[0].Value.ToString();
                rider_name_txtbox.Text = row.Cells[1].Value.ToString();
                vehicle_id_combox.Text = row.Cells[2].Value.ToString();
                region_combox.Text = row.Cells[3].Value.ToString();
                rider_number_txtbox.Text = row.Cells[4].Value.ToString();
            }
            catch(Exception err)
            {
                MessageBox.Show("No row selected yet", err.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (rider_id_txtbox.Text == string.Empty || rider_name_txtbox.Text == string.Empty || rider_number_txtbox.Text == string.Empty)
                {
                    rider_id_indicator_lblr.Text = "Invalid Input";
                    rider_id_indicator_lblr.ForeColor = Color.Red;
                    rider_name_indicator_lblr.Text = "Invalid Input";
                    rider_name_indicator_lblr.ForeColor = Color.Red;
                    rider_number_indicator_lblr.Text = "Invalid Input";
                    rider_number_indicator_lblr.ForeColor = Color.Red;
                }
                else if (rider_number_txtbox.TextLength != 12 || double.Parse(rider_number_txtbox.Text) < 0 || double.Parse(rider_number_txtbox.Text) == 0)
                {
                    rider_number_indicator_lblr.Text = "Invalid Phone Number Format";
                    rider_number_indicator_lblr.ForeColor = Color.Red;
                }
                else
                {
                    DataGridViewRow newitem = rider_datagrid.Rows[idx];
                    newitem.Cells[0].Value = rider_id_txtbox.Text;
                    newitem.Cells[1].Value = rider_name_txtbox.Text;
                    newitem.Cells[2].Value = vehicle_id_combox.Text;
                    newitem.Cells[3].Value = region_combox.Text;
                    newitem.Cells[4].Value = rider_number_txtbox.Text;
                    Rider updatedrider = new Rider(rider_id_txtbox.Text, rider_name_txtbox.Text, vehicle_id_combox.Text, region_combox.Text, double.Parse(rider_number_txtbox.Text));
                    Riders_CRUD.Update(driver, updatedrider);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Something went wrong", err.Message);
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            try
            {
                string searchtxt = textBox5.Text;
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
            rider_datagrid.ClearSelection();
            foreach (DataGridViewRow row in rider_datagrid.Rows)
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

        private void loadrider()
        {

                string[] text = System.IO.File.ReadAllLines("E:\\Semester 3\\final\\Distribution Managment System\\riders.csv");
                string[] datacol = null;
                int x = 0;

                foreach (string text_line in text)
                {
                    datacol = text_line.Split(',');
                    if (x == 0)
                    {
                        for (int i = 0; i <= datacol.Count() - 1; i++)
                        {
                            rider_table.Columns.Add(datacol[i]);
                        }
                        x++;
                    }
                    else
                    {
                        rider_table.Rows.Add(datacol);
                    }
                }
                rider_table.Columns.Remove("Column1");
                rider_datagrid.DataSource = rider_table;
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void del()
        {
                totalriders -= 1;
                bool deleted = Riders_CRUD.Delete(rider_id_txtbox.Text);
                if (deleted)
                {
                MessageBox.Show("Rider Deleted");
                }


            foreach (DataGridViewRow item in this.rider_datagrid.SelectedRows)
                {
                    rider_datagrid.Rows.RemoveAt(item.Index);
                }
    

        }

    }
}
