using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public static class Discount
    {
        private static double dicountAmnt = 5;
        public static double DiscountAmnt { get { return dicountAmnt; } set {
                if (value > 0 && value < 70) {
                    dicountAmnt = value;
                }
            }
        }

        public static double CalculateSellPrice(double price)
        {
            return price * dicountAmnt / 100;
        }
    }
}
