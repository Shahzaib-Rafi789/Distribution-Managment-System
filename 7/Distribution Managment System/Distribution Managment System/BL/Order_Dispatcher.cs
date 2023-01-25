using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Managment_System.BL
{
    class Order_Dispatcher: User
    {
        public Order_Dispatcher(string userID, string password, string name, string role, string email, string phoneNum) : base(userID, password, name, role, email, phoneNum)
        {
        }
    }
}
