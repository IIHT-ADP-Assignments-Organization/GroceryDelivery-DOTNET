using Glocery.BusinessLayer.Interface;
using Glocery.DataLayer.NHibernateConfiguration;
using Glocery.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Glocery.BusinessLayer.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly IMapperSession _session;

        public CustomerServices(IMapperSession session)
        {
            _session = session;
        }
        public Slot AllotSlot(Slot slot)
        {
            Slot ObjSlot = new Slot();
            return ObjSlot;
        }

        public Slot ChooseSlot(Slot slot)
        {
            Slot ObjSlot = new Slot();
            return ObjSlot;
        }

        public glocery GetGlocery(glocery glocery)
        {
            glocery ObjGlocery = new glocery();
            return ObjGlocery;
        }

        public bool Login(string UserName, string Password)
        {
            return true;
        }

        public Payment MakePayment(Payment payment)
        {
            Payment ObjPayment = new Payment();
            return ObjPayment;
        }

        public glocery PurchaseGlocery(glocery glocery)
        {
            glocery ObjGlocery = new glocery();
            return ObjGlocery;
        }

        public glocery SearchGlocery(glocery glocery)
        {
            glocery ObjGlocery = new glocery();
            return ObjGlocery;
        }

        public Customer SignUp(Customer customer)
        {
            Customer ObjCustomer = new Customer();
            return ObjCustomer;
        }

        public glocery ViewGlocery(glocery glocery)
        {
            glocery ObjGlocery = new glocery();
            return ObjGlocery;
        }

        public Offer ViewOffers(Offer offer)
        {
            Offer ObjOffer = new Offer();
            return ObjOffer;
        }
    }
}
