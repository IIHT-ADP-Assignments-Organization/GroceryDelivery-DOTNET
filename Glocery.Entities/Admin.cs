﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Glocery.Entities
{
   public class Admin
    {
        public virtual int Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual string Phonenumber { get; set; }

    }
}
