using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_implementation
{
    internal class AbsChild: AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x*y);
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x/y);
        }
        static void Main(string[] args)
        {
            AbsChild child = new AbsChild();// incitiasing child object 
            // AbsParent parent = new AbsParent(); 
            AbsParent p = child;// creating reference to the child clas
            p.add(120 , 20);
            child.sub(290 ,10);
            child.Mul(22, 6);
            child.Div(33, 9);
            Console.ReadLine();
        }
    }
}
