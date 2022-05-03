namespace Samples
{
    internal class Book
    {

        public string Title { get; set; }
        public int Pages { get; set; }

        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
        }

        public override string ToString()
        {
            return "Title: " + Title + " with " + Pages + " pages";
        }
    }
}
