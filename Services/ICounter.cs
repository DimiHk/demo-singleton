namespace demo_singleton.Services
{
    public interface ICounter
    {
        Task<CounterService> GetCounterInstance();

        Task<int> IncrementCounter();

        Task<int> DecrementCounter();

        Task<Boolean> CompareInstances(CounterService service);
    }
}