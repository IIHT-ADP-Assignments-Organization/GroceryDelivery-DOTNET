using System;
using System.Collections.Generic;
using System.Text;

namespace Glocery.Entities
{
   public class Customer
    {
        public virtual int CustomerId { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual string Phonenumber { get; set; }

    }
}
