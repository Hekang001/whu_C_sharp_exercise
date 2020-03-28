using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

namespace day06_01_OrderExtension
{
  //  [Serializable]
    public class OrderService
    {
        //private Order order;
       
         public List<Order> orderList = new List<Order>() {
            new Order(10002, "Tomi", "Wuhan", "hat", 252, 2),
            new Order(10011, "hekang", "Changsha", "hhh", 12, 5)
        };

        //   IEnumerable<Order>  result = from s in orderList where s. select s;

        //增加订单功能
        public void add(List<Order> orderList)
        {
          //  orderList.AddRange(10001, "Tom", "China", "shirt", 25.2, 2);
            orderList.Insert(2, new Order(10001, "Tom", "China", "shirt", 25.2, 2));
            orderList.Insert(3, new Order(11111, "Sky", "HongKong", "shoes", 100.5, 1));
            orderList.Insert(4, new Order(11021, "Mac", "Shaoyang", "computer", 18525, 1));
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
                orderList.ForEach(p => Console.WriteLine(p));
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
                Console.WriteLine("Error: query failed!"+ex.StackTrace);
            }
        }

        //按订单号排序
        public void sortOrder(List<Order> orderList)
        {
            orderList.Sort(new IDComparer());
            orderList.ForEach(p=>Console.WriteLine(p));
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

        public void Export(List<Order> orderList) 
        {
            Console.WriteLine("original array object:");
            orderList.ForEach(p => Console.WriteLine(p));

    /*      Console.WriteLine("serialized into s.temp.");
            BinaryFormatter binFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("s.temp", FileMode.Create))
            {
                binFormatter.Serialize(fs, orderList);
            }

            using (FileStream fs = new FileStream("s.temp", FileMode.Open))
            {
                List<Order> order = (List<Order>)binFormatter.Deserialize(fs);
                Console.WriteLine("Deserialized from s.temp");
                order.ForEach(p => Console.WriteLine(p));
            }  
    */
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("s.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orderList);
            }

            Console.WriteLine("\nSerialized as XML:");
            Console.WriteLine(File.ReadAllText("s.xml"));

            using (FileStream fs = new FileStream("s.xml", FileMode.Open))
            {
                List<Order> order2 = (List<Order>)xmlSerializer.Deserialize(fs);
                Console.WriteLine("\nDeserialized from s.xml");
                order2.ForEach(p => Console.WriteLine(p));
            }
        }
    }    

    //比较器
   public class IDComparer : IComparer<Order>
    {
        public int Compare(Order order1, Order order2)
        {
                 return order1.OrderID - order2.OrderID;
        }
    }

}
