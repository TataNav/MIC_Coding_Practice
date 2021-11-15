using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudentJoiner
{
    class Teacher
    {
        public string firstName;
        public string lastName;
        public string id;
        //each teacher is allowed to have multiple students
        public Student[] students = new Student[3];
        //it is manadatory to identify teacher's first name, last name and id during the creation
        public Teacher(string _id, string _firstName, string _lastName)
        {
            id = _id;
            firstName = _firstName;
            lastName = _lastName;
        }
    }
}
