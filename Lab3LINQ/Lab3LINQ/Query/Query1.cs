using Lab3LINQ.Model;
using Lab3LINQ.Service;

namespace Lab3LINQ.Query
{
    public class Query1 : IQuery<Author, Book>
    {
        public List<Book> ExecuteQuery(List<Author> authors)
        {
            return (from author in authors
                   from book in author.Books
                   select book).ToList();
        }

        public string QueryValue()
        {
            return "from author in authors\n" +
                   "from book in author.Books\n" +
                   "select book";
        }
    }
}
