using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_inheritance_practicing
{
    class UniversityMember
    {
        protected Guid id;
        protected string firstName;
        protected string lastName;
        protected short age;

        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }
        public Guid Id { get { return id; } }
    }
}
