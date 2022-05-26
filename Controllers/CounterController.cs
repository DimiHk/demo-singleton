using demo_singleton.Services;
using Microsoft.AspNetCore.Mvc;

namespace demo_singleton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CounterController : ControllerBase
    {
        private readonly ICounter _counterService;

        public CounterController(ICounter counterService)
        {
            _counterService = counterService;
        }

        [HttpGet]
        [Route("getInstance")]
        public CounterService GetCounterInstance()
        { 
            return _counterService.GetCounterInstance();
        }

        [HttpPost]
        [Route("decrementCounter")]
        public int DecrementCounter()
        {
            return _counterService.DecrementCounter();
        }

        [HttpPost]
        [Route("incrementCounter")]
        public int IncrementCounter()
        {
            return _counterService.IncrementCounter();
        }

        [HttpGet]
        [Route("compareInstances")]
        public Boolean CompareInstances([FromServices] ICounter service)
        {
            return _counterService.CompareInstances((CounterService) service);
        }
    }
}