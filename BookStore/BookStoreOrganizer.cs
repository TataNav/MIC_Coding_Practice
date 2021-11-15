using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class BookStoreOrganizer
    {
        BookStore bookStore = new BookStore();

        public void RemoveBookFromStore(Book book)
        {
            bookStore.Books.Remove(book);
        }

        public void AddBookToStore(Book book)
        {
            bookStore.Books.Add(book);
        }
    }
}
