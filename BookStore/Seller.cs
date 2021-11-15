using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Seller : Customer
    {
        public Seller(string firstName, string lastName) : base(firstName, lastName)
        {

        }
        //duplicate the discount amount for bookstore sellers only
        public override void PayForBook(Book book)
        {
            if (Discount.DiscountAmnt < 30)
            {
                book.Price = Discount.CalculateSellPrice(book.Price);
            }
            base.PayForBook(book);
        }

        public void SellBook()
        {

        }
    }
}
