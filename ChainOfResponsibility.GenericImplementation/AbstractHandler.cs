namespace ChainOfResponsibility.GenericImplementation
{
    // The default chaining behavior can be implemented inside a base handler
    abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            
            // Returning a handler from here will let us link handlers in a
            // convenient way like this:
            // firstHandler.SetNext(secondHandler).SetNext(thirdHandler);
            return handler;
        }
        
        public virtual object Handle(object request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}