using Glocery.BusinessLayer.Services;
using Glocery.DataLayer.NHibernateConfiguration;
using Glocery.Entities;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Glocery.Test.TestCases
{
  public class FunctionalTest
   {
        private readonly CustomerServices _CustomerServices;
        private readonly AdminServices _AdminServices;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FunctionalTest()
        {
            _CustomerServices = new CustomerServices(_session);
            _AdminServices = new AdminServices(_session);
        }

        [Fact]
        public void Test_for_Login()
        {
            Admin admin = new Admin()
            {
                
              
                Email = "aa@gmail.com",
                Password = "1234"
            };
            var SignIn = _AdminServices.Login(admin.Email,admin.Password);
            Assert.True(SignIn);
        }

        [Fact]
        public void Test_for_AddGlocery()
        {
            glocery glocery = new glocery()
            {
                GloceryId = 1,
                GloceryName = "",
                GloceryPrice = 11,
                CategoryId = 2
            };
            var Result = _AdminServices.AddGlocery(glocery);
            var Glocery = Result.ToString();
            Assert.NotNull(Glocery);
        }

        [Fact]
        public void Test_for_AddCategory()
        {
            Category category = new Category()
            {
                Id = 1,
                CatrgoryName = ""
            };
            var Result = _AdminServices.AddCategory(category);
            var Category = Result.ToString();
            Assert.NotNull(Category);
        }


        [Fact]
        public void Test_for_AddOffers()
        {
            Offer offer = new Offer()
            {
                Id = 1,
                GloceryId = 1,
                OfferDetails = ""
            };
            var Result = _AdminServices.AddOffers(offer);
            var Offer = Result.ToString();
            Assert.NotNull(Offer);
        }

        [Fact]
        public void Test_for_ViewallCustomer()
        {
            Customer customer = new Customer()
            {
                CustomerId = 1,
                Email = "",
                Password = "",
                Phonenumber = "",
                UserName = ""
            };

           

            var Result = _AdminServices.ViewallCustomer(customer);
            var ViewCustomer = Result.ToString();
            Assert.NotNull(ViewCustomer);
        }

        [Fact]
        public void Test_for_DeleteGlocery()
        {
            glocery glocery = new glocery()
            {
                GloceryId = 1,
               
            };

            var Result = _AdminServices.DeleteGlocery(glocery.GloceryId);
           
            Assert.True(Result);
        }

        [Fact]
        public void Test_for_DeleteCategory()
        {
            Category category = new Category()
            {
                Id = 1,
               
            };

            var Result = _AdminServices.DeleteCategory(category.Id);
            Assert.True(Result);
        }

        [Fact]
        public void Test_for_DeleteOffer()
        {
            Offer offer = new Offer()
            {
                Id = 1,
              
            };

            var Result = _AdminServices.DeleteOffer(offer.Id);
            Assert.True(Result);
        }

        [Fact]
        public void Test_for_ViewGlocery()
        {
            glocery glocery = new glocery()
            {
                GloceryId = 1,

            };



            var Result = _AdminServices.ViewGlocery(glocery.GloceryId);
            var ViewGlocery = Result.ToString();
            Assert.NotNull(ViewGlocery);
        }

        [Fact]
        public void Test_for_ViewCategory()
        {
            Category category = new Category()
            {
                Id = 1,

            };



            var Result = _AdminServices.ViewCategory(category.Id);
            var ViewCatrgory = Result.ToString();
            Assert.NotNull(ViewCatrgory);
        }

        [Fact]
        public void Test_for_ViewOffer()
        {
            Offer offer = new Offer()
            {
                Id = 1,

            };




            var Result = _AdminServices.ViewOffer(offer.Id);
            var ViewOffer = Result.ToString();
            Assert.NotNull(ViewOffer);
        }


        [Fact]
        public void Test_for_AddPaymentMethods()
        {
            Payment payment = new Payment()
            {
                CustomerId = 1,
                Id = 1,
                PaymentMode = ""
            };



            var Result = _AdminServices.AddPaymentMethods(payment);
            var AddPaymentMethods = Result.ToString();
            Assert.NotNull(AddPaymentMethods);
        }

        [Fact]
        public void Test_for_SignUp()
        {
            Customer customer = new Customer()
            {
                CustomerId = 1,
                Email = "",
                Password = "",
                Phonenumber = "",
                UserName = ""
            };


            var Result = _CustomerServices.SignUp(customer);
            var GetCustomer = Result.ToString();
            Assert.NotNull(GetCustomer);
        }

        [Fact]
        public void Test_for_LoginForCustomer()
        {
            Customer customer = new Customer()
            {
               
                Password = "",
               
                UserName = ""
            };


            var Result = _CustomerServices.Login(customer.UserName,customer.Password);
        
            Assert.True(Result);
        }

        [Fact]
        public void Test_for_AllotSlot()
        {
            Slot slot = new Slot()
            {
                SlotId = 1,
                CustomerId = 1,
                SlotNumber = 1
            };


            var Result = _CustomerServices.AllotSlot(slot);
        
            Assert.NotNull(Result);
        }

        [Fact]
        public void Test_for_ChooseSlot()
        {
            Slot slot = new Slot()
            {
                SlotId = 1,
                CustomerId = 1,
                SlotNumber = 1
            };


            var Result = _CustomerServices.ChooseSlot(slot);

            Assert.NotNull(Result);
        }


        [Fact]
        public void Test_for_MakePayment()
        {
            Payment payment = new Payment()
            {
                CustomerId = 1,
                Id = 1,
                PaymentMode = ""
            };


            var Result = _CustomerServices.MakePayment(payment);

            Assert.NotNull(Result);
        }

        [Fact]
        public void Test_for_PurchaseGlocery()
        {
            glocery glocery = new glocery()
            {
                GloceryId = 1,
                CategoryId=1,
                GloceryName="",
                GloceryPrice=3
            };



            var Result = _CustomerServices.PurchaseGlocery(glocery);

            Assert.NotNull(Result);
        }

        [Fact]
        public void Test_for_ViewGloceryForCustomer()
        {
            glocery glocery = new glocery()
            {
                GloceryId = 1,
                CategoryId = 1,
                GloceryName = "",
                GloceryPrice = 3

            };



            var Result = _CustomerServices.ViewGlocery(glocery);

            Assert.NotNull(Result);
        }


        [Fact]
        public void Test_for_SearchGlocery()
        {
            glocery glocery = new glocery()
            {
                GloceryId = 1,
                CategoryId = 1,
                GloceryName = "",
                GloceryPrice = 3

            };



            var Result = _CustomerServices.ViewGlocery(glocery);
            var GetGlocery = _CustomerServices.GetGlocery(glocery);

            Assert.Equal(GetGlocery,Result);
        }

        [Fact]
        public void Test_for_ViewOffers()
        {
            Offer offer = new Offer()
            {
                Id = 1,
                GloceryId=1,
                OfferDetails=""

            };



            var Result = _CustomerServices.ViewOffers(offer);
           

            Assert.NotNull(Result);
        }





    }
}
