using System;

namespace Observer.GenericImplementation
{
    class ConcreteSubscriberA : ISubscriber
    {
        public void Update(IPublisher subject)
        {
            if (((Publisher) subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}