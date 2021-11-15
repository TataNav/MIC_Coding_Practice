using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Base d1 = new Derived("base", "derived");
            Derived d2 = new Derived("base1", "derived2");
            Console.WriteLine(d1.publicField);
            d1.Show();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(d2.publicField);
            d2.Show();
        }
    }
}
