using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day11_MysqlOrder
{
    public class OrderContext: DbContext
    {
        public OrderContext() : base()   //没找到App.Config文件 将其中的name="*****"写入就行 然后将password改成本地的密码就行了
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
