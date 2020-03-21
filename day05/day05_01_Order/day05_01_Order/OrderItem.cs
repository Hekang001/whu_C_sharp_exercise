using System;
using System.Collections.Generic;
using System.Text;

namespace day05_01_Order
{
    internal class OrderItem 
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double SumPrice { get; set; }

        public OrderItem(){}

        public OrderItem(string name,double p,int q)
        {
            this.Name = name;
            this.UnitPrice = p;
            this.Quantity = q; 
        }
       
        //get sum price
        public double getSumPrice()
        {
           return this.Quantity * this.UnitPrice;
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            return item != null &&
                   Name == item.Name &&
                   UnitPrice == item.UnitPrice &&
                   Quantity == item.Quantity &&
                   SumPrice == item.SumPrice;
        }

        public override string ToString()
        {
            return $"name:{Name}" + $"UnitPrice: { UnitPrice}" +$"quantity:{Quantity}";
        }
    }

}
