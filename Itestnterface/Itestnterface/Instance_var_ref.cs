using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itestnterface
{
    internal class Instance_var_ref
    {
        int x = 100;
        static void Main(string[] args)
        {
            Instance_var_ref f1; // f is variable here
            f1= new Instance_var_ref();// f is a instance here
            // var f2 = new Instance_var_ref();
            // var f3 = f2;
            Instance_var_ref f2 = f1;// reference of class
            Console.WriteLine(f2.x);
            // Console.WriteLine(f1.x);
            f1.x = 200;
            Console.WriteLine(f1.x+" "+ f2.x);
            f2.x = 300;
            Console.WriteLine(f1.x+" "+f2.x);
            Console.ReadLine();
        }
    }
}
