using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Distribution_Managment_System.BL;
using CsvHelper;
using System.Windows.Markup;
using System.Runtime.InteropServices.ComTypes;
using Bogus;

namespace Distribution_Managment_System.Data_Logic
{
    class Products_CRUD
    {
        private static List<Product> allProducts = new List<Product>();
        
        public static List<Product> AllProducts()
        {
            return allProducts;
        }
        public static void EditRecord(Product Updated)
        {
            foreach (Product rec in allProducts)
            {
                if (rec.ProductID == Updated.ProductID)
                {
                    rec.ProductName = Updated.ProductName;
                    rec.Brand = Updated.Brand;
                    rec.SalePrice = Updated.SalePrice;
                    rec.CostPrice = Updated.CostPrice;
                    rec.ThresholdValue = Updated.ThresholdValue;
                    rec.Quantity = Updated.Quantity;
                }
            }
        }

        public static void addtoList(Product rec)
        {
            allProducts.Add(rec);
        }

        public static int TotalProducts()
        {
            return allProducts.Count();
        }

        public static void DeleteaRec(Product recToDel)
        {
            foreach (Product rec in allProducts.ToList())
            {
                if (recToDel == rec)
                {
                    allProducts.Remove(rec);
                }
            }
        }
        public static void StoreProduct(Product rec)
        {
            using (var textWriter = new StreamWriter("Products.csv", true))
            {
                var writer = new CsvWriter(textWriter, CultureInfo.InvariantCulture);

                writer.WriteField(rec.ProductID);
                writer.WriteField(rec.ProductName);
                writer.WriteField(rec.Brand);
                writer.WriteField(rec.SalePrice);
                writer.WriteField(rec.CostPrice);
                writer.WriteField(rec.ThresholdValue);
                writer.WriteField(rec.Quantity);
                writer.NextRecord();
                textWriter.Close();
            }

        }

        public static void RewriteProcuts()
        {
            using (var textWriter = new StreamWriter("Products.csv"))
            {
                var writer = new CsvWriter(textWriter, CultureInfo.InvariantCulture);

                foreach (Product rec in allProducts)
                {
                    writer.WriteField(rec.ProductID);
                    writer.WriteField(rec.ProductName);
                    writer.WriteField(rec.Brand);
                    writer.WriteField(rec.SalePrice);
                    writer.WriteField(rec.CostPrice);
                    writer.WriteField(rec.ThresholdValue);
                    writer.WriteField(rec.Quantity);
                    writer.NextRecord();
                }
                textWriter.Close();
            }
        }
        public static string GenNewID()
        {
            var value = ((int)Products_CRUD.TotalProducts() / 10 == 0) ? "000" + Products_CRUD.TotalProducts().ToString() : ((int)Products_CRUD.TotalProducts() / 100 == 0) ? "00" + (Products_CRUD.TotalProducts().ToString()) : ((int)Products_CRUD.TotalProducts() / 1000 == 0) ? "0" + (Products_CRUD.TotalProducts().ToString()) : Products_CRUD.TotalProducts().ToString();
            return "PR" + value;
        }

        public static void LoadProducts()
        {
            string filePath = "Products.csv";
            StreamReader reader = null;
            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    allProducts.Add(new Product(values[0], values[1], values[2], float.Parse(values[3]), float.Parse(values[4]), int.Parse(values[5]), int.Parse(values[6])));
                }
            }
            reader.Close();
        }

        public static Product GetProdByName(string ProdName)
        {
            foreach (Product prod in allProducts)
            {
                if (prod.ProductName == ProdName)
                    return prod;
            }

            return null;
        }

        public static List<string> GetAllProdName()
        {
            List<string> list = new List<string>();
            foreach (Product prod in allProducts)
                list.Add(prod.ProductName);

            return list;
        }
        public static List<Product> StoreFakeData(int num)
        {

            var ShopFaker = new Faker<Product>()
                .CustomInstantiator(f => new Product())
                 .RuleFor(u => u.ProductName, f => f.Commerce.ProductName())
                 .RuleFor(u => u.Brand, f => f.Company.CompanyName())
                 .RuleFor(u => u.SalePrice, f => float.Parse(f.Commerce.Price()))
                 .RuleFor(u => u.CostPrice, f => float.Parse(f.Commerce.Price()))
                 .RuleFor(u => u.ThresholdValue, f => f.Random.Int(0,1000))
                 .RuleFor(u => u.Quantity, f => f.Random.Int(0, 1000));
            List<Product> ShopList = ShopFaker.Generate(num).ToList();
            foreach (Product rec in ShopList)
            {
                rec.ProductID = GenNewID();
                Products_CRUD.allProducts.Add(rec);
            }
            RewriteProcuts();
            return ShopList;
        }

    }
}
