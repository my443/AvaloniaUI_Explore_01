using CrossPlatformAvalonia_01.Models;
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

        Conversation[] conversations = new Conversation[]
        {
            new Conversation { Id = 1, Title = "First Conversation", Details =  "Hello How are you?" , PersonId = 1, CreatedAt = DateTime.Now },
            new Conversation { Id = 2, Title = "Second Conversation", Details = "Hi What's up?" , PersonId = 1, CreatedAt = DateTime.Now },
            new Conversation { Id = 3, Title = "Third Conversation", Details = "Greetings Good day!" , PersonId = 2, CreatedAt = DateTime.Now }
        };
        public IEnumerable<Conversation> Conversations => conversations;
    }


}
