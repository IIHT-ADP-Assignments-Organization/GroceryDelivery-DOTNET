using Glocery.BusinessLayer.Services;
using Glocery.DataLayer.NHibernateConfiguration;
using Glocery.Entities;
using Glocery.Test.Exceptions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Glocery.Test.TestCases
{
  public  class ExceptionTest
    {
        private readonly CustomerServices _CustomerServices;
        private readonly AdminServices _AdminServices;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionTest()
        {
            _CustomerServices = new CustomerServices(_session);
            _AdminServices = new AdminServices(_session);
        }

        [Fact]
        public void ExceptionTestFor_UserNotFoundforCustomer()
        {
            Customer user = new Customer()
            {
                UserName = "abc",
                Password=""

            };
            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => _CustomerServices.Login(user.UserName, user.Password));
            Assert.Equal("User Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_UserNotFoundforAdmin()
        {
            Admin admin = new Admin()
            {
                UserName = "abc",
                Password = ""

            };
            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => _CustomerServices.Login(admin.UserName, admin.Password));
            Assert.Equal("User Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_GloceryNotFound()
        {
            glocery glocery = new glocery()
            {
                CategoryId = 1,
                GloceryId = 1,
                GloceryName = "",
                GloceryPrice = 11
            };
            //Assert
            var ex = Assert.Throws<GloceryNotFoundException>(() => _CustomerServices.SearchGlocery(glocery));
            Assert.Equal("Glocery Not Found ", ex.Messages);
        }



        [Fact]
        public void ExceptionTestFor_UserCannotblank()
        {
            Customer user = new Customer()
            {
                UserName = "abc",
                Password = ""

            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _CustomerServices.SignUp(user));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_GloceryDetailsCannotblank()
        {
            glocery glocery = new glocery()
            {
                GloceryId = 1,
                CategoryId = 1,
                GloceryName = "",
                GloceryPrice = 3
            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _AdminServices.AddGlocery(glocery));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }
    }
}
