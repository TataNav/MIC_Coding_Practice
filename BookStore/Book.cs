using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Book
    {
        //private static int quantity;
        //public int Qunatity { get{ return quantity; } }
        private Guid id;
        public Guid Id { get { return id; } }
        private string title;
        public string Title { get { return title; } set { title = value; }}
        private string author;
        public string Author { get { return Author; } set { author = value; } }
        private string genre;
        public string Genre { get { return genre; } set { genre = value; } }
        private int pages;
        public int Pages
        {
            get { return pages; }
            set
            {
                if (value > 0 && value < 1500)
                {
                    pages = value;
                }
            }
        }
        private double price;
        public double Price { get { return price; } set {
                if (value > 0)
                {
                    price = value;
                }
            } 
        }
        private int edition;
        public int Edition
        {
            get { return edition; }
            set
            {
                if (value > 0)
                {
                    edition = value;
                }
            }
        }

        private bool discountedBook;
        public bool DiscountedBook
        {
            set
            {
                if (value)
                {
                    discountedBook = value;
                }
            }
        }

        public Book(string _title, string _author, string _genre, double _price)
        {
            id = Guid.NewGuid();
            title = _title;
            author = _author;
            genre = _genre;
            price = _price;
            quantity++;
        }
    }
}
