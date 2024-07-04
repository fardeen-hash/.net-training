using System;

class Program
{
    static void Main()
    {
       Customer customer = new Customer("12312","fardeen" );
       Order order1 = new Order(1);
       Order order2 = new Order(2);
       customer.OrderList.Add(order1);
       customer.OrderList.Add(order2);

       foreach ( Order order in customer.OrderList)
        {
            Console.WriteLine(order.Id);
        }

    }
}