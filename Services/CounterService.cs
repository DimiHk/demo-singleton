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

        public CounterService GetCounterInstance() => this;

        public int DecrementCounter() => CounterStorage -= new Random().Next(1, 10);

        public int IncrementCounter() => CounterStorage += new Random().Next(1, 10);

        public bool CompareInstances(CounterService service) => service.CounterStorage == CounterStorage;
    }
}