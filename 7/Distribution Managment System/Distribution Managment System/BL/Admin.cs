using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Distribution_Managment_System.Data_Logic;

namespace Distribution_Managment_System.BL
{
    public class Admin: User
    {
        public Admin(string userID, string password, string name, string role, string email, string phoneNum) :base(userID, password, name, role, email, phoneNum)
        {
        }

        public void AddUser(User user)
        {
            UserDL.CreateUser(user);
            UserDL.StoreUser(user);
        }

        public void UpdateUser(User Old, User New)
        {
            UserDL.UpdateUser(Old, New);
            UserDL.RewriteUsers();
        }

        public bool DeleteUser(string id)
        {
            bool result = UserDL.DeleteUser(id);
            if (result == true)
                UserDL.RewriteUsers();
            return result;
        }
    }
}
