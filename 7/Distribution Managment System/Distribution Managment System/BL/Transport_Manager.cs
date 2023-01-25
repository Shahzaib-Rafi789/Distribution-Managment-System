using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Managment_System.BL
{
     class Transport_Manager : User
    {
        public Transport_Manager(string userID, string password, string name, string role, string email, string phoneNum) : base(userID, password, name, role, email, phoneNum)
        {
        }
    }
}
