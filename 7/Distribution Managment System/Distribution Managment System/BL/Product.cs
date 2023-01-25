using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Managment_System.BL
{
    public class Product
    {
        string productID;
        string productName;
        string brand;
        float salePrice;
        float costPrice;
        int thresholdValue;
        int quantity;

        public Product(string productID, string productName, string brand, float salePrice, float costPrice, int thresholdValue)
        {
            this.productID = productID;
            this.productName = productName;
            this.brand = brand;
            this.salePrice = salePrice;
            this.costPrice = costPrice;
            this.thresholdValue = thresholdValue;
        }
        public Product()
        {

        }
        public Product(string productID, string productName, string brand, float salePrice, float costPrice, int thresholdValue, int quantity)
        {
            this.productID = productID;
            this.productName = productName;
            this.brand = brand;
            this.salePrice = salePrice;
            this.costPrice = costPrice;
            this.thresholdValue = thresholdValue;
            this.quantity = quantity;
        }

        public string ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Brand { get => brand; set => brand = value; }
        public float SalePrice { get => salePrice; set => salePrice = value; }
        public float CostPrice { get => costPrice; set => costPrice = value; }
        public int ThresholdValue { get => thresholdValue; set => thresholdValue = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public float getProfit()
        {
            return SalePrice-CostPrice;
        }
        
    }
}
