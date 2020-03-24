namespace ChainOfResponsibility.GenericImplementation
{
    class SecondHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Second Request")
            {
                return $"Second Handler: I'll handle the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}