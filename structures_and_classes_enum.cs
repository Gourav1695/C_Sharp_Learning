using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeConversion;
using TypeConversion.Math;

namespace TypeConversion

{
    public enum ShippingMethod
    {
        RegularAirMail=1,
        RegisteredAirMail =2,
        Express =3
    }

    internal class Program

    {
        static void Main(string[] args)
        {
            /* arrays representation and assingments
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;
            flags[1] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var str = new string[3] { "Gourav", "Sourav", "Rohan" };
            Console.WriteLine(str[0]);
            Console.WriteLine(str[1]);
            Console.WriteLine(str[2]);
*/
            /*

            //string
            var firstName = "Gourav";
            var lastName = "Shaw";
            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            //Console.WriteLine(myFullName);

            var names = new string[3] { "Gourav", "vikash", "sourav" };
            var formatedNames = string.Join(", ", names);
            Console.WriteLine(formatedNames);


            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:folder3\\folder4";
            var text1 = @"Hi John 
Look into the following paths
c:folder1\folder2
c:folder3\folder4";// this is verbatim string very useful for path writing
            Console.WriteLine(text1);
            */

            /*
                        // ENUMs use and applications

                        var method = ShippingMethod.Express;
                        Console.WriteLine((int)method);

                        var methodId = 3;
                        Console.WriteLine((ShippingMethod)methodId);


                        Console.WriteLine(method.ToString());

                            var methodName = "Express";
                        var shippingMethod= (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);*/

            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}",a , b));

            var array1 = new int[3] {1,2,3 };
            var array2 = array1;// copy by reference means address pointing both the arrays are same 
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]:{1}", array1[0], array2[0]));


        }

    }
}
