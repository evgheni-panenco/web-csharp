using Lab3LINQ.Model;
using Lab3LINQ.Service;

namespace Lab3LINQ.Query
{
    public class Query10 : IQuery<Author, Book>
    {
        public List<Book> ExecuteQuery(List<Author> authors)
        {
            var youngestId = from a in authors
                             where a.BirthYear == authors.Min(a => a.BirthYear)
                             select a.Id;

            var books = new Query1().ExecuteQuery(authors);
            return (from book in books
                    join author in (from a in authors
                                    where a.BirthYear == authors.Min(a => a.BirthYear)
                                    select a) 
                                    on book.BookAuthor.Id equals author.Id
                    select book).ToList();
        }

        public string QueryValue()
        {
            return "from book in books\n" +
                   "join author in (from a in authors\n" +
                   "where a.BirthYear == authors.Min(a => a.BirthYear)\n" +
                   "select a) \n" +
                   "on book.BookAuthor.Id equals author.Id\n" +
                   "select book";
        }
    }
}
