using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using Distribution_Managment_System.BL;

namespace Distribution_Managment_System.Data_Logic
{
    class UserDL
    {
        static List<User> Users = new List<User>();

        public static User LogIn(string userId, string password)
        {
            foreach(User u in Users)
            {
                if (u.UserID == userId && u.Password == password)
                    return u;
            }

            return null;
        }

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
            Old.Email = New.Email;
            Old.PhoneNum = New.PhoneNum;

            if (Old.Role == "Sale Representative")
                ((Sale_Representative)Old).region = ((Sale_Representative)New).region;

        }

        public static List<int> GetAllUsers()
        {
            List<int> users = new List<int>();
            for (int i=0; i<4; i++)
                users.Add(0);
            
            foreach(User user in Users)
            {
                if (user.Role == "Inventory Supervisor")
                    users[0] += 1;
                else if (user.Role == "Transport Manager")
                    users[2] += 1;
                else if (user.Role == "Order Dispatcher")
                    users[1] += 1;
                else if (user.Role == "Sale Representative")
                    users[3] += 1;
            }

            return users;
        }

        public static bool DeleteUser(string UserId)
        {
            for (int user = 0; user < Users.Count; user++)
            {
                if (Users[user].UserID == UserId)
                {
                    Users.Remove(Users[user]);
                    return true;
                }
            }

            return false;
        }

        public static void StoreUser(User user)
        {
            using (var textWriter = new StreamWriter("Users.csv", true))
            {
                var writer = new CsvWriter(textWriter, CultureInfo.InvariantCulture);
                
                writer.WriteField(user.UserID);
                writer.WriteField(user.Password);
                writer.WriteField(user.Name);
                writer.WriteField(user.Email);
                writer.WriteField(user.PhoneNum);
                writer.WriteField(user.Role);

                if (user.Role == "Sale Representative")
                    writer.WriteField(((Sale_Representative)user).region);
                writer.NextRecord();                
            }
        }

        public static void RewriteUsers()
        {
            using (var textWriter = new StreamWriter("Users.csv"))
            {
                var writer = new CsvWriter(textWriter, CultureInfo.InvariantCulture);

                foreach (User user in Users)
                {
                    writer.WriteField(user.UserID);
                    writer.WriteField(user.Password);
                    writer.WriteField(user.Name);
                    writer.WriteField(user.Email);
                    writer.WriteField(user.PhoneNum);
                    writer.WriteField(user.Role);

                    if(user.Role == "Sale Representative")
                        writer.WriteField(((Sale_Representative)user).region);
                    writer.NextRecord();
                }
            }
        }

        public static void LoadUsers()
        {
            string filePath = "Users.csv";
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

                    if (values[5] == "Sale Representative")
                        Users.Add(new Sale_Representative(values[0], values[1], values[2], values[5], values[3], values[4], values[6]));
                    else
                    {
                        if (values[5] == "Admin")
                            Users.Add(new Admin(values[0], values[1], values[2], values[5], values[3], values[4]));
                        else if (values[5] == "Inventory Supervisor")
                            Users.Add(new Inventory_Supervisor(values[0], values[1], values[2], values[5], values[3], values[4]));
                        else if (values[5] == "Transport Manager")
                            Users.Add(new Transport_Manager(values[0], values[1], values[2], values[5], values[3], values[4]));
                        else if (values[5] == "Order Dispatcher")
                            Users.Add(new Order_Dispatcher(values[0], values[1], values[2], values[5], values[3], values[4]));
                    }
                }
            }
            else
            {
                MessageBox.Show("File doesn't exist");
            }
            
        }

        public static List<User> GetNonSaleRep()
        {
            List<User> returnUsers = new List<User>();  
            foreach(User user in Users)
            {
                if (user.Role != "Admin" && user.Role != "Sale Representative")
                    returnUsers.Add(user);
            }

            return returnUsers;
        }

        public static List<User> GetSaleRep()
        {
            List<User> returnUsers = new List<User>();
            foreach (User user in Users)
            {
                if (user.Role == "Sale Representative")
                    returnUsers.Add(user);
            }

            return returnUsers;
        }

    }
}
