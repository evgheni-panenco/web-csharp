using Lab3LINQ.Model;
using Lab3LINQ.Service;

namespace Lab3LINQ.Query
{
    public class Query7 : IQuery<Author, Book>
    {
        public List<Book> ExecuteQuery(List<Author> authors)
        {
            var books = new Query1().ExecuteQuery(authors);
            return (from book in books
                   where book.Genre == Genre.HORROR
                   select book).ToList();
        }

        public string QueryValue()
        {
            return "from book in books\n" +
                   "where book.Genre == Genre.HORROR\n" +
                   "select book";
        }
    }
}
