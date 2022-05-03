using Lab3LINQ.Model;
using Lab3LINQ.Service;

namespace Lab3LINQ.Query
{
    public class Query6 : IQuery<Author, Book>
    {
        public List<Book> ExecuteQuery(List<Author> authors)
        {
            var books = new Query1().ExecuteQuery(authors);
            return books.OrderBy(b => b.publicationYear)
                .ThenBy(b => b.PagesAmount)
                .ToList();
        }

        public string QueryValue()
        {
            return "books.OrderBy(b => b.publicationYear)\n" +
                   "\t.ThenBy(b => b.PagesAmount)\n" +
                   "\t.ToList()";
        }
    }
}
