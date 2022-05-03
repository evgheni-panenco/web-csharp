using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples
{
    class ExamplesForReferat
    {
        private static Book b1 = new Book("Amazin Story", 1234);
        private static Book b2 = new Book("Great Adventure", 1234);
        private static Book b3 = new Book("Unseen World", 1234);

        public static void Main()
        {
            /** CONCACT */
            var l1 = new List<Book>() { b1, b2 };
            var l2 = new List<Book>() { b3 };
            Console.WriteLine("l1: " + ArrayStringResult(l1));
            Console.WriteLine("l2: " + ArrayStringResult(l2));
            var l3 = l1.Concat(l2);
            Console.WriteLine("l3: " + ArrayStringResult(l3));

        }

        private static string ArrayStringResult<T>(IEnumerable<T> arr)
        {
            return string.Join(", ", arr.Select(v => v.ToString()));
        }
    }
}
