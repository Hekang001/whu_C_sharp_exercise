using System;
using System.Collections.Generic;
using System.Text;

namespace day06_01_OrderExtension
{
    public class OrderItem 
    {
        public string ItemName { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double SumPrice {
            get=>Quantity * UnitPrice;    
        }

        public OrderItem() { }

        public OrderItem(string name,double p,int q)
        {
            this.ItemName = name;
            this.UnitPrice = p;
            this.Quantity = q;   
        }
       
        //get sum price
      /*  public void getSumPrice()
        {
          Console.WriteLine("SumPrice:"+ this.Quantity * this.UnitPrice);
        }
      */
        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            return item != null &&
                   ItemName == item.ItemName &&
                   UnitPrice == item.UnitPrice &&
                   Quantity == item.Quantity &&
                   SumPrice == item.SumPrice;
        }

        public override string ToString()
        {
            return $" ItemName:{ItemName} " + $" UnitPrice: { UnitPrice} " +$" quantity:{Quantity} " +$"sum:{SumPrice}";
        }
    }

}
