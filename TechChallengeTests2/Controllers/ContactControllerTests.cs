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
        [TestMethod()]
        public void GetTest()
        {
            throw new NotImplementedException("NO data");
        }

        public bool SaveContactTest(int number, string name)
        {
            if (number == 1 && name == "")
            {
                return false;
            }
            throw new NotImplementedException("Please add data");
        }
    }
}