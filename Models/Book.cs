using System;
using System.Collections.Generic;
using System.Text;

namespace ExamConsole.Models
{
    class Book
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Pages { get; set; }
        public string Publisher { get; set; }
        public decimal Price { get; set; }

        public Book()
        {

        }

        public Book(int id, int authorId, DateTime releaseDate, string title, string genre, int pages, string publisher, decimal price)
        {
            Id = id;
            AuthorId = authorId;
            ReleaseDate = releaseDate;
            Title = title;
            Genre = genre;
            Pages = pages;
            Publisher = publisher;
            Price = price;
        }

        public override string ToString()
        {
            return $"Id: {Id}, AuthorId: {AuthorId}, ReleaseDate: {ReleaseDate}, Title: {Title}, " +
                    $"Genre: {Genre}, Pages: {Pages}, Publisher: {Publisher}, Price: {Price} €";
        }
    }
}
