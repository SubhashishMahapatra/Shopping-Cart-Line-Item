using ShoppingCartWithMultipleClassConnected.Models;

class Program
{
    public static void Main(string[] args)
    {
        
        PrintOrders();
    }

    public static void PrintOrders()
    {
        Customers customer = new Customers(1, "Subhashish");

        Product product1 = new Product(1, "Iphone", 50000, 10);
        Product product2 = new Product(2, "Samsung", 30000, 20);


        LineItems lineitem1 = new LineItems(1, 5, product1);
        LineItems lineItem2 = new LineItems(2, 3, product2);


        Orders order1 = new Orders(1, DateTime.Now);
        Orders order2 = new Orders(2, DateTime.Now);

        order1.lineItems.Add(lineitem1);
        order1.lineItems.Add(lineItem2);

        order2.lineItems.Add(lineItem2);


        Customers.orders.Add(order1);
        Customers.orders.Add(order2);


        Console.WriteLine("Customer Id: " + customer.CustomerId);
        Console.WriteLine("Customer Name: " + customer.CustomerName);
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------");

        foreach (Orders orders in Customers.orders)
        {
            Console.WriteLine();
            Console.WriteLine("Order Number: " + orders.OrdersId);
            Console.WriteLine("Order Time: " + orders.Date);

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"| {"LineItem",-10} | {"Product Item",-10} | {"Product Name",-10} | {"Quantity",-10} | {"Unit Price",-20} | {"Discount",-10} | {"Unit Cost After Discount",-20} | {"Total Line Item Cost",20} |");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------");



            foreach (LineItems items in orders.lineItems)
            {
                

                Console.WriteLine($"| {items.LineItemId,-10} | {items.Product.ProductId,-10}    | {items.Product.ProductName,-10} | {items.Quantity,-10} | {items.Product.ProductPrice,-20} | {items.Product.DiscountPercent,-10} | {items.Product.ProductPriceAfterDiscount,-20} | {items.CalulateLineItemCost(),20} |");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------");
            }

            Console.WriteLine($"{"Total Cost" , -10}{orders.CalculateOrderPrice(), 130}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------");

        }
    }
}