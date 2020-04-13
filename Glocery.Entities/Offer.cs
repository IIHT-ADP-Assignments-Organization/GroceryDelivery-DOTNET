using System;
using System.Collections.Generic;
using System.Text;

namespace Glocery.Entities
{
  public  class Offer
    {
        public virtual int Id { get; set; }
        public virtual string OfferDetails { get; set; }
        public virtual int GloceryId { get; set; }
    }
}
