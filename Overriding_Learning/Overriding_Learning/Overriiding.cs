using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Learning
{
    public class LoadParent
    {
        public void Show()
        {
            Console.WriteLine("Parent's Show method is called.");
        }
        public virtual void Test() // override
        {
            Console.WriteLine("Parent's Test method is called.");
        }


    }
    class LoadChild : LoadParent
    {
        public void Show(int i)// overloading
        {
            Console.WriteLine("Child's show method is called.");
        }
        public override void Test()
        {
            Console.WriteLine("Child's test method is called.");
        }
        static void Main()
        {
            LoadChild c = new LoadChild();
            c.Show(10);
            c.Show(); c.Test();
            Console.ReadLine();
        }
    }
}
