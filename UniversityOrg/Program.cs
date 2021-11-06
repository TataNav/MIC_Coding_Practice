using System;
using System.Collections.Generic;
using UniversityOrg.Models;
using UniversityOrg.Services;

namespace UniversityOrg
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student;
            Teacher teacher;
            List<Student> students;
            List<Teacher> teachers;
            StudentService studentManager = new StudentService();
            TeacherService teacherManager = new TeacherService();
            //add students
            int i = 0;
            while(i < 5)
            {
                student = new Student();
                studentManager.Add(student);
                i++;
            }
            i = 0;
            //add teachers
            while (i < 3)
            {
                teacher = new Teacher();
                teacherManager.Add(teacher);
                i++;
            }
            UniversityService uniManager = new UniversityService(studentManager, teacherManager);
            //join students to teachers
            students = studentManager.GetAll();
            teachers = teacherManager.GetAll();
            uniManager.Swap(students, teachers);
            //print combined students and teachers
            for (int j = 0; j < teachers.Count; j++)
            {
                for (int k = 0; k < teachers[j]._students.Count; k++)
                {
                    Console.WriteLine(teachers[j]._id + ": teacher,  " + teachers[j]._students[k]._id + ": student");
                }
            }
        }
    }
}
