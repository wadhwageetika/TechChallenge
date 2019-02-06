using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechChallenge.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechChallenge.Services;
using TechChallenge.Models;

namespace TechChallenge.Controllers.Tests
{
    [TestClass()]
    public class ContactControllerTests
    {
        private readonly ContactRepository _primeService;

        //[TestMethod()]
        public ContactControllerTests()
        {
            //String Name = "Geetika";
            _primeService = new ContactRepository();
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllContactsTest()
        {
            //var result = _primeService.GetAllContacts
            //    (
            //    new Contact[]
            //    {
            //new Contact
            //{
            //    Number = 0,
            //    Name = "Test"
            //}
            //    }
            //);
            //throw new NotImplementedException("NO data");
        }

        public bool SaveContactTest(int number, string name)
        {
            if (number == 1)
            {
                return false;
            }
            throw new NotImplementedException("Please add data");
        }

    }
}