using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudentJoiner
{
    class UniversityManager
    {
        public string firstName;
        public string lastName;
        public Teacher[] teachers;
        public Student[] students;

        public UniversityManager(string _firstName, string _lastName, Teacher[] _teachers, Student[] _students)
        {
            firstName = _firstName;
            lastName = _lastName;
            teachers = _teachers;
            students = _students;
        }
        //Join students with teachers
        public void JoinTeacherToStudent()
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].teacher == null)
                {
                    for (int j = 0; j < teachers.Length; j++)
                    {
                        for (int k = 0; k < teachers[j].students.Length; k++)
                        {
                            if (teachers[j].students[k] == null)
                            {
                                students[i].teacher = teachers[j];
                                teachers[j].students[k] = students[i];
                            }
                        }
                    }
                }
            }
        }
    }
}
