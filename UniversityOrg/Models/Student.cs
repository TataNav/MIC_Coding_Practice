using System;

namespace UniversityOrg.Models
{
    public class Student
    {
        public Guid _id;
        public string _name;
        public int _age;
        public Teacher _teacher;

        public Student()
        {
            _id = Guid.NewGuid();
        }

        public Student(string name,int age)
        {
            _id = new Guid();
            _name = name;
            _age = age;
        }
    }
}
