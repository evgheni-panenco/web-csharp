using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples
{
    class ExamplesForReferat
    {
        private static Book b1 = new Book("Amazin Story", 2236);
        private static Book b2 = new Book("Great Adventure", 1234);
        private static Book b3 = new Book("Unseen World", 3235);

        public static void Main()
        {
            /** CONCACT */
            /*var l1 = new List<Book>() { b1, b2 };
            var l2 = new List<Book>() { b3 };
            Console.WriteLine("l1: " + ArrayStringResult(l1));
            Console.WriteLine("l2: " + ArrayStringResult(l2));
            var l3 = l1.Concat(l2);
            Console.WriteLine("l3: " + ArrayStringResult(l3));*/

            /** MinBy **/
            /*var bookList = new List<Book>() { b1, b2, b3 };
            Console.WriteLine("Initial list: " + ArrayStringResult(bookList));
            Console.WriteLine("Minimum by pages number: " 
                + bookList.MinBy(book => book.Pages));*/

            /** Sum with numbers **/
            /*var decimals = new List<Decimal>() { 123, 321, 345 };
            var doubles = new List<Double>() { 1.2, 2.4, 3.5 };
            var int32s = new List<Int32>() { 1, 2, 3 };
            var int64s = new List<Int64>() { 10, 11, 13 };
            var singles = new List<Nullable<Single>>() { .2f, .1f, .4f };

            Console.WriteLine("Sum of decimals: " + ArrayStringResult(decimals) + " equals " + decimals.Sum());
            Console.WriteLine("Sum of doubles: " + ArrayStringResult(doubles) + " equals " + doubles.Sum());
            Console.WriteLine("Sum of int32s: " + ArrayStringResult(int32s) + " equals " + int32s.Sum());
            Console.WriteLine("Sum of int64s: " + ArrayStringResult(int64s) + " equals " + int64s.Sum());
            Console.WriteLine("Sum of nullable singles: " + ArrayStringResult(singles) + " equals " + singles.Sum());*/

            /** Sum with nullable numbers **/
            /*var decimals = new List<Nullable<Decimal>>() { 123, null, 345 };
            var doubles = new List<Nullable<Double>>() { 1.2, 2.4, null };
            var int32s = new List<Nullable<Int32>>() { null, 2, null, 4 };
            var int64s = new List<Nullable<Int64>>() { 10, null, 13 };
            var singles = new List<Nullable<Single>>() { .2f, null, .4f };

            Console.WriteLine("Sum of nullable decimals: " + ArrayStringResult(decimals) + " equals " + decimals.Sum());
            Console.WriteLine("Sum of nullable doubles: " + ArrayStringResult(doubles) + " equals " + doubles.Sum());
            Console.WriteLine("Sum of nullable int32s: " + ArrayStringResult(int32s) + " equals " + int32s.Sum());
            Console.WriteLine("Sum of nullable int64s: " + ArrayStringResult(int64s) + " equals " + int64s.Sum());
            Console.WriteLine("Sum of nullable singles: " + ArrayStringResult(singles) + " equals " + singles.Sum());*/
        }

        private static string ArrayStringResult<T>(IEnumerable<T> arr)
        {
            return string.Join(", ", arr.Select(v => v?.ToString()));
        }
    }
}
