using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Customer.Modal
{
    class CustomerContext : DbContext
    {
        public CustomerContext()
            : base("CustomerManagerConnection")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CustomerContext, CustomerContextMigrationConfiguration>());
        }
        public DbSet<Customer.Modal.Entities.Customer> Customer { get; set; }
        public DbSet<Customer.Modal.Entities.CustomerContacts> CustomerContacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Customer.Modal.Mappers.CustomerMapper());
            modelBuilder.Configurations.Add(new Customer.Modal.Mappers.CustomerContactMapper());

            base.OnModelCreating(modelBuilder);
        }
    }
}
