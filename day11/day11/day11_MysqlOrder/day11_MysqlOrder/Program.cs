using Org.BouncyCastle.Asn1.Esf;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace day11_MysqlOrder
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //添加Customer
            using (var db = new OrderContext())
            {
                var customer = new Customer { CustomerId = 1, Name = "Sky" };
                customer.Orders = new List<Order>()
                {
                    new Order(){OrderId = 1, Price=100, GoodName="shoes", Quantity=2 },
                    new Order(){OrderId = 2, Price=12.3, GoodName="hat", Quantity=1}
                };
                var customer1 = new Customer { CustomerId = 2, Name = "HK" };
                customer1.Orders = new List<Order>()
                {
                    new Order(){OrderId = 1, Price=1314, GoodName="mouse", Quantity=1 },
                    new Order(){OrderId = 3, Price=132, GoodName="book", Quantity=1}
                };

                db.Customers.Add(customer);
                db.Customers.Add(customer1);
                db.SaveChanges();
            }
           
            //添加Order
            using (var context = new OrderContext())
            {
                var post = new Order()
                {
                   OrderId =4,GoodName="clothes", Price =520,Quantity=2
                };
                context.Entry(post).State = EntityState.Added;
                context.SaveChanges();
            }


            //根据Id查找订单
            using (var context = new OrderContext())
            {
                var customer = context.Customers
                    .SingleOrDefault(b => b.CustomerId == 1);
                if (customer != null) 
                    Console.WriteLine(customer.Name);
            }

             //查询Customer名字为"Sky"的所有订单
            using (var context = new OrderContext())
            {
                var query = context.Orders
                    .Where(p => p.Customer.Name == "Sky")
                    .OrderBy(p => p.OrderId);
                foreach (var p in query)
                {
                    Console.WriteLine(p.GoodName);
                }
            }

            //删除Id为1的Customer及其Order
            using (var context = new OrderContext())
            {
                var customer = context.Customers.Include(b => b.Orders).FirstOrDefault(p => p.CustomerId == 1);
                if (customer != null)
                {
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                }
            }

        }
    }
}
