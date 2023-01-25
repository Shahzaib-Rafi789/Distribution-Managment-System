using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Managment_System.BL
{
    class Shop
    {
        private string ShopID;
        private string ShopName;
        private string Region;
        private string Landline;
        private string Address;


        public Shop(string ShopID, string ShopName, string Region, string Landline,string Address)
        {
            this.ShopID = ShopID;
            this.ShopName = ShopName;
            this.Region = Region;
            this.Landline = Landline;
        }


        public string ShopID1 { get => ShopID; set => ShopID = value; }
        public string ShopName1 { get => ShopName; set => ShopName = value; }
        public string Region1 { get => Region; set => Region = value; }
        public string Landline1 { get => Landline; set => Landline = value; }
        public string Address1 { get => Address; set => Address = value; }
        //location

        public string GetShopInfo()
        {
            return ShopName + ", " + Address + ", " + ShopID; 
        }
    }
}
