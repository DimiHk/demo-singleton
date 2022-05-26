namespace demo_singleton.Services
{
    public interface ICounter
    {
        CounterService GetCounterInstance();

        int IncrementCounter();

        int DecrementCounter();

        Boolean CompareInstances(CounterService service);
    }
}