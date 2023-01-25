using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Managment_System.BL
{
    public class Supplier
    {
        string supplierID;
        string name;
        string email;
        string phoneNum;
        List<Product> productsOffered = new List<Product>();

        public Supplier(string supplierID, string name, string email, string phoneNum, List<Product> productsOffered)
        {
            this.SupplierID = supplierID;
            this.Name = name;
            this.Email = email;
            this.PhoneNum = phoneNum;
            this.ProductsOffered = productsOffered;
        }

        public string SupplierID { get => supplierID; set => supplierID = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public List<Product> ProductsOffered { get => productsOffered; set => productsOffered = value; }

        public string ProdInString(char sep)
        {
            string ret = "";
            foreach (Product product in productsOffered)
                ret += product.ProductName + sep + " ";

            if (ret == "")
                return ret ;
            else
                return ret.Substring(0, ret.Length - 3) ;
        }
    }
}
