using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_inheritance_practicing
{
    class Student : UniversityMember
    {
        private Teacher teacher;

        public Teacher Teacher
        {
            get
            {
                return teacher;
            }
            set
            {
                teacher = new Teacher();
            }
        }

        public short Age
        {
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Student's age should be greater than {0}. Set another value.", value);
                    age = 0; 
                }
                else
                {
                    age = value;
                }
            }
        }
        public Student()
        {
            id = Guid.NewGuid();
        }

        public Student(string _fName, string _lName)
        {
            firstName = _fName;
            lastName = _lName;
            id = Guid.NewGuid();
            teacher = new Teacher();
        }

    }
}
