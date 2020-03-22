namespace Observer.GenericImplementation
{
    public interface ISubscriber
    {
        // Receive update from subject
        void Update(IPublisher publisher);
    }
}