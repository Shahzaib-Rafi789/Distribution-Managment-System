using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Distribution_Managment_System.Data_Logic;
using Distribution_Managment_System.BL;

namespace Distribution_Managment_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Inventory_Supervisor IS = new Inventory_Supervisor("IS0001", "Password123#", "Muhammad Subhan", "Inventory SUpervisor", "mail@.com", "9325654654");
            Products_CRUD.LoadProducts();
            UserDL.LoadUsers();
            CRUD_Orders.LoadOrders();
            CRUD_OrderLine.LoadOrderLines();
            //Products_CRUD.LoadProducts();
            //UserDL.LoadUsers();
            //CRUD_Orders.LoadOrders();
            //CRUD_OrderLine.LoadOrderLines();
            //Vehicle_CRUD.Load();-input string issue when loading
            //Shops_CRUD.Load();
            //Riders_CRUD.Load(); -input string issue when loading
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GenerateRoute());
            //Application.Run(new OrderConfirm());
            Application.Run(new GenerateRoute());
            //Application.Run(new Map());
            //Application.Run(new ChangePassword(UserDL.GetNonSaleRep()[0]));
            //Application.Run(new Form1());
            //Application.Run(new ManageSupplier(new Inventory_Supervisor("", "", "", "", "", "")));
            //Application.Run(new Admin_DashBoard(UserDL.RetrieveUser("Admn0001")));
            //Application.Run(new Admin_DashBoard(UserDL.RetrieveUser("Ad0001")));
            //Application.Run(new RiderWindow());
            //Application.Run(new VehicleWindow());
            //Application.Run(new BillhistoryWindow());
            //Application.Run(new ShopkeeperWindow());
            //Application.Run(new VehicleWindow());
            //Application.Run(new GenerateRouteWindow());
            //Application.Run(new ConfirmOrdersWindow());
        }
    }
}
