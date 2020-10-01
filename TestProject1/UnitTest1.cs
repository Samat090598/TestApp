using System;
using Microsoft.AspNetCore.Mvc;
using TestApp2.Controllers;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void IndexViewDataMessage()
        {
            HomeController controller = new HomeController();
            
            ViewResult result = controller.Index() as ViewResult;
            
            Assert.Equal("Hello worl!", result?.ViewData["Message"]);
        }
    }
}