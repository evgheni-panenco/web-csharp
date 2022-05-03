using Lab3LINQ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3LINQ.Service
{
    class DatabasePopulator
    {
        public List<Author> GetAuthorsList()
        {
            var authors = new List<Author>();

            authors.Add(GetLevTolstoy());
            authors.Add(GetTolkin());
            authors.Add(GetStevenKing());

            return authors;
        }

        private Author GetStevenKing()
        {
            var stevenKing = new Author();
            stevenKing.Id = Guid.NewGuid();
            stevenKing.FirstName = "Stephen";
            stevenKing.LastName = "King";
            stevenKing.BirthYear = 1947;

            var books = new List<Book>();
            books.Add(new Book(Guid.NewGuid(), "It", 1986, 1492, stevenKing, Genre.HORROR));
            books.Add(new Book(Guid.NewGuid(), "Carrie", 1974, 199, stevenKing, Genre.HORROR));
            stevenKing.Books = books;

            return stevenKing;
        }

        private Author GetLevTolstoy()
        {
            var levTolstoy = new Author();
            levTolstoy.Id = Guid.NewGuid();
            levTolstoy.FirstName = "Lev";
            levTolstoy.LastName = "Tolstoy";
            levTolstoy.BirthYear = 1828;

            var books = new List<Book>();
            books.Add(new Book(Guid.NewGuid(), "War and Peace", 1867, 1225, levTolstoy, Genre.NOVEL));
            books.Add(new Book(Guid.NewGuid(), "Anna Karenina", 1878, 864, levTolstoy, Genre.ROMANCE));
            books.Add(new Book(Guid.NewGuid(), "War and Peace", 1852, 358, levTolstoy, Genre.AUTOBIOGRAPHY));
            levTolstoy.Books = books;

            return levTolstoy;
        }

        private Author GetTolkin()
        {
            var tolkin = new Author();
            tolkin.Id = Guid.NewGuid();
            tolkin.FirstName = "John";
            tolkin.LastName = "Tolkien";
            tolkin.BirthYear = 1892;

            var books = new List<Book>();
            books.Add(new Book(Guid.NewGuid(), "The Lord of the Rings", 1955, 1325, tolkin, Genre.FANTASY));
            books.Add(new Book(Guid.NewGuid(), "The Father Christmas Letters", 1986, 258, tolkin, Genre.ACTION));
            tolkin.Books = books;

            return tolkin;
        }
    }
}
