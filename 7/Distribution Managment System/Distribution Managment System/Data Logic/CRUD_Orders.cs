using Bogus;
using CsvHelper;
using CsvHelper.TypeConversion;
using DevExpress.XtraReports.Native.Templates;
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
    public class CRUD_Orders
    {
        private static List<Order> OrderList = new List<Order>();

        public static void AddOrder(Order NOrder)
        {
            OrderList.Add(NOrder);
        }
        public static List<Order> ordersInADurationbyShop(DateTime start, DateTime end, string shopId)
        {
            List<Order> orders = new List<Order>();
            foreach (Order order in OrderList)
            {
                if (order.ShopId == shopId && order.IsBtwTimeInterval(start, end))
                {
                    orders.Add(order);
                }
            }
            return orders;
        }

        public static List<Order> GetCurrentOrder(string region) //Today Order (Sale Rep)
        {
            List<Order> orders = new List<Order>();
            foreach (Order order in OrderList)
            {
                if (Shops_CRUD.GetRegion(order.ShopId) == region)
                {
                    if (!order.DelStatus && order.Date.ToString("dd MM yyyy") == DateTime.Now.ToString("dd MM yyyy"))
                    {
                        orders.Add(order);
                    }
                }
            }

            return orders;
        }

        public static List<Order> GetOrders()// Order Dispatcher
        {
            DateTime Today = DateTime.Today;
            DateTime Yesterday = DateTime.Today.AddDays(-1);

            List<Order> orders = new List<Order>();
            foreach (Order order in OrderList)
            {
                if (order.Order_Status == OrderStatus.Processing.ToString())
                {
                    if (!order.DelStatus && (order.Date.ToString("dd MM yyyy") == Today.ToString("dd MM yyyy") || order.Date.ToString("dd MM yyyy") == Yesterday.ToString("dd MM yyyy")))
                        orders.Add(order);
                }
            }

            return orders;
        }

        public static List<Order> GetOrdersForDelievery()// Transport Manager
        {
            DateTime Yesterday= DateTime.Today.AddDays(-1);
            List<Order> orders = new List<Order>();
            foreach (Order order in OrderList)
            {
                if (order.Order_Status == OrderStatus.Partially.ToString() || order.Order_Status == OrderStatus.Confirmed.ToString())
                    if (!order.DelStatus && order.Date.ToString("dd MM yyyy") == Yesterday.ToString("dd MM yyyy"))
                        orders.Add(order);
            }

            return orders;
        }

        public static List<Order> GetOrderList()
        {
            return OrderList;
        }

        public static Order RetrieveOrder(string id)
        {
            foreach (Order order in OrderList)
            {
                if (order.OrderId == id)
                {
                    return order;
                }
            }

            return null;
        }

        private static DateTime ConvertToDateTime(string format)
        {
            List<string> timeDat = format.Split(' ').ToList();
            DateTime dt = new DateTime(int.Parse(timeDat[2]), int.Parse(timeDat[1]), int.Parse(timeDat[0]));
            return dt;
        }

        public static void UpdateOrder(Order OldOrder, Order NewOrder)
        {
            OldOrder.ShopId = NewOrder.ShopId;
            OldOrder.UpdateOrderLines( NewOrder.OrderLineList);
            OldOrder.ChangeStatus(NewOrder.Order_Status);
        }

        public static bool DeleteOrder(string id)
        {
            foreach (Order order in OrderList)
            {
                if (order.OrderId == id)
                {
                    order.SetDelStatus();
                    return true;
                }
            }

            return false;
        }

        public static void LoadOrders()
        {
            string filePath = "Orders.csv";
            StreamReader reader = null;
            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (line == "")
                        continue;

                    OrderList.Add(new Order(values[0], values[1], float.Parse(values[2]), ConvertToDateTime(values[3]), values[4], new List<OrderLine>(), bool.Parse(values[5])));
                }
            }
            else
            {
                MessageBox.Show("Order Record File doesn't exist.");
            }

        }

        public static void StoreOrder(Order order)
        {
            using (var textWriter = new StreamWriter("Orders.csv", true))
            {
                var writer = new CsvWriter(textWriter, CultureInfo.InvariantCulture);

                writer.WriteField(order.OrderId);
                writer.WriteField(order.ShopId);
                writer.WriteField(order.Bill);
                writer.WriteField(order.Date.ToString("dd MM yyyy"));
                writer.WriteField(order.Order_Status);
                writer.WriteField(order.DelStatus);

                foreach (OrderLine orderLine in order.OrderLineList)
                    CRUD_OrderLine.StoreOrderLine(orderLine);

                writer.NextRecord();
            }
        }

        public static void RewriteOrders()
        {
            using (var textWriter = new StreamWriter("Orders.csv"))
            {
                var writer = new CsvWriter(textWriter, CultureInfo.InvariantCulture);

                foreach (Order order in OrderList)
                {
                    writer.WriteField(order.OrderId);
                    writer.WriteField(order.ShopId);
                    writer.WriteField(order.Bill);
                    writer.WriteField(order.Date.ToString("dd MM yyyy"));
                    writer.WriteField(order.Order_Status);
                    writer.WriteField(order.DelStatus);

                    writer.NextRecord();
                }
            }
        }
        public static string GenNewID()
        {

            string value = "0000" + ((int)OrderList.Count() + 1).ToString();
            return "OID" + value.Substring(value.Length-4);
        }
        public static List<Order> StoreFakeData(int num)
        {

            var Faker = new Faker<Order>()

                .CustomInstantiator(f => new Order())

                 .RuleFor(u => u.ShopId, f => f.PickRandom(Shops_CRUD.ShopList).ShopID1)
                 .RuleFor(u => u.Date, f => f.Date.Between(new DateTime(2022, 12, 14), new DateTime(2015, 11, 11)))
                 .RuleFor(u => u.Order_Status, f => f.PickRandom(Enum.GetValues(typeof(OrderStatus)).Cast<string>()));

            List<Order> OrderList = Faker.Generate(num).ToList();
            foreach (Order rec in CRUD_Orders.OrderList)
            {
                rec.OrderId = GenNewID();
                OrderList.Add(rec);
            }
            RewriteOrders();
            return OrderList;
        }
    }
}
