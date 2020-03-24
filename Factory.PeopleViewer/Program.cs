using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Factory;
using PersonRepository.Interface;

namespace Factory.PeopleViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int input = 0;
                do
                {
                    var repositoryType = GetUserInput();
                    IPersonRepository repository = RepositoryFactory.GetRepository(repositoryType);
                    var peopleList = GetPeople(repository);
                    PrintList(peopleList, repository);
                    int.TryParse(repositoryType, out input);
                } while (input <= 3);
            }
            catch (Exception e)
            {
                // ignored
            }
        }

        static List<Person> GetPeople(IPersonRepository repository)
        {
            List<Person> peopleList = new List<Person>();
            var people = repository.GetPeople();
            foreach (var person in people)
                peopleList.Add(person);
            return peopleList;
        }
        static string GetUserInput()
        {
            
            Console.WriteLine("Choose repository type:");
            Console.WriteLine("1. CSV");
            Console.WriteLine("2. SQL");
            Console.WriteLine("3. Service");
            var input = Console.ReadKey().Key;
            var repositoryType = string.Empty;
            Console.WriteLine();
            switch (input)
            {
                case ConsoleKey.D1:
                    repositoryType = "CSV";
                    break;
                case ConsoleKey.D2:
                    repositoryType = "SQL";
                    break;
                case ConsoleKey.D3:
                    repositoryType = "Service";
                    break;
            }

            return repositoryType;
        }
        
        static void ShowRepositoryType(IPersonRepository repository)
        {
            Console.WriteLine($"----------Repository Type:{repository.GetType().ToString()}----------");
        }
        static void PrintList(List<Person> peopleList, IPersonRepository repository)
        {
            ShowRepositoryType(repository);
            foreach (var person in peopleList)
            {
                Console.WriteLine($"FirstName: {person.FirstName}");
                Console.WriteLine($"LastName: {person.LastName}");
                Console.WriteLine($"Rating: {person.Rating}");
                Console.WriteLine($"StartDate: {person.StartDate}");
            }

            Console.WriteLine("===============================================");
        }
    }
}
