namespace Observer.GenericImplementation
{
    // The Subject owns some important state and notifies observers when the
    // state changes.

    // Concrete Observers react to the updates issued by the Subject they had
    // been attached to.

    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var publisher = new Publisher();
            var subscriberA = new ConcreteSubscriberA();
            publisher.Subscribe(subscriberA);

            var observerB = new ConcreteSubscriberB();
            publisher.Subscribe(observerB);

            publisher.SomeBusinessLogic();
            publisher.SomeBusinessLogic();

            publisher.Unsubscribe(observerB);

            publisher.SomeBusinessLogic();
        }
    }
}