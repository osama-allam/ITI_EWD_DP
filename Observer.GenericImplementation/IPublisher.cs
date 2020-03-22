namespace Observer.GenericImplementation
{
    public interface IPublisher
    {
        // Subscribe an observer to the subject.
        void Subscribe(ISubscriber observer);

        // Unsubscribe an observer from the subject.
        void Unsubscribe(ISubscriber observer);

        // Notify all observers about an event.
        void Notify();
    }
}