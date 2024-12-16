using Portfolio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Test.Tests
{
    public class PersonTest
    {
        [Fact]
        public void GetPerson_RetornaDados()
        {
            Person Person = new Person();
            Person = Person.GetPerson(File.ReadAllText(@"C:\Users\bruno\source\repos\Portfolio\Portfolio\Infrastructure\Repositories\person.json"));
            Assert.IsType<Person>(Person);
        }

        [Fact]
        public void GetExperience_RetornaNull()
        {
            Person Person = new Person();
            Person = Person.GetPerson("");
            Assert.Null(Person);
        }
    }
}
