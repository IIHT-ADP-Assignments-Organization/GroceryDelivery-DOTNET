using FluentNHibernate.Mapping;
using Glocery.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Glocery.DataLayer.Mapping
{
  public  class CutomerMap : ClassMap<Customer>
    {
        public CutomerMap()
        {
            Id(x => x.CustomerId);

            Map(x => x.UserName);

            Map(x => x.Phonenumber);
            Map(x => x.Email);
            Map(x => x.Password);
           
            Table("user");

        }
    }
}
