using System;
using System.Collections.Generic;
using System.Text;

namespace Glocery.Test.Exceptions
{
   public class GloceryNotFoundException:Exception
    {
        public string Messages = " Glocery Not Found  ";

        public GloceryNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
