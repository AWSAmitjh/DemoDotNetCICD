using AspNetCoreWebApplication.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApplicationTest.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void IndexTest()
        {
            HomeController controller = new HomeController();
            Assert.Equal("Test", "Test");
        }

        [Fact]
        public void ErrorTest()
        {
            HomeController controller = new HomeController();
            Assert.Equal("yes", "yes");
        }
    }
}