using System;
using System.Web.Mvc;
using APTeamFootball.Controllers;
using APTeamFootball.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace APTeamFootball.Tests
{
    [TestClass]
    public class AstonVillaTest
    {
 
        //check if create file exists for AstonVilla
        [TestMethod]
        public void Create()
        {
            AstonVillaPlayersController astonvillaplayerscontroller = new AstonVillaPlayersController();
            ViewResult result = astonvillaplayerscontroller.Create() as ViewResult;
            Assert.IsNotNull(result);
        }

    }
}
