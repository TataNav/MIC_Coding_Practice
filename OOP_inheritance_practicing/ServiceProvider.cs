using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_inheritance_practicing
{
    class ServiceProvider : UniversityMember
    {
        protected List<Object> objects;

        public ServiceProvider(string _fName, string _lName)
        {
            firstName = _fName;
            lastName = _lName;
        }

        public void Add(Object obj)
        {
            objects.Add(obj);
        }

        public void Delete(Object obj)
        {
            objects.Remove(obj);
        }

        public void Read()
        {
            for (int i = 0; i < objects.Count; i++)
            {
                Console.WriteLine(objects[i].ToString());
            }
        }
    }
}
