using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeConversion.Math;

namespace TypeConversion

{


    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = "1234";
            //int b = Convert.ToInt32(str);// external conversion using convert method
            //  Console.WriteLine(b);


            //int i = 1000;
            //byte b = (byte)i;
            //Console.WriteLine(b); // it loses data so don't use to covert a big datatype to small datatype
            /*
             * try
             {
                 var number = "1234";
                 byte b = Convert.ToByte(number);
                 Console.WriteLine(b);
             }
             catch (Exception)
             {
                 Console.WriteLine("The number could not be converted to a byte..");

             }
             */

            /*try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                throw;
            }*/
            /* byte number = 255;

            number += 2;

            Console.WriteLine(number);
            */

            // creating class and objects
            Person gourav = new Person();
            gourav.FirstName = "Gourav";
            gourav.LastName = "Shaw";
            gourav.Introduce();
            Calculator calculator = new Calculator();
            int result = calculator.add(4, 7);
            Console.WriteLine(result);


        }

    }
}
