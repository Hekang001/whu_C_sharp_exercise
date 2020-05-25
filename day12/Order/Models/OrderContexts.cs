using Microsoft.EntityFrameworkCore;

namespace Order.Models
{
    public class OrderContext : DbContext{
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options){
            this.Database.EnsureCreated(); //自动建库建表
        }

        public DbSet<TodoItem> OrderItems { get; set; }
    }
}