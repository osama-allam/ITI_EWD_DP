namespace ChainOfResponsibility.GenericImplementation
{
    class ThirdHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Third Request")
            {
                return $"Third Request: I'll handle the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}