using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_test
{
    internal interface ITestInterface1
    {
        void Add(int a , int b);

    }
    interface ITestInterface2 :ITestInterface1
    {
        void Sub(int a, int b);
    }
    class ImplementationClass : ITestInterface2
    {
        //void ITestInterface1.Add(int a , int b) // 2nd way without using public
        public void Add(int a , int b) 
        {
            Console.WriteLine(a+b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }
        static void Main()
        {
            ImplementationClass obj= new ImplementationClass();
            ITestInterface2 i = obj;// we can create a parent reference using the child instance

            i.Sub(10,3);
            i.Add(20, 4);
        }
        
    }
}
