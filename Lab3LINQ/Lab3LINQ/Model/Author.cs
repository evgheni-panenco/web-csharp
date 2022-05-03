using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3LINQ.Model
{
    public class Author
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public List<Book> Books { get; set; }

        public override string? ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
