using LinqWithLamba.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkWithLamba.Tests
{
    public class TestSelectMany : ITest
    {
        public void Test()
        {
            var persons = new List<Person>();

            persons.Add(new Person
            {
                Id = 1,
                Nome = "Jonh",
                PersonPhones = new List<PersonPhone>() { new PersonPhone { PhoneNumber = "123456" }, new PersonPhone { PhoneNumber = "654321" } }

            });
            persons.Add(new Person
            {
                Id = 2,
                Nome = "Mary",
                PersonPhones = new List<PersonPhone>() { new PersonPhone { PhoneNumber = "456456" }, new PersonPhone { PhoneNumber = "654654" } }
            });

            var personPhones = persons.Select(person => person.PersonPhones);

            foreach(var personPhone in personPhones)
            {
                foreach(var phone in personPhone)
                {
                    Console.WriteLine("Using Select: " + phone.PhoneNumber);
                }
            }
        }

        class Person
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public List<PersonPhone> PersonPhones { get; set; }
        }

        class PersonPhone
        {
            public string PhoneNumber { get; set; }
        }
    }
}
