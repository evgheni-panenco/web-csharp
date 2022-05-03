using Lab3LINQ.Model;
using Lab3LINQ.Service;

namespace Lab3LINQ.Query
{
    public class Query3 : IQuery<Author, Book>
    {
        public List<Book> ExecuteQuery(List<Author> authors)
        {
            var books = new Query1().ExecuteQuery(authors);
            return (from book in books
                   where book.PagesAmount > 1000
                   select book).ToList();
        }

        public string QueryValue()
        {
            return "from book in author.Books\n" +
                   "where book.PagesAmount > 1000\n" +
                   "select book";
        }
    }
}
