using Lab3LINQ.Model;
using Lab3LINQ.Service;

namespace Lab3LINQ.Query
{
    public class Query13 : IQuery<Author, IGrouping<Genre, Book>>
    {
        public List<IGrouping<Genre, Book>> ExecuteQuery(List<Author> authors)
        {
            var books = new Query1().ExecuteQuery(authors);

            return new List<IGrouping<Genre, Book>>(
                from book in books
                group book by book.Genre
                );
        }

        public string QueryValue()
        {
            return "from book in books\n" +
                   "group book by book.Genre\n";
        }
    }
}
