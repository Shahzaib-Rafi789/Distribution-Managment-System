using Distribution_Managment_System.Data_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Managment_System.BL
{
    public class Sale_Representative : User
    {
        string Region;
        public Sale_Representative(string userID, string password, string name, string role, string email, string phoneNum, string Region) : base(userID, password, name, role, email, phoneNum)
        {
            this.Region = Region;
        }

        public string region { get => Region; set => Region = value; }

        public void AddOrder(Order order)
        {
            CRUD_Orders.AddOrder(order);
            CRUD_Orders.StoreOrder(order);
        }

        public void UpdateOrder(Order Old, Order New, bool orderChange, bool orderlineChange)
        {
            CRUD_Orders.UpdateOrder(Old, New);
            if (orderChange) CRUD_Orders.RewriteOrders();
            if (orderlineChange)
            {
                CRUD_Orders.RewriteOrders();
                CRUD_OrderLine.RewriteOrderLines();
            }
        }

        public bool DeleteOrder(string id)
        {
            bool result = CRUD_Orders.DeleteOrder(id);
            CRUD_Orders.RewriteOrders();
            return result;
        }
    }
}
