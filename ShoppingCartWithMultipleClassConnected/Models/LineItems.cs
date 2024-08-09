using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartWithMultipleClassConnected.Models
{
    public class LineItems
    {
        private int _lineitemId;

        private int _quantity;

        private Product _product;


        public int LineItemId
        {
            get { return _lineitemId; }
            set { _lineitemId = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        
        public Product Product 
        {
            get { return _product; }
            set { _product = value; }
        }

        public LineItems(int lineItemId, int lineItemQuantity, Product product) 
        {
            LineItemId = lineItemId;
            Quantity = lineItemQuantity;
            Product = product;

        }

        public double CalulateLineItemCost()
        {
            double lineItemCost = Quantity * Product.ProductPriceAfterDiscount;
            return lineItemCost;

        }
    }
}
