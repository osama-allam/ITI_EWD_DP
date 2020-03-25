namespace Builder.FluentBuilder
{
    class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.person = person;
        }

        public PersonJobBuilder IsA(string position)
        {
            this.person.Position = position;
            return this;
        }

        public PersonJobBuilder InA(string companyName)
        {
            person.CompanyName = companyName;
            return this;
        }

        public PersonJobBuilder Earning(int salary)
        {
            person.Salary = salary;
            return this;
        }
    }
}