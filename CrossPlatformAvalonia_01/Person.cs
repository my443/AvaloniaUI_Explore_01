using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossPlatformAvalonia_01
{
    public class Person
    {
        public int Id { get; set; }
        public string PersonId { get; set; } = string.Empty;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name => $"{FirstName} {LastName}";

        public override string ToString()
        {
            return $"{Name} ({PersonId})";
        }
    }
}
