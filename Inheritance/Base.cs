using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Base
    {
        private string privateField = "BaseClass.privateField";
        protected string protectedField = "BaseClass.protectedField";
        public string publicField = "BaseClass.publicField";

        public Base(string text)
        {
            publicField = publicField + text;
        }

        public void Method()
        {
            Console.WriteLine("base class method");
        }

        public string StringConcate(string value) {
            return privateField + value;
        }

        public void Show()
        {
            Console.WriteLine(privateField);
        }
    }
}
