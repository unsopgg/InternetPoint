using Microsoft.EntityFrameworkCore;

namespace InternetPoint.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> pOptions) : base(pOptions) { }

        #region Model configure

        protected override void OnModelCreating(ModelBuilder builder)
        {
           
        }

        #endregion

       

        #region DbSets

        /// <summary>
        /// Пользователи
        /// </summary>
        public DbSet<Customer> Customers { get; set; }

        /// <summary>
        /// Услуги
        /// </summary>
        public DbSet<ServiceInfo> Services { get; set; }
        public DbSet<Order> Orders { get; set; }


        #endregion
    }
}
