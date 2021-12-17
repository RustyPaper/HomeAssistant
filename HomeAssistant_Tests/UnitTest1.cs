using Business.Repository.IRepository;
using HomeAssistant_API.Controllers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace HomeAssistant_Tests
{
    public class TestHomeApController
    {
        private readonly HomeApController _controller;
        private readonly IHomeApRepository _homeApRepository;

        public TestHomeApController(HomeApController controller, IHomeApRepository homeApRepository)
        {
            _controller = controller;
            _homeApRepository = homeApRepository;
        }
        [Fact]
        public async Task GetAllApartaments()
        {
            var okResult = _controller.GetHomeAps();
        }
    }
}
