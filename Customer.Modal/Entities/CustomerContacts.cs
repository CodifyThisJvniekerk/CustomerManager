using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Modal.Entities
{
    class CustomerContacts
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public long CustomerID { get; set; }

        public Customer CustomerContact { get; set; }
    }
}
