using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Customer
    {
        private string firstName;
        public string FirstName { set
            {
                if(value != null)
                {
                    firstName = value;
                }
            }
        }
        private string lastName;
        public string LastName
        {
            set
            {
                if (value != null)
                {
                    lastName = value;
                }
            }
        }

        private Guid id;
        List<Book> library;
        protected BookStoreOrganizer bookStoreOrganizer;

        public Customer(string _firstName, string _lastName)
        {
            id = Guid.NewGuid();
            firstName = _firstName;
            lastName = _lastName;
            library = new List<Book>();
        }

        public virtual void PayForBook(Book book)
        {
            book.Price = Discount.CalculateSellPrice(book.Price);
            bookStoreOrganizer.RemoveBookFromStore(book);
            AddBookToLibrary(book);
        }

        public void AddBookToLibrary(Book book)
        {
            library.Add(book);
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
    }
}
