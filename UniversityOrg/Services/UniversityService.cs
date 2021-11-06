using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityOrg.Models;
using UniversityOrg.Services;

namespace UniversityOrg.Services
{
    public class UniversityService
    {
        private StudentService _studentService;
        private TeacherService _teacherService;

        public UniversityService(StudentService studentService, TeacherService teacherService)
        {
            _teacherService = teacherService;
            _studentService = studentService;
        }
        
        public void Swap(List<Student> students, List<Teacher> teachers)
        {
            int j = 0;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i]._teacher == null)
                {
                    while (j < teachers.Count)
                    {
                        teachers[j]._students.Add(students[i]);
                        students[i]._teacher = teachers[j];
                        j++;
                        break;
                    }
                    if (j == teachers.Count && students.Count > 0)
                    {
                        j = 0;
                    }
                }
            }
        }
    }
}
