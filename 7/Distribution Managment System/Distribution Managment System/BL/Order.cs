using Distribution_Managment_System.Data_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Managment_System.BL
{
    public class Order
    {
        string orderId;
        string shopId;
        float bill;
        DateTime date;
        string orderStatus;
        List<OrderLine> orderLineList = new List<OrderLine>();
        bool delStatus;

        public Order(string orderId, string shopDat, DateTime date, List<OrderLine> orderLineList)
        {
            this.OrderId = orderId;
            this.ShopId = shopDat;
            this.Date = date;
            this.orderStatus = OrderStatus.Processing.ToString();
            this.OrderLineList = orderLineList;
            GenerateBill();
            delStatus = false;
        }
        public Order()
        {
           
        }


        public Order(string orderId, string shopId, float bill, DateTime date, string orderStatus, List<OrderLine> orderLineList, bool delStatus)
        {
            this.OrderId = orderId;
            this.ShopId = shopId;
            this.Date = date;
            this.orderStatus = orderStatus;
            this.OrderLineList = orderLineList;
            this.Bill = bill;
            this.delStatus = delStatus;
        }

        public string OrderId { get => orderId; set => orderId = value; }
        public string ShopId { get => shopId; set => shopId = value; }
        public float Bill { get => bill; set => bill = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Order_Status { get => orderStatus;}
        public List<OrderLine> OrderLineList { get => orderLineList; set => orderLineList = value; }
        public bool DelStatus { get => delStatus; }

        public void ChangeStatusCancel()
        {
            this.orderStatus = OrderStatus.Canceled.ToString();
        }

        public void ChangeStatusConfirm()
        {
            this.orderStatus = OrderStatus.Confirmed.ToString();
        }

        public void ChangeStatusPartConfirm()
        {
            this.orderStatus = OrderStatus.Partially.ToString();
        }

        public void ChangeStatus(string status)
        {
            this.orderStatus = status;
        }

        public void SetDelStatus()
        {
            this.delStatus = true;
        }

        public void UpdateOrderLines(List<OrderLine> orderLineList)
        {
            this.orderLineList = orderLineList;
            GenerateBill();
        }

        public void GenerateBill()
        {
            this.bill = 0;
            foreach (OrderLine orderLine in OrderLineList)
                this.bill += (orderLine.Price * orderLine.QuantityGiven);
        }

        public bool IsBtwTimeInterval(DateTime StartTime, DateTime EndTime)
        {
            int t1 = date.CompareTo(StartTime), t2 = date.CompareTo(EndTime);
            if (t1 >= 0 && t2 <= 0)
                return true;

            return false;
        }

        public List<OrderLine> GetOrderLineList()
        {
            List<OrderLine> list = new List<OrderLine>();
            foreach (OrderLine i in OrderLineList)
                list.Add(i);

            return list;
        }
    }
}
