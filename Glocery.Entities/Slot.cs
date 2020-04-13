using System;
using System.Collections.Generic;
using System.Text;

namespace Glocery.Entities
{
   public class Slot
    {
        public virtual int SlotId { get; set; }
        public virtual int SlotNumber { get; set; }
        public virtual int CustomerId { get; set; }

    }
}
