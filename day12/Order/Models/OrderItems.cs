namespace Order.Models
{
    public class OrderItems{
        public long Id {get;set;}

        public string CustomerName{get;set;}

        public string ItemName{get;set;}

        public double UnitPrice{get;set;}

        public int Quantity{get;set;}

    }
}