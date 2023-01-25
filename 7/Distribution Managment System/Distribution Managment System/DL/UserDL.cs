using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Distribution_Managment_System.BL;

namespace Distribution_Managment_System.DL
{
    class UserDL
    {
        static List<User> Users = new List<User>();

        public static void CreateUser(User EndUser)
        {
            Users.Add(EndUser);
        }

        public static User RetrieveUser(string UserId)
        {
            foreach (User user in Users)
            {
                if (user.UserID == UserId)
                    return user;
            }

            return null;
        }

        public static void UpdateUser(User Old, User New)
        {
            Old.Name = New.Name;
            Old.Password = New.Password;
            Old.Email = New.Email;
            Old.PhoneNum = New.PhoneNum;

            if (Old.Role == "Sale Representative")
            {
                Sale_Representative old = (Sale_Representative)Old;
                Sale_Representative nnew = (Sale_Representative)New;
                old.region = nnew.region;
            }
        }

        public static void DeleteUser(User ToDel)
        {
            Users.Remove(ToDel);
        }

    }
}
