using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace day11_MysqlOrder
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public List<Order> Orders { get; set; }

    }

    public class Goods
    {
        [Key]
        public int GoodsId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }

    public class OrderItem
    {
        [Key]
        public int Index { get; set; } //序号

        public int GoodsId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

       // public Goods GoodsItem { get; set; }

       // public String GoodsName { get => GoodsItem != null ? this.GoodsItem.Name : ""; }

      // public double UnitPrice { get => GoodsItem != null ? this.GoodsItem.Price : 0.0; }

        public int Quantity { get; set; }
    }

    public class Order
    {
        [Key]
        public int OrderId { get; set; }
      
        //public OrderItem OrderItem { get; set; }
        public string GoodName { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public Customer Customer { get; set; }
    }
}
