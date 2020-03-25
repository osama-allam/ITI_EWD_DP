namespace Builder.FluentBuilder
{
    class Person
    {
        //Address Info
        public string StreetAddress, PostalCode;

        //Job info
        public string CompanyName, Position;
        public int Salary;

        public override string ToString()
        {
            return $"StreetAddress: {StreetAddress}, PostalCode: {PostalCode}\n, " +
                   $"CompanyName:{CompanyName}, Position:{Position}, Salary:{Salary}";
        }
    }
}