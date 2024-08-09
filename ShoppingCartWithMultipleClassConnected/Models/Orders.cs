using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartWithMultipleClassConnected.Models
{
    public class Orders
    {
        private int _orderId;
        private DateTime _date;

        public List<LineItems> lineItems = new List<LineItems>();

        public int OrdersId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public Orders(int orderID, DateTime date) 
        {
            OrdersId = orderID;
            Date = date;
        }

        public double CalculateOrderPrice()
        {
            double totalOrderPrice = 0;

            foreach (LineItems item in lineItems) 
            {
                totalOrderPrice += item.CalulateLineItemCost();
            }
            return totalOrderPrice;
        }

        public void AddLineItem(LineItems item)
        {
            lineItems.Add(item);
        }
    }
}
