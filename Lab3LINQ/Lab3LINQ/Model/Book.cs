using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3LINQ.Model
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int publicationYear { get; set; }
        public int PagesAmount { get; set; }
        public Author BookAuthor { get; set; }
        public Genre Genre { get; set; }

        public Book(Guid id, string title, int publicationYear, int pagesAmount, Author bookAuthor, Genre genre)
        {
            Id = id;
            Title = title;
            this.publicationYear = publicationYear;
            PagesAmount = pagesAmount;
            BookAuthor = bookAuthor;
            Genre = genre;
        }
    }
}
