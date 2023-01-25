using Distribution_Managment_System.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribution_Managment_System.Data_Logic
{
    class Shops_CRUD
    {
        public static List<Shop> ShopList = new List<Shop>();

        public static void Add(Shop shop)
        {
            ShopList.Add(shop);
        }

        public static IList<string> getShopsWithID()
        {
            IList<string> shops = new List<string>();
            foreach (Shop shop in ShopList)
            {
                shops.Add(shop.ShopID1 + " : " + shop.ShopName1);
            }
            return shops;
        }

        public static void Load()
        {
            try
            {
                string filePath = "E:\\Semester 3\\final\\Distribution Managment System\\shopkeepers.csv";
                StreamReader reader = null;
                if (File.Exists(filePath))
                {
                    reader = new StreamReader(File.OpenRead(filePath));
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        ShopList.Add(new Shop(values[0], values[1], values[2], values[3], values[4]));
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data not loaded into list", ex.Message);
            }
        }


        public static Shop Retrieve(String id)
        {
            foreach (Shop shops in ShopList.ToList())
            {
                if (id == shops.ShopID1)
                {
                    return shops;
                }
            }
            return null;
        }

        public static string getNamebyID(String id)
        {
            foreach (Shop shops in ShopList.ToList())
            {
                if (id == shops.ShopID1)
                {
                    return shops.ShopName1;
                }
            }
            return null;
        }


        public static bool Delete(String id)
        {
            foreach (Shop shops in ShopList.ToList())
            {
                if (id == shops.ShopID1)
                {
                    ShopList.Remove(shops);
                    return true;
                }
            }
            return false;
        }

        public static void Update(Shop oldshop, Shop newshop)
        {
            foreach (Shop shops in ShopList.ToList())
            {
                
                if (shops == oldshop)
                {
                    oldshop.ShopID1 = newshop.ShopID1;
                    oldshop.ShopName1 = newshop.ShopName1;
                    oldshop.Region1 = newshop.Region1;
                    oldshop.Landline1 = newshop.Landline1;
                    oldshop.Address1 = newshop.Address1;

                }
            }
        }

        public static string GetShopInfo(string id)
        {
            foreach (Shop shop in ShopList)
                if (shop.ShopID1 == id)
                    return shop.GetShopInfo();

            return id;
        }

        public static string GetRegion(string id)
        {
            foreach (Shop shop in ShopList)
                if (shop.ShopID1 == id)
                    return shop.Region1;

            return "";
        }
    }
}
