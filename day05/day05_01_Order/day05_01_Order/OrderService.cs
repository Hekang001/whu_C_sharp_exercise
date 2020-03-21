using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace day05_01_Order
{
    class OrderService
    {
        //private Order order;

        static List<Order> orderList = new List<Order>() {
            new Order(10002, "Tomi", "Wuhan", "hat", 252, 2),
            new Order(10011, "hekang", "Changsha", "hhh", 12, 5)
        };

        //   IEnumerable<Order>  result = from s in orderList where s. select s;

        //增加订单功能
        public void add()
        {
            orderList.Insert(0, new Order(10001, "Tom", "China", "shirt", 25.2, 2));
            orderList.Insert(1, new Order(11111, "Sky", "HongKong", "shoes", 100.5, 1));
            orderList.Insert(0, new Order(11021, "Mac", "Shaoyang", "computer", 18525, 1));
        }

        //删除功能
        public void delete(int id)
        {
            try
            {
                foreach (Order order in orderList)
                {
                    if (order.OrderID.Equals(id))
                        orderList.Remove(order);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Delete failed!");
            }
        }

        //查询功能
        public void query(int id)
        {
            try
            {
                foreach (Order order in orderList)
                {
                    if (order.OrderID.Equals(id))
                    {
                        Console.WriteLine(order.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: query failed!");
            }
        }

        //按订单号排序
        public void sortOrder()
        {
            orderList.Sort(new IDComparer());
        }

        //LINQ查询语句
        public void queryById()
        {
            var result = from s in orderList where s.OrderID != 0 orderby s.OrderID select s;

            foreach(var order in result)
            {
                Console.WriteLine(order);
            }
        }

    }    

    //比较器
    class IDComparer : IComparer<Order>
    {
        public int Compare(Order order1, Order order2)
        {
                 return order1.OrderID - order2.OrderID;
        }
    }

}
