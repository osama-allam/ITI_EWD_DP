namespace ChainOfResponsibility.GenericImplementation
{
    class FirstHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "First Request")
            {
                return $"First Handler: I'll handle the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}