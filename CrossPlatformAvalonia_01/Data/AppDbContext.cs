using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossPlatformAvalonia_01.Data
{
    public class AppDbContext
    {
        Person[] people = new Person[]
        {
            new Person { Id = 1, PersonId = "P001", FirstName = "John", LastName = "Doe" },
            new Person { Id = 2, PersonId = "P002", FirstName = "Jane", LastName = "Smith" },
            new Person { Id = 3, PersonId = "P003", FirstName = "Alice", LastName = "Johnson" }
        };
        public IEnumerable<Person> People => people;
    }


}
