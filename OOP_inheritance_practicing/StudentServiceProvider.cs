using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_inheritance_practicing
{
    class StudentServiceProvider : ServiceProvider
    {
        List<Student> students = new List<Student>();

        public StudentServiceProvider(string _fName, string _lName): base(_fName, _lName)
        {
            firstName = _fName;
            lastName = _lName;
            id = Guid.NewGuid();
        }

        
    }
}
