using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudentJoiner
{
    class Student
    {
        public string firstName;
        public string lastName;
        public string id;
        public bool joined = false;
        //each student is allowed to have one teacher only
        public Teacher teacher = null;
        //it is manadatory to identify student's first name, last name and id during the creation
        public Student(string _id, string _firstName, string _lastName)
        {
            id = _id;
            firstName = _firstName;
            lastName = _lastName;
        }
    }
}
