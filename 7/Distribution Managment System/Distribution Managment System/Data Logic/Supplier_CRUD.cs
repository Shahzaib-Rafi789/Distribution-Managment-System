using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using Distribution_Managment_System.BL;

namespace Distribution_Managment_System.Data_Logic
{
    internal class Supplier_CRUD
    {
        static List<Supplier> suppliers = new List<Supplier>();

        public static List<Supplier> Suppliers { get => suppliers;}

        public static void AddObj(Supplier supplier)
        {
            Suppliers.Add(supplier);
        }

        public static Supplier RetrieveSupplier(string SuppId)
        {
            foreach (Supplier suppl in Suppliers)
            {
                if (suppl.SupplierID == SuppId)
                    return suppl;
            }

            return null;
        }

        public static void UpdateSupplier(Supplier Old, Supplier New)
        {
            Old.Name = New.Name ;
            Old.Email = New.Email ;
            Old.PhoneNum = New.PhoneNum ;
            Old.ProductsOffered = New.ProductsOffered;
        }

        public static bool DeleteSupplier(string SuppId)
        {
            foreach (Supplier suppl in Suppliers)
            {
                if (suppl.SupplierID == SuppId)
                {
                    Suppliers.Remove(suppl);
                    return true;
                }
            }

            return false;
        }

        public static void StoreSupplier(Supplier supplier)
        {
            using (var textWriter = new StreamWriter("Suppliers.csv", true))
            {
                var writer = new CsvWriter(textWriter, CultureInfo.InvariantCulture);

                writer.WriteField(supplier.SupplierID);
                writer.WriteField(supplier.Name);
                writer.WriteField(supplier.Email);
                writer.WriteField(supplier.PhoneNum);
                writer.WriteField(supplier.ProdInString(';'));

                writer.NextRecord();
            }
        }

        public static void RewriteSuppliers()
        {
            using (var textWriter = new StreamWriter("Suppliers.csv"))
            {
                var writer = new CsvWriter(textWriter, CultureInfo.InvariantCulture);

                foreach (Supplier supplier in Suppliers)
                {
                    writer.WriteField(supplier.SupplierID);
                    writer.WriteField(supplier.Name);
                    writer.WriteField(supplier.Email);
                    writer.WriteField(supplier.PhoneNum);
                    writer.WriteField(supplier.ProdInString(';'));

                    writer.NextRecord();
                }
            }
        }

        public static List<Product> getProdList(List<string> prods)
        {
            List<Product> p = new List<Product>();
            foreach (string prod in prods)
            {
                // Real Code
                p.Add(new Product("", prod, "", 1, 1, 1));
            }

            return p;
        }

        public static void LoadSuppliers()
        {
            string filePath = "Suppliers.csv";
            StreamReader reader = null;
            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    List<string> prodName = values[4].Split(';').ToList();
                    Suppliers.Add(new Supplier(values[0], values[1], values[2], values[3], getProdList(prodName)));
                }
            }
            else
            {
                MessageBox.Show("File doesn't exist");
            }

        }
    }
}
