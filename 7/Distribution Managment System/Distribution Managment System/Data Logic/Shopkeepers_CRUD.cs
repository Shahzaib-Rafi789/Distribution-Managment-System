using Distribution_Managment_System.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Managment_System.Data_Logic
{
    class Shopkeepers_CRUD
    {
        private static List<Shopkeeper> Shopkeepers = new List<Shopkeeper>();

        public static void Add(Shopkeeper shopkeeper)
        {
            Shopkeepers.Add(shopkeeper);
        }

        public static Shopkeeper Retrieve(String str)
        {
            foreach (Shopkeeper shopkeeper in Shopkeepers.ToList())
            {
                if (str == shopkeeper.ShopkeeperID1)
                {
                    return shopkeeper;
                }
            }
            return null;
        }

        public static bool Delete(String str)
        {
            foreach (Shopkeeper shopkeeper in Shopkeepers.ToList())
            {
                if (str == shopkeeper.ShopkeeperID1)
                {
                    Shopkeepers.Remove(shopkeeper);
                    return true;
                }
            }
            return false;
        }

        public static void Update(Shopkeeper oldshopkeeper, Shopkeeper newshopkeeper)
        {
            foreach (Shopkeeper shopkeeper in Shopkeepers.ToList())
            {
                if (shopkeeper==oldshopkeeper)
                {
                    //update
                
                }
            }
        }

        public static List<string> GetAllShops()
        {
            List<String> Shops = new List<String>();
            foreach (Shopkeeper shopkeeper in Shopkeepers)
            {
                foreach (Shop shop in shopkeeper.ShopsOwned1)
                {
                    Shops.Add(shop.ShopName1 + ", " + shop.Address1 + ", " + shop.ShopID1);
                }
            }

            return Shops;
        }
    }
}
