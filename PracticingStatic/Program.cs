using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            NonStaticClass instance1 = new NonStaticClass(1);
            NonStaticClass instance2 = new NonStaticClass(2);

            //EXAMPLE - Singleton
            /*
            Singleton instance_1 = Singleton.Instance();
            Singleton instance_2 = Singleton.Instance();

            if (instance_1 == instance_2)
            {
                Console.WriteLine("The same address");
            }

            Console.WriteLine(instance_1.GetHashCode());
            Console.WriteLine(instance_2.GetHashCode());
            */

            //EXAMPLE
            //abstract class example having a static 
            /*
            AbstractClass insance = AbstractClass.CreateObject();
            insance.Method();
            */

            //EXAMPLE
            //usage of the static constructor
            //Console.WriteLine(NonStaticClass.ReadOnlyField);

            //EXAMPLE
            //shows how to access private static fields in non static class
            /*
            NonStaticClass.PrivateStaticField = 45;
            Console.WriteLine(NonStaticClass.PrivateStaticField);
            */
            //QUESTION
            /*
            instance1.PrivateStaticField = 25;
            Console.WriteLine(instance1.PrivateStaticField);
            instance2.PrivateStaticField = 205;
            Console.WriteLine(instance2.PrivateStaticField);
            Console.WriteLine(instance1.PrivateStaticField);
            */

            //EXAMPLE
            //shows that const can't be changed, const can't be static, cause it behaves as static 
            //NonStaticClass.p = 23.23; - unable to change the constant

            //EXAMPLE
            //shows that the static field can be used in a non-static method
            //before settup - get static field value through calling the non static method
            /*
            instance1.Method();
            instance2.Method();
            //refers to the static field of the NonStaticClass class-object
            NonStaticClass.field = 11;
            //after settup - get static field value through calling the non static method
            instance1.Method();
            instance2.Method();
            */

            Console.ReadKey();
        }
    }
    class NonStaticClass
    {
        private int id;
        public static int field;
        private static int privateStaticField;
        public const double p = 3.14;
        private static readonly long readOnlyField = 2;//readonly fields can be initialized either during the definition or through a constructor

        public static int PrivateStaticField
        {
            get { return NonStaticClass.privateStaticField; }
            set { privateStaticField = value; }
        }
        
        public static long ReadOnlyField
        {
            get { return NonStaticClass.readOnlyField; }
        }

        //static constructor which can't have both input parameter and access modifier
        //the role of the static constructor is to initialize static fields
        //user can't control the static constructor execution
        static NonStaticClass()
        {
            Console.WriteLine("Static constructor is working");
            readOnlyField = 1;
        }


        public NonStaticClass(int _id)
        {
            id = _id;
        }

        public void Method()
        {
            Console.WriteLine("Instance of {0}.field = {1}", id, field);
        }

        public static void StaticMethod()
        {
            Console.WriteLine("It is not allowed to refer to the non static field({0}) from the static method");
        }
    }
    abstract class AbstractClass
    {
        //static method
        public static AbstractClass CreateObject()
        {
            return new ConcreteClass();
        }

        public abstract void Method();
    }

    class ConcreteClass : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Hello World");
        }
    }

    class Singleton
    {
        private static Singleton instance = null;

        protected Singleton()
        {

        }

        public static Singleton Instance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
