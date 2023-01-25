using Distribution_Managment_System.BL;
using Distribution_Managment_System.Data_Logic;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using Rectangle = System.Drawing.Rectangle;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using CsvHelper;
using Org.BouncyCastle.Ocsp;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Distribution_Managment_System
{
    public partial class VehicleWindow : Form
    {
        System.Data.DataTable vehicle_table = new System.Data.DataTable("Vehicle_table");
        int idx;
        Bitmap print;
        Vehicle automobile;
        bool addedvehicle = false;
        public VehicleWindow()
        {
            InitializeComponent();
        }

        private void rider_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VehicleWindow_Load(object sender, EventArgs e)
        {

            /*vehicle_table.Columns.Add("Vehicle #");
            vehicle_table.Columns.Add("Chassis #");
            vehicle_table.Columns.Add("Vehicle Type");
            vehicle_table.Columns.Add("Assigned or not");
            vehicle_table.Columns.Add("Fuel Capacity");
            vehicle_table.Columns.Add("Colour");
            vehicle_datagrid.DataSource = vehicle_table;*/

            try
            {
                vehicleload();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void vehicle_id_txtbox_Enter(object sender, EventArgs e)
        {
            if (vehicle_id_txtbox.Text == "ID")
            {
                vehicle_id_txtbox.Text = "";
            }
            vehicle_id_txtbox.ForeColor = Color.Black;
        }

        private void chassis_name_txtbox_Enter(object sender, EventArgs e)
        {
            if (chassis_name_txtbox.Text == "Chassis")
            {
                chassis_name_txtbox.Text = "";
            }
            chassis_name_txtbox.ForeColor = Color.Black;
        }

        private void color_txtbox_Enter(object sender, EventArgs e)
        {
            if (color_txtbox.Text == "Colour")
            {
                color_txtbox.Text = "";
            }
            color_txtbox.ForeColor = Color.Black;

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {


        }

        private void textBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // textBox1.Clear();
            chassis_refuel.Clear();
            vehicle_id_refuel.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                delvehicle();
            }
            catch (Exception err)
            {
                MessageBox.Show("Unable to delete an empty row", err.Message);
            }
        }

        private void delvehicle()
        {

            bool deleted = Vehicle_CRUD.Delete(vehicle_id_txtbox.Text);
            if (deleted)
            {
                MessageBox.Show("Vehicle Deleted");
            }

            foreach (DataGridViewRow item in this.vehicle_datagrid.SelectedRows)
            {
                vehicle_datagrid.Rows.RemoveAt(item.Index);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void vehicle_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idx = e.RowIndex;
                DataGridViewRow row = vehicle_datagrid.Rows[idx];
                vehicle_id_txtbox.Text = row.Cells[0].Value.ToString();
                vehicle_id_refuel.Text = row.Cells[0].Value.ToString();
                chassis_name_txtbox.Text = row.Cells[1].Value.ToString();
                chassis_refuel.Text = row.Cells[1].Value.ToString();
                vehicle_type_combox.Text = row.Cells[2].Value.ToString();
                vehicle_type_combox_refuel.Text = row.Cells[2].Value.ToString();
                capacity_txtbox.Text = row.Cells[4].Value.ToString();
                color_txtbox.Text = row.Cells[5].Value.ToString();

            }
            catch (Exception err)
            {
                MessageBox.Show("No row selected yet", err.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void savevehicle()
        {
            if (vehicle_datagrid.Rows.Count > 0)
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
                            int columnCount = vehicle_datagrid.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[vehicle_datagrid.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += vehicle_datagrid.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < vehicle_datagrid.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += vehicle_datagrid.Rows[i - 1].Cells[j].Value.ToString() + ",";
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

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void capacity_txtbox_Enter(object sender, EventArgs e)
        {
            if (capacity_txtbox.Text == "Capacity Range")
            {
                capacity_txtbox.Text = "";
            }
            capacity_txtbox.ForeColor = Color.Black;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {


        }

        private void searchdgv(string searchtxt)
        {
            bool found = false;
            vehicle_datagrid.ClearSelection();
            foreach (DataGridViewRow row in vehicle_datagrid.Rows)
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

        private void button8_Click_2(object sender, EventArgs e)
        {

        }

        private void vehicleload()
        {
            string[] text = System.IO.File.ReadAllLines("E:\\Semester 3\\final\\Distribution Managment System\\vehicles.csv");
            string[] datacol = null;
            int x = 0;

            foreach (string text_line in text)
            {
                datacol = text_line.Split(',');
                if (x == 0)
                {
                    for (int i = 0; i <= datacol.Count() - 1; i++)
                    {
                        vehicle_table.Columns.Add(datacol[i]);
                    }
                    x++;
                }
                else
                {
                    vehicle_table.Rows.Add(datacol);
                }
            }
            vehicle_table.Columns.Remove("Column1");
            vehicle_datagrid.DataSource = vehicle_table;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (vehicle_id_txtbox.Text == string.Empty || chassis_name_txtbox.Text == string.Empty || vehicle_type_combox.Text == string.Empty || capacity_txtbox.Text == string.Empty || color_txtbox.Text == string.Empty)
                {
                    vehicle_id_indicator_lblr.Text = "Invalid Input";
                    chassis_indicator_lblr.Text = "Invalid Input";
                    vehicle_type_indicator_lblr.Text = "Invalid Input";
                    fuel_capacity_indicator_lblr.Text = "Invalid Input";
                    color_indicator_lblr.Text = "Invalid Input";

                    vehicle_id_indicator_lblr.ForeColor = Color.Red;
                    chassis_indicator_lblr.ForeColor = Color.Red;
                    vehicle_type_indicator_lblr.ForeColor = Color.Red;
                    fuel_capacity_indicator_lblr.ForeColor = Color.Red;
                    color_indicator_lblr.ForeColor = Color.Red;
                }
                else if (chassis_name_txtbox.TextLength != 17 || double.Parse(chassis_name_txtbox.Text) < 0 || double.Parse(chassis_name_txtbox.Text) == 0)
                {
                    chassis_indicator_lblr.Text = "Invalid Chassis Number Format";
                    chassis_indicator_lblr.ForeColor = Color.Red;
                }
                else if (vehicle_id_txtbox.TextLength != 7) //plus other validation
                {
                    vehicle_id_indicator_lblr.Text = "Invalid Vehicle ID Format";
                    vehicle_id_indicator_lblr.ForeColor = Color.Red;
                }
                else if (float.Parse(capacity_txtbox.Text) <= 0) //plus other validation
                {
                    fuel_capacity_indicator_lblr.Text = "Invalid Vehicle Fuel Capacity Format";
                    fuel_capacity_indicator_lblr.ForeColor = Color.Red;
                }
                else
                {
                    automobile = new Vehicle(vehicle_id_txtbox.Text, chassis_name_txtbox.Text, vehicle_type_combox.Text, float.Parse(capacity_txtbox.Text), color_txtbox.Text);
                    Vehicle_CRUD.Add(automobile);
                    MessageBox.Show("Vehicle Added");
                    addedvehicle = true;
                    vehicle_table.Rows.Add(vehicle_id_txtbox.Text, chassis_name_txtbox.Text, vehicle_type_combox.Text, automobile.IsAssigned1, float.Parse(capacity_txtbox.Text), color_txtbox.Text);

                }
            }

            catch (Exception err)
            {
                MessageBox.Show("No numbers in Color", err.Message);
                color_indicator_lblr.Text = "Invalid Input";
                color_indicator_lblr.ForeColor = Color.Red;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            vehicle_id_txtbox.Clear();
            chassis_name_txtbox.Clear();
            vehicle_type_combox.SelectedIndex = -1;
            capacity_txtbox.Clear();
            color_txtbox.Clear();

            vehicle_id_indicator_lblr.Text = "";
            vehicle_id_indicator_lblr.ForeColor = Color.White;
            chassis_indicator_lblr.Text = "";
            chassis_indicator_lblr.ForeColor = Color.White;
            vehicle_type_indicator_lblr.Text = "";
            vehicle_type_indicator_lblr.ForeColor = Color.White;
            fuel_capacity_indicator_lblr.Text = "";
            fuel_capacity_indicator_lblr.ForeColor = Color.White;
            color_indicator_lblr.Text = "";
            color_indicator_lblr.ForeColor = Color.White;
        }

        private void button8_Click_3(object sender, EventArgs e)
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                savevehicle();
            }
            catch (Exception err)
            {
                MessageBox.Show("Something went wrong", err.Message);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (vehicle_id_txtbox.Text == string.Empty || chassis_name_txtbox.Text == string.Empty || vehicle_type_combox.Text == string.Empty || capacity_txtbox.Text == string.Empty || color_txtbox.Text == string.Empty)
                {
                    vehicle_id_indicator_lblr.Text = "Invalid Input";
                    chassis_indicator_lblr.Text = "Invalid Input";
                    vehicle_type_indicator_lblr.Text = "Invalid Input";
                    fuel_capacity_indicator_lblr.Text = "Invalid Input";
                    color_indicator_lblr.Text = "Invalid Input";

                    vehicle_id_indicator_lblr.ForeColor = Color.Red;
                    chassis_indicator_lblr.ForeColor = Color.Red;
                    vehicle_type_indicator_lblr.ForeColor = Color.Red;
                    fuel_capacity_indicator_lblr.ForeColor = Color.Red;
                    color_indicator_lblr.ForeColor = Color.Red;
                }
                else if (chassis_name_txtbox.TextLength != 17 || double.Parse(chassis_name_txtbox.Text) < 0 || double.Parse(chassis_name_txtbox.Text) == 0)
                {
                    chassis_indicator_lblr.Text = "Invalid Chassis Number Format";
                    chassis_indicator_lblr.ForeColor = Color.Red;
                }
                else if (vehicle_id_txtbox.TextLength != 7) //plus other validation
                {
                    vehicle_id_indicator_lblr.Text = "Invalid Vehicle ID Format";
                    vehicle_id_indicator_lblr.ForeColor = Color.Red;
                }
                else
                {

                    DataGridViewRow newitem = vehicle_datagrid.Rows[idx];
                    newitem.Cells[0].Value = vehicle_id_txtbox.Text;
                    newitem.Cells[1].Value = chassis_name_txtbox.Text;
                    newitem.Cells[2].Value = vehicle_type_combox.Text;
                    newitem.Cells[4].Value = capacity_txtbox.Text;
                    newitem.Cells[5].Value = color_txtbox.Text;
                    Vehicle updatedautomobile = new Vehicle(vehicle_id_txtbox.Text, chassis_name_txtbox.Text, vehicle_type_combox.Text, float.Parse(capacity_txtbox.Text), color_txtbox.Text);
                    Vehicle_CRUD.Update(automobile, updatedautomobile);


                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No numbers in Color", err.Message);
                color_indicator_lblr.Text = "Invalid Input";
                color_indicator_lblr.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fuel_quantity_nup.Value = 0;

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                delvehicle();
            }
            catch (Exception err)
            {
                MessageBox.Show("Unable to delete an empty row", err.Message);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (vehicle_datagrid.Rows.Count > 0)
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
                                PdfPTable pTable = new PdfPTable(vehicle_datagrid.Columns.Count);
                                pTable.DefaultCell.Padding = 2;
                                pTable.WidthPercentage = 100;
                                pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                                foreach (DataGridViewColumn col in vehicle_datagrid.Columns)
                                {
                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                    pTable.AddCell(pCell);
                                }

                                foreach (DataGridViewRow viewRow in vehicle_datagrid.Rows)
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

        private void capacity_txtbox_Enter_1(object sender, EventArgs e)
        {
            if (capacity_txtbox.Text == "Capacity Range")
            {
                capacity_txtbox.Text = "";
            }
            capacity_txtbox.ForeColor = Color.Black;
        }

        private void textBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "SEARCH")
            {
                textBox5.Text = "";
            }
            textBox5.ForeColor = Color.Black;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            if (addedvehicle)
            {
                active();
                fuel_lbl.Text = "Re-Fuel";
                fuel_quantity_lbl_refuel.Text = "Fuel Quantity";
                fuel_quantity_nup.Visible = true;
                fuel_quantity_nup.Enabled = true;
                fuelconsumption_quantity_nup.Visible = false;
                fuelconsumption_quantity_nup.Enabled = false;
            }
            else
            {
                MessageBox.Show("No Vehicles Added Yet");
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (addedvehicle)
            {
                active();
                fuel_lbl.Text = "Fuel-Consumption";
                fuel_quantity_lbl_refuel.Text = "Fuel-Consumed";
                fuelconsumption_quantity_nup.Visible = true;
                fuelconsumption_quantity_nup.Enabled = true;
                fuel_quantity_nup.Visible = false;
                fuel_quantity_nup.Enabled = false;
            }
            else
            {
                MessageBox.Show("No Vehicles Added Yet");
            }
        }


        public string[] searchincsv(string searchterm, string filepath, int posofsearchterm)
        {
            posofsearchterm--;
            string[] recordnotfound = { "Record not found" };
            string[] lines = File.ReadAllLines(@filepath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');
                if (recordmatches(searchterm, fields, posofsearchterm))
                {
                    return fields;
                }
            }
            return recordnotfound;

        }

        public bool recordmatches(string searchterm, string[] record, int posofsearchitem)
        {
            if (record[posofsearchitem].Equals(searchterm))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void active()
        {
            fuel_lbl.Visible = true;
            fuel_lbl.Enabled = true;
            vehicle_lbl_refuel.Visible = true;
            vehicle_lbl_refuel.Enabled = true;
            chassis_lbl_refuel.Visible = true;
            chassis_lbl_refuel.Enabled = true;
            vehicle_type_lbl_refuel.Visible = true;
            vehicle_type_lbl_refuel.Enabled = true;
            fuel_quantity_lbl_refuel.Visible = true;
            fuel_quantity_lbl_refuel.Enabled = true;
            clr_btn.Visible = true;
            clr_btn.Enabled = true;
            cnfrm_btn.Visible = true;
            cnfrm_btn.Enabled = true;
            vehicle_id_refuel.Visible = true;
            vehicle_id_refuel.Enabled = true;
            chassis_refuel.Visible = true;
            chassis_refuel.Enabled = true;
            vehicle_type_combox_refuel.Visible = true;
            vehicle_type_combox_refuel.Enabled = true;
            save_btn.Visible = true;
            save_btn.Enabled = true;
        }

        private void cnfrm_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle foundvehicle = Vehicle_CRUD.Retrieve(vehicle_id_refuel.Text);
                if (fuel_lbl.Text == "Re-Fuel")
                {
                    foundvehicle.Fuelquantity = foundvehicle.refuel(Convert.ToSingle(fuel_quantity_nup.Value));
                    MessageBox.Show("Vehicle Refueled", foundvehicle.Fuelquantity.ToString());
                }
                else if (fuel_lbl.Text == "Fuel-Consumption")
                {
                    foundvehicle.Fuelquantity = foundvehicle.GetFuelConsumed(Convert.ToSingle(fuel_quantity_nup.Value));
                    MessageBox.Show("Vehicle Fuel Decremented", foundvehicle.Fuelquantity.ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            try
            {
                /*string[] output = searchincsv(vehicle_id_refuel.Text, "E:\\Semester 3\\final\\Distribution Managment System\\fuelstats.csv", 1);
                if(output == {"Record not found"})
                {
                    MessageBox.Show("Record not found");
                }*/

                using (var textWriter = new StreamWriter("E:\\Semester 3\\final\\Distribution Managment System\\fuelstats.csv", true))
                {
                    var writer = new CsvWriter(textWriter, CultureInfo.InvariantCulture);

                    writer.WriteField(today);
                    writer.WriteField(vehicle_id_refuel.Text);
                    writer.WriteField(fuelconsumption_quantity_nup.Value);
                    writer.WriteField(fuel_quantity_nup.Value);
                    writer.NextRecord();
                    textWriter.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

