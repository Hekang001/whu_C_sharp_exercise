using System;

namespace day05_01_Order
{
    class Program
    {
        static void Main(string[] args)
        {
           OrderService orderService = new OrderService();
            orderService.sortOrder();
            orderService.query(10001);
        }
    }


}
