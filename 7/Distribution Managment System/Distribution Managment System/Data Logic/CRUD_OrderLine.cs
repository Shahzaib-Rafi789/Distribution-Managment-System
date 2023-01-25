using CsvHelper;
using Distribution_Managment_System.BL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribution_Managment_System.Data_Logic
{
    public class CRUD_OrderLine
    {
        public static void StoreOrderLine(OrderLine orderLine)
        {
            using (var textWriter = new StreamWriter("OrderLines.csv", true))
            {
                var writer = new CsvWriter(textWriter, CultureInfo.InvariantCulture);

                writer.WriteField(orderLine.OrderId);
                writer.WriteField(orderLine.QuantityDemand);
                writer.WriteField(orderLine.QuantityGiven);
                writer.WriteField(orderLine.ProductName);
                writer.WriteField(orderLine.Price);
                writer.WriteField(orderLine.Status);

                writer.NextRecord();
            }
        }

        public static void RewriteOrderLines()
        {
            using (var textWriter = new StreamWriter("OrderLines.csv"))
            {
                var writer = new CsvWriter(textWriter, CultureInfo.InvariantCulture);

                List<Order> orders = CRUD_Orders.GetOrderList();
                foreach (Order order in orders)
                {
                    foreach (OrderLine orderLine in order.OrderLineList)
                    {
                        writer.WriteField(orderLine.OrderId);
                        writer.WriteField(orderLine.QuantityDemand);
                        writer.WriteField(orderLine.QuantityGiven);
                        writer.WriteField(orderLine.ProductName);
                        writer.WriteField(orderLine.Price);
                        writer.WriteField(orderLine.Status);

                        writer.NextRecord();
                    }
                }
            }
        }

        public static void LoadOrderLines()
        {
            string filePath = "OrderLines.csv";
            StreamReader reader = null;
            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Order ord = CRUD_Orders.RetrieveOrder(values[0]);
                    if (ord != null)
                    {
                        ord.OrderLineList.Add(new OrderLine(values[0], int.Parse(values[1]), int.Parse(values[2]), values[3], float.Parse(values[4]), bool.Parse(values[5])));
                    }
                }
            }
            else
            {
                MessageBox.Show("File doesn't exist");
            }

        }
    }
}
