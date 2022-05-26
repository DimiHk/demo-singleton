namespace demo_singleton.Services
{
    public class CounterService : ICounter
    {
        public Guid Id { get; private set; }

        public int CounterStorage { get; private set; }

        public CounterService()
        {
            Id = Guid.NewGuid();
        }

        public async Task<CounterService> GetCounterInstance() => this;

        public async Task<int> DecrementCounter() => CounterStorage -= new Random().Next(1, 10);

        public async Task<int> IncrementCounter() => CounterStorage += new Random().Next(1, 10);

        public async Task<bool> CompareInstances(CounterService service) => service.CounterStorage == CounterStorage;
    }
}