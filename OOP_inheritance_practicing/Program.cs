using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_inheritance_practicing
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentServiceProvider studentManager = new StudentServiceProvider("James", "Brown");

            int i = 0;

            while(i < 10)
            {
                studentManager.Add(new Student());
            }

            studentManager.Read
        }
    }
}
