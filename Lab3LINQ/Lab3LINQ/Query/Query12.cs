using Lab3LINQ.Model;
using Lab3LINQ.Service;

namespace Lab3LINQ.Query
{
    public class Query12 : IQuery<Author, Book>
    {
        public List<Book> ExecuteQuery(List<Author> authors)
        {
            var books = new Query1().ExecuteQuery(authors);

            return (from book in books
                   where book.publicationYear >= 1900
                   select book)
                   .Except(
                    from book in books
                    where book.Genre == Genre.ACTION
                    select book)
                   .ToList();
        }

        public string QueryValue()
        {
            return "(from book in books\n" +
                   "where book.publicationYear >= 1900\n" +
                   "select book)\n" +
                   ".Except(\n" +
                   "from book in books\n" +
                   "where book.Genre == Genre.ACTION\n" +
                   "select book)\n";
        }
    }
}
