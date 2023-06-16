namespace Imtihon29.Models
{
    public class Book
    {

        public string Name { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public double Price { get; set; }

        public int PageCount { get; set; }

        public int Code { get; set; }

        public string Ebout { get; set; } = string.Empty;

        public string ImagePath { get; set; }

        public Book(string name, string author, double price, int pageCount, int count, string imagePath)
        {
            Name = name;
            Author = author;
            Price = price;
            PageCount = pageCount;
            Code = count;
            ImagePath = imagePath;
        }
    }
}
