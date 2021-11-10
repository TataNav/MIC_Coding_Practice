using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_inheritance_practicing
{
    class Teacher : UniversityMember
    {
        List<Student> students;

        public List<Student> Students
        {
            get
            {
                return students;
            }
        }

        public short Age
        {
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Teacher's age should be greater than {0}. Set another value.", value);
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }

        public Teacher()
        {
            
        }

        public Teacher(string _fName, string _lName)
        {
            firstName = _fName;
            lastName = _lName;
            id = Guid.NewGuid();
        }
    }
}
