using Glocery.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Glocery.BusinessLayer.Interface
{
  public interface  ICustomerServices
    {
        Customer SignUp(Customer customer);
        bool Login(string UserName, string Password);
        Slot AllotSlot(Slot slot);
        Slot ChooseSlot(Slot slot);
        Payment MakePayment(Payment payment);
        glocery PurchaseGlocery(glocery glocery);
        glocery ViewGlocery(glocery glocery);
        glocery SearchGlocery(glocery glocery);
        Offer ViewOffers(Offer offer);
        glocery GetGlocery(glocery glocery);
    }
}
