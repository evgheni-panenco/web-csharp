using Lab3LINQ.Model;
using Lab3LINQ.Service;

namespace Lab3LINQ.Query
{
    public class Query4 : IQuery<Author, Book>
    {
        public List<Book> ExecuteQuery(List<Author> authors)
        {
            var books = new Query1().ExecuteQuery(authors);
            return (from book in books
                    where book.PagesAmount == books.Max(b => b.PagesAmount)
                    select book).ToList();
        }

        public string QueryValue()
        {
            return "from book in books\n" +
                   "where book.PagesAmount == books.Max(b => b.PagesAmount)\n" +
                   "select book";
        }
    }
}
