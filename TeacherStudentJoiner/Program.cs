using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudentJoiner
{
    class Program
    {
        static void Main(string[] args)
        {
            TeacherManager teacherManager = new TeacherManager("James", "Brown");
            Console.WriteLine("-----James Brown-----");
            teacherManager.AddTeachers(11);
            teacherManager.Print();
            Console.WriteLine(new string('-', 30));

            StudentManager studentManager = new StudentManager("Dennis", "Rodman");
            Console.WriteLine("-----Dennis Rodman-----");
            studentManager.AddStudents(19);
            studentManager.Print();
            Console.WriteLine(new string('-', 30));

            Teacher[] teachers = teacherManager.GetTeachersList();
            Student[] students = studentManager.GetStudentsList();

            UniversityManager uniManager = new UniversityManager("Uni", "Manager", teachers, students);
            uniManager.JoinTeacherToStudent();

            for (int i = 0; i < teachers.Length; i++)
            {
                for (int j = 0; j < students.Length; j++)
                {
                    Console.WriteLine("teacher - " + i + ": student" + j);
                }
            }

            /*
            teacherManager.AddTeachers(2);
            teacherManager.Print();
            Console.WriteLine(new string('-', 30));
            teacherManager.RemoveTeacher("Teacher_FName1");
            teacherManager.Print();
            Console.WriteLine(new string('-', 30));
            teacherManager.AddTeachers(2);
            teacherManager.Print();
            Console.WriteLine(new string('-', 30));
            */

            /*
            StudentManager studentManager = new StudentManager("Dennis", "Rodman");
            Console.WriteLine("-----Dennis Rodman-----");
            studentManager.AddStudents(1);
            studentManager.Print();
            Console.WriteLine(new string('-', 30));
            studentManager.AddStudents(4);
            studentManager.Print();
            Console.WriteLine(new string('-', 30));
            studentManager.AddStudents(2);
            studentManager.Print();
            Console.WriteLine(new string('-', 30));
            StudentManager studentManager1= new StudentManager("Michael", "Jordan");
            Console.WriteLine("-----Michael Jordan-----");
            studentManager.AddStudents(14);
            studentManager.Print();
            Console.WriteLine(new string('-', 30));
            studentManager.AddStudents(14);
            studentManager.Print();
            Console.WriteLine(new string('-', 30));
            studentManager.AddStudents(1);
            studentManager.Print();
            Console.WriteLine(new string('-', 30)); 
            */

            Console.ReadKey();
        }
    }
}
