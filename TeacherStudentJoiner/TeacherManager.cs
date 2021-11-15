using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudentJoiner
{
    class TeacherManager
    {
        public string firstName;
        public string lastName;
        //it is allowed to have max 5 teachers involved in classes
        public static int maxNumberOfSTeachers = 5;
        public Teacher[] teachers = new Teacher[maxNumberOfSTeachers];
        //it is manadatory to identify teacher manager's first name, last name
        public TeacherManager(string _firstName, string _lastName)
        {
            firstName = _firstName;
            lastName = _lastName;
        }
        //add teacher
        public void AddTeachers(int numberOfTeachers)
        {
            Random random = new Random();
            Teacher newTeacher;
            int allowedAmount = maxNumberOfSTeachers - GetActualNumberOfTeachers();
            //check that the total number of students won't exceed the given limit
            if (numberOfTeachers > allowedAmount)
            {
                if (allowedAmount > 0)
                {
                    numberOfTeachers = allowedAmount;
                }
                else
                {
                    Console.WriteLine("The given number exceeds the limit of allowed teachers in the university. Try another number.");
                    return;
                }
            }
            for (int i = 0, j = 0; i < teachers.Length; i++, j++)
            {
                while (teachers[j] == null && numberOfTeachers > 0)
                {
                    newTeacher = new Teacher("#T" + random.Next(11).ToString(), "Teacher_FName" + j, "Teacher_LName" + j);
                    teachers[i] = newTeacher;
                    numberOfTeachers--;
                    break;
                }

            }

        }
        //remove teacher
        public void RemoveTeacher(string teacherName)
        {
            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i].firstName.Equals(teacherName))
                {
                    teachers[i] = null;
                }
            }
        }
        //provide the list of teachers
        public int GetActualNumberOfTeachers()
        {
            int count = 0;
            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i] != null)
                    count++;
            }
            return count;
        }
        //print teacher
        public void Print()
        {
            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i] != null)
                {
                    Console.Write(teachers[i].id + ": " + teachers[i].firstName + " " + teachers[i].lastName);
                    Console.WriteLine();
                }
            }
        }
        //privide the list of teachers
        public Teacher[] GetTeachersList()
        {
            return teachers;
        }
    }
}
