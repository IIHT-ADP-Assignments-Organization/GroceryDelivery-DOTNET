using Glocery.BusinessLayer.Interface;
using Glocery.DataLayer.NHibernateConfiguration;
using Glocery.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Glocery.BusinessLayer.Services
{
    public class AdminServices : IAdminServices
    {
        private readonly IMapperSession _session;

        public AdminServices(IMapperSession session)
        {
            _session = session;
        }

        public int AddCategory(Category category)
        {
            Category ObjCategory = new Category();
            return ObjCategory.Id;
        }

        public int AddGlocery(glocery glocery)
        {
            glocery ObjGlocery = new glocery();
            return ObjGlocery.GloceryId;
        }

        public int AddOffers(Offer offer)
        {
            Offer ObjOffer = new Offer();
            return ObjOffer.Id;
        }

        public int AddPaymentMethods(Payment payment)
        {
            Payment ObjPayment = new Payment();
            return ObjPayment.Id;
        }

        public bool DeleteCategory(int Category)
        {
            return true;
        }

        public bool DeleteGlocery(int GloceryId)
        {
            return true;
        }

        public bool DeleteOffer(int OfferId)
        {
            return true;
        }

        public bool Login(string Email, string Password)
        {
            return true;
        }

        public List<Customer> ViewallCustomer(Customer customer)
        {
            List<Customer> ObjCustomer = new List<Customer>();
            return ObjCustomer;
        }

        public Category ViewCategory(int CategoryId)
        {
            Category ObjCategory = new Category();
            return ObjCategory;
        }

        public glocery ViewGlocery(int GloceryId)
        {
            glocery ObjGlocery = new glocery();
            return ObjGlocery;
        }

        public Offer ViewOffer(int OfferId)
        {
            Offer ObjOffer = new Offer();
            return ObjOffer;
        }
    }
}
