namespace Builder.FluentBuilder
{
    class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            this.person = person;
        }
        public PersonAddressBuilder Street(string streetAddress)
        {
            person.StreetAddress = streetAddress;
            return this;
        }
        public PersonAddressBuilder Postal(string postalCode)
        {
            person.PostalCode = postalCode;
            return this;
        }
    }
}