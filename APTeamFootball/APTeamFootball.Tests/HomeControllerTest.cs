using System;
using System.Web.Mvc;
using APTeamFootball.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace APTeamFootball.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        //test if index file exists
        [TestMethod]
        public void Index()
        {
            HomeController homecontroller = new HomeController();
            ViewResult result = homecontroller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        //test if about file exists
        [TestMethod]
        public void About()
        {
            HomeController homecontroller = new HomeController();
            ViewResult result = homecontroller.About() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AboutMessage()
        {
            HomeController homecontroller = new HomeController();
            ViewResult result = homecontroller.About() as ViewResult;
            Assert.AreEqual("Find out more about how Premier League is organized",result.ViewBag.Message);
        }

        //test if contact file exists
        [TestMethod]
        public void Contact()
        {
            HomeController homecontroller = new HomeController();
            ViewResult result = homecontroller.Contact() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ContactMessage()
        {
            HomeController homecontroller = new HomeController();
            ViewResult result = homecontroller.Contact() as ViewResult;
            Assert.AreEqual("Where to find us", result.ViewBag.Message);
        }
    }
}
