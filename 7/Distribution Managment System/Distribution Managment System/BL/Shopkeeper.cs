using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Managment_System.BL
{
    class Shopkeeper
    {
        private string ShopkeeperID;
        private string ShopkeeperName;
        private string Phonenum;
        private List<Shop> ShopsOwned = new List<Shop>();

        public string ShopkeeperID1 { get => ShopkeeperID; set => ShopkeeperID = value; }
        public string ShopkeeperName1 { get => ShopkeeperName; set => ShopkeeperName = value; }
        public string Phonenum1 { get => Phonenum; set => Phonenum = value; }
        public List<Shop> ShopsOwned1 { get => ShopsOwned; set => ShopsOwned = value; }

        public static void AddShop(Shop shop)
        {
            //ShopsOwned.Add(shop);
        }

        /*public static void UpdateShop(Shop oldshop, Shop newshop)
        {

            foreach (ShopsOwned shops in ShopsOwned.ToList())
            {
                if (shops == oldshop)
                {
                    //update 
                }
            }
        }

        public static bool DeleteShop(String id)
        {
            foreach (ShopsOwned shops in ShopsOwned1.ToList())
            {
                if (id == shops.ShopID)
                {
                    ShopsOwned1.Remove(shops);
                }
            }
            return false;
        }*/


    }
}
