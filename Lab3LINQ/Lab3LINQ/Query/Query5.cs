using Lab3LINQ.Model;
using Lab3LINQ.Service;

namespace Lab3LINQ.Query
{
    public class Query5 : IQuery<Author, string>
    {
        public List<string> ExecuteQuery(List<Author> authors)
        {
            var books = new Query1().ExecuteQuery(authors);
            return new List<string>{(from book in books
                    select book.PagesAmount).Average().ToString() };
        }

        public string QueryValue()
        {
            return "(from book in books\n" +
                   "select book.PagesAmount).Average()\n";
        }
    }
}
