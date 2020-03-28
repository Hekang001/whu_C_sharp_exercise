using System;
using System.Collections.Generic;

namespace day06_01_OrderExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orderList = new List<Order>() {
            new Order(10002, "Tomi", "Wuhan", "hat", 252, 2),
            new Order(10011, "hekang", "Changsha", "hhh", 12, 5)
        };
            OrderService orderService = new OrderService();
             
            // orderService.delete(10002);
            orderService.add(orderList);
            orderService.query(10011);
            Console.WriteLine("------Sort-------");
            orderService.sortOrder(orderList);
            orderService.Export(orderList);
        }
    }


}
