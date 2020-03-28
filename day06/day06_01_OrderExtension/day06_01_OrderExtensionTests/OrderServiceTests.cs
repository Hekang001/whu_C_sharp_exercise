using Microsoft.VisualStudio.TestTools.UnitTesting;
using day06_01_OrderExtension;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace day06_01_OrderExtension.Tests
{
    
    [TestClass()]
    public class OrderServiceTests
    {  
        [TestMethod()]
        public void deleteTest()
        {
          List<Order> orderList = new List<Order>() {
            new Order(10002, "Tomi", "Wuhan", "hat", 252, 2),
            new Order(10011, "hekang", "Changsha", "hhh", 12, 5)
          };

            OrderService orderService = new OrderService();
            orderService.delete(10011);
            CollectionAssert.AreNotEqual(orderList, orderService.orderList);
        }
        [TestInitialize]
        [TestMethod()]
        public void queryTest()
        {
            List<Order> orderList = new List<Order>() {
            new Order(10002, "Tomi", "Wuhan", "hat", 252, 2),
            new Order(10011, "hekang", "Changsha", "hhh", 12, 5)
          };

            OrderService orderService = new OrderService();
            //CollectionAssert.AreEqual();
            orderService.query(10002);

        }

        [TestMethod()]
        public void sortOrderTest()
        {
            List<Order> orderList1 = new List<Order>() {
            new Order(10002, "Tomi", "Wuhan", "hat", 252, 2),
            new Order(10011, "hekang", "Changsha", "hhh", 12, 5)
          };

            List<Order> orderList2 = new List<Order>() {
            new Order(10002, "Tomi", "Wuhan", "hat", 252, 2),
            new Order(10011, "hekang", "Changsha", "hhh", 12, 5)
          };

            orderList1.Sort(new IDComparer());
          
            orderList1.ForEach(p => new List<Order>());
          
            OrderService orderService = new OrderService();
           // CollectionAssert.AreEqual();
          //  Assert.IsTrue(orderList1.Sort(new IDComparer())==orderList2.Sort(new IDComparer()))
        }

        [TestMethod()]
        public void queryByIdTest()
        {
            List<Order> orderList1 = new List<Order>() {
                 new Order(10002, "Tomi", "Wuhan", "hat", 252, 2),
                 new Order(10011, "hekang", "Changsha", "hhh", 12, 5),
                 new Order(11111, "Sky", "HongKong", "shoes", 100.5, 1),
                 new Order(11021, "Mac", "Shaoyang", "computer", 18525, 1)  
            };
            var result1 = from s in orderList1 where s.OrderID != 0 orderby s.OrderID select s;

            List<Order> orderList2 = new List<Order>() {
                 new Order(11021, "Mac", "Shaoyang", "computer", 18525, 1),
                 new Order(11111, "Sky", "HongKong", "shoes", 100.5, 1),
                 new Order(10011, "hekang", "Changsha", "hhh", 12, 5),
                 new Order(10002, "Tomi", "Wuhan", "hat", 252, 2) 
            };
            var result2 = from s in orderList2 where s.OrderID != 0 orderby s.OrderID select s;

            foreach(var order1 in result1)
            {   
                foreach(var order2 in result2)
                {  
                    Assert.AreEqual(order1, order2); //测试order1和order2是否相同 
                }
            }
        }

        [TestMethod()]
        public void ExportTest()
        {
            List<Order> orderList1 = new List<Order>() {
            new Order(10002, "Tomi", "Wuhan", "hat", 252, 2),
            new Order(10011, "hekang", "Changsha", "hhh", 12, 5)
          };

        }
    }
}