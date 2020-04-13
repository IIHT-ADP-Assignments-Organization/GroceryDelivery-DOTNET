using Glocery.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Glocery.BusinessLayer.Interface
{
   public interface IAdminServices
   {
        bool Login(string Email, string Password);
        int AddGlocery(glocery glocery);
        int AddCategory(Category category);
        int AddOffers(Offer offer);
        List<Customer> ViewallCustomer(Customer customer);
        bool DeleteGlocery(int GloceryId);
        bool DeleteCategory(int Category);
        bool DeleteOffer(int OfferId);
        glocery ViewGlocery(int GloceryId);
        Category ViewCategory(int CategoryId);
        Offer ViewOffer(int OfferId);
        int AddPaymentMethods(Payment payment);


   }
}
