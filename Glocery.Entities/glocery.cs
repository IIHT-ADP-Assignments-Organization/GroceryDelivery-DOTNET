using System;
using System.Collections.Generic;
using System.Text;

namespace Glocery.Entities
{
   public class glocery
    {
        public virtual int GloceryId { get; set; }
        public virtual string GloceryName { get; set; }
        public virtual double GloceryPrice { get; set; }
        public virtual int  CategoryId { get; set; }
    }
}
