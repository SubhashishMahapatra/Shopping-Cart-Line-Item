using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartWithMultipleClassConnected.Models
{
    public class Product
    {
        private int _productId;
        private string _productName;
        private double _productPrice;
        private double _discountPercent;


        public double ProductPriceAfterDiscount { get; set; }

        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public double ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; }
        }

        public double DiscountPercent
        {
            get { return _discountPercent; }
            set { _discountPercent = value; }
        }

        public Product(int productId, string productName, double productPrice, double discountPercent)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            DiscountPercent = discountPercent;
            ProductPriceAfterDiscount = CalculateDiscountedPrice(productPrice,discountPercent);

        }



        public double CalculateDiscountedPrice(double productPrice, double discountPercent)
        {
            
            double discountedPrice = ProductPrice - ((ProductPrice *  DiscountPercent)/100);
            return discountedPrice;
        }



    }
}
