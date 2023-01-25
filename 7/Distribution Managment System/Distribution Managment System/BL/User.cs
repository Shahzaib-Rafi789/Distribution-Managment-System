using Distribution_Managment_System.Data_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Managment_System.BL
{
    public abstract class User
    {
        private string userID;
        private string password;
        private string name;
        private string role;
        private string email;
        private string phoneNum;

        public string UserID { get => userID; set => userID = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }

        protected User(string userID, string password, string name, string role, string email, string phoneNum)
        {
            UserID = userID;
            Password = password;
            Name = name;
            Role = role;
            Email = email;
            PhoneNum = phoneNum;
        }

        public bool UpdatePassword(string OldPassword, string NewPassword)
        {
            if (this.Password == OldPassword)
            {
                this.Password = NewPassword;
                UserDL.RewriteUsers();
                return true;
            }

            return false;
        }
    }
}
