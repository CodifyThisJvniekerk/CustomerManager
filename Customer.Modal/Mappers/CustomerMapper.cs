using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Modal.Mappers
{
    class CustomerMapper : EntityTypeConfiguration<Customer.Modal.Entities.Customer>
    {
        public CustomerMapper()
        {
            this.ToTable("Customer");
            this.HasKey(c => c.ID);
            this.Property(c => c.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.ID).IsRequired();
            this.Property(c => c.ID).HasColumnName("CustomerID");
            //Flag as required field
            this.Property(c => c.Name).IsRequired();
            //Set max lenght of customer name field.
            this.Property(c => c.Name).HasMaxLength(255);
            //Latitude not nessarily need to have data
            this.Property(c => c.Latitude).IsOptional();
            this.Property(c => c.Longitude).IsOptional();
        }
    }
}
