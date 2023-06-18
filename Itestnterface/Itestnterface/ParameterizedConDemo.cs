using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itestnterface
{
    internal class ParameterizedConDemo
    {
        int x = 2;
        public ParameterizedConDemo(int i) // parameterized constructor
        {
            x = i;
            Console.WriteLine("Parameterized Constructor is called:" + i);
        }
        public void Display()
        {
            Console.WriteLine("Value of x is: " + x);
        }
        static void Main(string[] args)
        {
            ParameterizedConDemo cd1 = new ParameterizedConDemo(10);// creating instance of the parametrized constructor
            ParameterizedConDemo cd2 = new ParameterizedConDemo(20);

            cd1.Display();
            cd2.Display();
            Console.ReadLine();
        }
    }
}
