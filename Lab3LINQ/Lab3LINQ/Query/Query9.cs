using Lab3LINQ.Model;
using Lab3LINQ.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3LINQ.Query
{
    public class Query9 : IQuery<Author, string>
    {
        public List<string> ExecuteQuery(List<Author> authors)
        {
            var books = new Query1().ExecuteQuery(authors);
            return new List<string> { 
                (from book in books
                 select book).Count().ToString() };
        }

        public string QueryValue()
        {
            return "(from book in books\n" +
                   "select book).Count()\n";
        }
    }
}
