using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudentJoiner
{
    class StudentManager
    {
        public string firstName;
        public string lastName;
        //it is allowed to have max 25 students involved in classes
        public static int maxNumberOfStudents = 25;
        
        public Student[] students = new Student[maxNumberOfStudents];
        //it is manadatory to identify student manager's first name, last name
        public StudentManager(string _firstName, string _lastName)
        {
            firstName = _firstName;
            lastName = _lastName;
        }
        //Student manager is allowed to add students
        public void AddStudents(int numberOfStudents)
        {
            Random random = new Random();
            Student newStudent;
            int allowedAmount = maxNumberOfStudents - GetActualNumberOfStudents();
            //check that the total number of students won't exceed the given limit
            if (numberOfStudents > allowedAmount)
            {
                if (allowedAmount > 0)
                {
                    numberOfStudents = allowedAmount;
                }
                else
                {
                    Console.WriteLine("The given number exceeds the limit of allowed students to be involved in classes. Try another number.");
                    return;
                }
            }
            for (int i = 0, j = 0 ; i < students.Length; i++, j++) {
                while(students[j] == null && numberOfStudents > 0)
                {
                    newStudent = new Student("#S" + random.Next(11).ToString(), "FirstName" + j, "LastName" + j);
                    students[i] = newStudent;
                    numberOfStudents--;
                    break;
                }
                
            }

        }

        public void RemoveStudent(string id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].id == id)
                {
                    students[i] = null;
                }
            }
        }

        public int GetActualNumberOfStudents()
        {
            int count = 0;
            for(int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                    count++;
            }
            return count;
        }

        public void Print()
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    Console.Write(students[i].id + ": " + students[i].firstName + " " + students[i].lastName);
                    Console.WriteLine();
                }            
            }
        }
        //privide the list of students
        public Student[] GetStudentsList()
        {
            return students;
        }
    }
}
