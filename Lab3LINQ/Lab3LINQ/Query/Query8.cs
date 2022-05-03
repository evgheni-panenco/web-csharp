using Lab3LINQ.Model;
using Lab3LINQ.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3LINQ.Query
{
    public class Query8 : IQuery<Author, Book>
    {
        public List<Book> ExecuteQuery(List<Author> authors)
        {
            var books = new Query1().ExecuteQuery(authors);
            return (from book in books
                    let author = book.BookAuthor
                    where author.BirthYear <= 1900
                        && author.LastName.StartsWith("T")
                    select book).ToList();
        }
        
        public string QueryValue()
        {
            return "from book in books\n" +
                   "let author = book.BookAuthor\n" +
                   "where author.BirthYear >= 1900\n" +
                   "\t&& author.LastName.StartsWith(\"T\")\n" +
                   "select book";
        }
    }
}
