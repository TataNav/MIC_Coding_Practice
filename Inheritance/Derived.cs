using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Derived : Base
    {
        public string derivedField = "dervied class field";
        public Derived(string forBase, string forDerived) : base (forBase)
        {
            derivedField = forDerived;
        }
    }
}
