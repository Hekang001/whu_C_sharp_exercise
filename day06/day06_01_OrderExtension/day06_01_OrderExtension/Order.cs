using System;
using System.Collections.Generic;
using System.Text;

namespace day06_01_OrderExtension
{
    public class Order : OrderItem
    { 
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }

        //origin constructor
        public Order(){}

     /*   public Order(int orderID, string customerName, string address)
        {
            this.OrderID = orderID;
            this.CustomerName = customerName;
            this.Address = address;
        }
*/
        //constructor
        public Order(int id ,string name,string address,string Itemname,double p,int q) : base(Itemname, p, q)
        {
            this.OrderID = id;
            this.CustomerName = name;
            this.Address = address;
        }

        public override bool Equals(Object obj)
        {
            Order order = obj as Order;
            return this.OrderID == order.OrderID;
        }

        public override string ToString()
        {
            return $" id:{OrderID} " + $" customerName:{CustomerName} "+$" address:{Address} " + base.ToString();
        }
    }
}
