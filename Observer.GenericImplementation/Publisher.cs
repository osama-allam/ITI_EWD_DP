using System;
using System.Collections.Generic;
using System.Threading;

namespace Observer.GenericImplementation
{
    public class Publisher : IPublisher
    {
        // For the sake of simplicity, the Publisher's state, essential to all
        // subscribers, is stored in this variable.
        public int State { get; set; } = -0;

        // List of subscribers. In real life, the list of subscribers can be
        // stored more comprehensively (categorized by event type, etc.).
        private List<ISubscriber> _observers = new List<ISubscriber>();

        // The subscription management methods.
        public void Subscribe(ISubscriber observer)
        {
            Console.WriteLine("Publisher: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Unsubscribe(ISubscriber observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Publisher: Detached an observer.");
        }

        // Trigger an update in each subscriber.
        public void Notify()
        {
            Console.WriteLine("Publisher: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        // Usually, the subscription logic is only a fraction of what a Publisher
        // can really do. Publishers commonly hold some important business logic,
        // that triggers a notification method whenever something important is
        // about to happen (or after it).
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nPublisher: I'm doing something important.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(2000);

            Console.WriteLine("Publisher: My state has just changed to: " + this.State);
            this.Notify();
        }
    }
}