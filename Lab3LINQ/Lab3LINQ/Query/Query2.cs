using Lab3LINQ.Model;
using Lab3LINQ.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3LINQ.Query
{
    public class Query2 : IQuery<Author, Book>
    {
        public List<Book> ExecuteQuery(List<Author> authors)
        {
            var books = new Query1().ExecuteQuery(authors);
            return (from book in books
                   orderby book.publicationYear descending
                   select book).ToList();
        }

        public string QueryValue()
        {
            return "from book in books\n" +
                   "orderby book.publicationYear descending\n" +
                   "select book";
        }
    }
}
