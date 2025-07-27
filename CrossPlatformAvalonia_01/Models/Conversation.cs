using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossPlatformAvalonia_01.Models
{
    public class Conversation
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string Details { get; set; } = string.Empty;
        public int PersonId { get; set; } 
        public Person? Person { get; set; } 
        public override string ToString()
        {
            return $"{Title} \n {Details} (Created at: {CreatedAt}";
        }
    }
}
