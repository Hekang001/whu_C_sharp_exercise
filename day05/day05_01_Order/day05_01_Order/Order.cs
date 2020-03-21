using System;
using System.Collections.Generic;
using System.Text;

namespace day05_01_Order
{
    class Order : OrderItem
    { 
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        
        //origin constructor
        public Order(){}

        public Order(int orderID, string customerName, string address)
        {
            OrderID = orderID;
            CustomerName = customerName;
            Address = address;
        }

        //constructor
        public Order(int id ,string name,string address,string Itemname,double p,int q) : base(name, p, q)
        {
            this.OrderID = id;
            this.Name = name;
            this.Address = address;
        }

        public override bool Equals(Object obj)
        {
            Order order = obj as Order;
            return this.OrderID == order.OrderID;
        }

        public override string ToString()
        {
            return $"id:{OrderID}"+$"customerName:{CustomerName}"+base.ToString();
        }
    }
}
