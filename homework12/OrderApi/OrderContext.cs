using Microsoft.EntityFrameworkCore;

namespace OrderApi
{
    public class OrderContext:DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
            
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CommodityInfo> Commodities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

    }
}
