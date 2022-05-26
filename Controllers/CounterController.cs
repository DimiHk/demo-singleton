using demo_singleton.Services;
using Microsoft.AspNetCore.Mvc;

namespace demo_singleton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CounterController : ControllerBase
    {
        private readonly ICounter _counterService;
        private readonly ICounter _counterServiceTest;

        public CounterController(ICounter counterService, ICounter counterServiceTest)
        {
            _counterService = counterService;
            _counterServiceTest = counterServiceTest;
        }

        [HttpGet]
        [Route("getInstance")]
        public async Task<CounterService> GetCounterInstance()
        { 
            return await _counterService.GetCounterInstance();
        }

        [HttpPost]
        [Route("decrementCounter")]
        public async Task<int> DecrementCounter()
        {
            return await _counterService.DecrementCounter();
        }

        [HttpPost]
        [Route("incrementCounter")]
        public async Task<int> IncrementCounter()
        {
            return await _counterService.IncrementCounter();
        }

        [HttpGet]
        [Route("compareInstances")]
        public async Task<Boolean> CompareInstances()
        {
            return await _counterService.CompareInstances((CounterService) _counterServiceTest);
        }
    }
}