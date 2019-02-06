using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechChallenge.Services;

namespace TechChallengeTests1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly ContactRepository _primeService;
        [TestMethod]
        public void TestMethod1()
        {
        }
        private readonly ContactRepository _primeService;

       [TestMethod()]
        public void GetAllContactsTest()
        {
            var result = _primeservice.getallcontacts
                (
                new contact[]
                {
            new contact
            {
                number = 0,
                name = "test"
            }
                }
            );
            throw new notimplementedexception("no data");
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
