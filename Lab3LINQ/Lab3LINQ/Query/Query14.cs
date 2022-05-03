using Lab3LINQ.Model;
using Lab3LINQ.Service;

namespace Lab3LINQ.Query
{
    public class Query14 : IQuery<Author, IGrouping<Author, Book>>
    {
        public List<IGrouping<Author, Book>> ExecuteQuery(List<Author> authors)
        {
            var books = new Query1().ExecuteQuery(authors);

            return new List<IGrouping<Author, Book>>(
                from book in books
                let author = book.BookAuthor
                where !author.LastName.StartsWith('T')
                group book by author
                );
        }

        public string QueryValue()
        {
            return "from book in books\n" +
                   "let author = book.BookAuthor\n" +
                    "where !author.LastName.StartsWith('T')\n" +
                    "group book by author\n";
        }
    }
}
