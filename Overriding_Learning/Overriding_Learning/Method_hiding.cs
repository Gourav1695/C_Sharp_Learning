using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Learning
{
    class Method_hiding
    {
        public virtual void Test1()
        {
            Console.WriteLine("method test1 from parent class.");
        }
        public void Test2()
        {
            Console.WriteLine("Method test2 from parent class.");
        }
    }
    class ChildClass : Method_hiding
    {
        public override void Test1() // Method Overriding
        {
            Console.WriteLine("Method Test1 from child class.");
        }
        public new void Test2() // Method Hiding /Shadowing
        {
            Console.WriteLine("Method test2 from child class.");
        }
        public void ParentTest1()
        {
            base.Test1();
        }
        public void ParentTest2()
        {
            base.Test2();
        }
        static void Main(string[] args)
        {
            //**   Method_hiding p = new Method_hiding(); // here calling parent class using creating object of the parent class.
            p.Test1();
            p.Test2();

            ChildClass childClass = new ChildClass();
            childClass.ParentTest1();// 2nd way of calling parent method using base method
            childClass.ParentTest2();
            childClass.Test1();
            childClass.Test2();
            Console.ReadLine();


            ChildClass c = new
                ChildClass();
            Method_hiding p = c; // P is a reference of parent class created by using child's class
            p.Test1();
            p.Test2();
            Console.ReadLine();
        }
    }
}
