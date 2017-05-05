﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection.Tests
{
    [TestClass()]
    public class ConnectionTests
    {
        [TestMethod()]
        public void LoginTest()
        {
            string username = "admin";
            string password = "1234";
            bool result = false;
            string username1 = "admin1";
            string password1 = "123";
            bool result1 = false;
            result = Connection.Login(username, password);
            result1 = Connection.Login(username1, password1);
            Assert.AreEqual(true, result);
            Assert.AreEqual(false, result1);
        }
    }
}