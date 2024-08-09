using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartWithMultipleClassConnected.Models
{
    public class Customers
    {
        private int _customerId;
        private string _customerName;

        public static List<Orders> orders = new List<Orders>();

        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        public Customers(int customerId, string customerName) 
        {
            CustomerId = customerId;
            CustomerName = customerName;
        }
    }
}
