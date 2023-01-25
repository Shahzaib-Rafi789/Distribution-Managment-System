using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Managment_System.BL
{
    public class OrderLine
    {
        string orderId;
        int quantityDemand; // Quantity company ordered.
        int quantityGiven; //Quantity company will give.
        string productName;
        float price;
        bool status;

        public OrderLine(string orderId, int quantity, string productName, float price)
        {
            this.OrderId = orderId;
            this.QuantityDemand = quantity;
            this.QuantityGiven = quantity;
            this.ProductName = productName;
            this.Price = price;
            this.Status = false;
        }

        public OrderLine(string orderId, int quantityDemand, int quantityGiven, string productName, float price, bool status)
        {
            this.OrderId = orderId;
            this.QuantityDemand = quantityDemand;
            this.QuantityGiven = quantityGiven;
            this.ProductName = productName;
            this.Price = price;
            this.Status = status;
        }

        public string OrderId { get => orderId; set => orderId = value; }
        public float Price { get => price; set => price = value; }
        public bool Status { get => status; set => status = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int QuantityDemand { get => quantityDemand; set => quantityDemand = value; }
        public int QuantityGiven { get => quantityGiven; set => quantityGiven = value; }
    }
    
}
