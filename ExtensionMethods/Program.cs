using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class ExtensionClass
    {
        //Extension method must be in a static class, therefore it isa statis method
        public static void ExtensionMethod(this string value, string value1)// value here is the argument of the extension, the extension argument should be the first in line
        {
            Console.WriteLine(value + value1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = "This is for ";

            ExtensionClass.ExtensionMethod(text, "testing"); //same as line 26

            text.ExtensionMethod("testing");

            Console.ReadKey();
        }
    }
}
