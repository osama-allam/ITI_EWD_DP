using System;

namespace Observer.GenericImplementation
{
    class ConcreteSubscriberB : ISubscriber
    {
        public void Update(IPublisher subject)
        {
            if (((Publisher) subject).State == 0 || ((Publisher) subject).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}