using System;
using System.Collections.Generic;
using System.Text;

namespace Glocery.Entities
{
    public class Payment
    {
        public virtual int Id { get; set; }
        public virtual string PaymentMode { get; set; }
        public virtual int CustomerId { get; set; }
    }
}
