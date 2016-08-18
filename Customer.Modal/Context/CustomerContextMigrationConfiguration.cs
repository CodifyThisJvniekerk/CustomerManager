using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace Customer.Modal
{

    class CustomerContextMigrationConfiguration : DbMigrationsConfiguration<Customer.Modal.CustomerContext>
    {
        public CustomerContextMigrationConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }
#if DEBUG
        protected override void Seed(CustomerContext context)
        {
            base.Seed(context);
        }
#endif
    }
}
