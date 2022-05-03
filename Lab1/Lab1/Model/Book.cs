using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int PagesAmount { get; set; }

        public Book(string title, int pagesAmount, CompareCriteria compareCriteria)
        {
            Title = title;
            PagesAmount = pagesAmount;
            CompareCriteria = compareCriteria;
        }

        public CompareCriteria CompareCriteria { get; set; }

        public int CompareTo(Book other)
        {
            if (other.CompareCriteria != this.CompareCriteria)
            {
                throw new ArgumentException("Cannot compare objects with different comparation");
            }

            switch (this.CompareCriteria)
            {
                case CompareCriteria.TITLE:
                    return this.Title.CompareTo(other.Title);
                case CompareCriteria.PAGES_AMOUNT:
                    return this.PagesAmount.CompareTo(other.PagesAmount);  
            }

            throw new ArgumentException("Invalid compare criteria");
        }

        public override string ToString()
        {
            return Title + " with " + PagesAmount + " pages";
        }
    }
}
