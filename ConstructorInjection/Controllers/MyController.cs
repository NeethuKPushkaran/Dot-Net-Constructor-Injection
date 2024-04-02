using ConstructorInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace ConstructorInjection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyController : ControllerBase
    {
        private readonly IMyService _myService;

        public MyController(IMyService myService)
        {
            _myService = myService;
        }

        [HttpGet]

        public IActionResult Get()
        {
            _myService.DoSomething();
            return Ok("Success");
        }
    }
}
