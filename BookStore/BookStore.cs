using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class BookStore
    {
        List<Customer> customers;
        public List<Customer> Customers { get { return customers; } }
        List<Seller> sellers;
        public List<Seller> Sellers { get { return sellers; } }
        List<Book> books;
        public List<Book> Books { get { return books; } }

        public BookStore()
        {
            customers = new List<Customer>();
            sellers = new List<Seller>();
            books = new List<Book>();
        }

    }
}
