using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Modal.Mappers
{
    class CustomerContactMapper : EntityTypeConfiguration<Customer.Modal.Entities.CustomerContacts>
    {
        public CustomerContactMapper()
        {
            this.ToTable("CustomerContact");

            this.HasKey(c => c.ID);
            this.Property(c => c.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.ID).IsRequired();

            this.Property(c => c.Name).HasMaxLength(255);
            this.Property(c => c.Name).IsRequired();
            //For optimization a telephone number size 20 should be used as the maximum lenght of a contact number is 15 according to research.
            // the contact number is a required field since a contact with no number is worthless data
            this.Property(c => c.ContactNumber).HasMaxLength(20);
            this.Property(c => c.ContactNumber).IsRequired();
            //Email addresses are quite large not an required field since this data is less likely to be known be the capturer i have not seen
            // an email address longer than 55 characters but for safety i am making the field length 255
            this.Property(c => c.Email).HasMaxLength(255);
            this.Property(c => c.Email).IsRequired();

            this.HasRequired(e => e.CustomerContact).WithMany().Map(s => s.MapKey("CustomerID")).WillCascadeOnDelete();
        }
    }
}
