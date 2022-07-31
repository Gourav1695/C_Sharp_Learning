using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Greet(string name)
        {
            Console.WriteLine("Good Morning" + name);
        }
        static float Average(int a, int b, int c)
        {
            float sum = a+ b + c;
            return sum/3;
        }
        static void Main(string[] args)
        {

            //  Commnet example -> This is important for debugging do not remove
            /*
             this is 
              multiline 
              comment example
             */
            // int harry = 34;// Integer varible
            /*
             * datatypes in c#
             * integer - int harry;-->4 Bytes
             * floating point number - float that;-->4 bytes
             * Double - double harry ; --> 8 bytes
             * Character - char a='A';-->2Bytes
             * Boolean - bool isGreat = true;-->1 bit
             * Long- long harry; --> 8 Bytes
             * string inp = "Harry";-->2 Bytes per character
             * 
             */

            //  Console.WriteLine("Hello world");
            // Console.Write("Hello gourav");
            // Console.WriteLine("Yo and the number"+ harry);
            // string inp = Console.ReadLine();
            // Console.WriteLine(inp);
            // int a = 34;
            // double c = 34.56D;
            // bool isGreat = true;  
            // string e = " this is a string ";
            // Console.WriteLine(isGreat);
            // float b = 34.45F;// c sharp is a type safe language
            // Console.WriteLine(a );
            // Console.WriteLine(b);
            // Console.WriteLine(c);
            // Console.WriteLine(e);

            // Type casting
            // there are two types of casting 
            //    1. Implicit casting 
            // char to int  to long to float to double
            //    2. Explicit casting

            //  int x = (int)3.5;
            //  double x1 = (double)3.5;
            //  int x = 3;
            //  string x2 = " 34 is amazing ";
            //  float ax1 = Con34.4;
            //  double y = x;
            //  int z = 'y';
            //  float varr= Convert.ToInt64(3.55);
            //  Convert.ToDoble
            //  Convert.ToDoubleTosstring;
            // onsole.WriteLine(x1);
            // Console.WriteLine(y);
            // Console.WriteLine(z);
            // Console.WriteLine(" Enter your name");
            // string name = Console.ReadLine();

            // Console .WriteLine("Hey Hello "+ name); 
            // Console.WriteLine(" How many candies do you want ??");
            // string can = Console.ReadLine();

            // Console .WriteLine("You will get 4 more candies : "+ 
            //    (Convert.ToInt32(can)+4));// given priority to bracket


            /*Operator in C#
            1. Arithmatic operators
            2. Logical operators
            3. Assignment Operators
            4. Comparison Operators
            */
            // int a = 4;
            // int b = 2;
            // Console.WriteLine("The value of a + b is :" + (a + b));
            // Console.WriteLine("The value of a - b is :" + (a - b));
            // Console.WriteLine("The value of a * b is :" + (a * b));
            // Console.WriteLine("The value of a / b is :" + (a / b));


            // Assignment Operators
            //int a = 4;
            //int b = a;
            // b += 4;
            // b -= 4;
            // b *= 4;
            //b /= 4;
            //Console.WriteLine(b);

            //Logical operators

            //Console.WriteLine(true &&  false);
            //Console.WriteLine(true &&  true);
            //Console.WriteLine(false &&  false);
            //Console.WriteLine(false &&  true);

            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);
            //Console.WriteLine(false || true);

            //Console.WriteLine(!false);
            //Console.WriteLine(!true);

            //comparison operators
            //Console.WriteLine(345>9);
            //Console.WriteLine(345<9);
            //Console.WriteLine(345>=9);
            //Console.WriteLine(345!=9);
            //Console.WriteLine(9==9);

            //int a = Math.Min(34, 345);
            // double a = Math.Sqrt(36);
            //Console.WriteLine(a);
            //  int b = Math.Abs(-39);
            //Console.WriteLine(b);

            //string hello = " Hello world this Gourav";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello + " good");
            //Console.WriteLine(string.Concat(hello , " good"));

            //string name = Console.ReadLine();
            //string candies= Console.ReadLine();
            ////string interpolation
            //Console.WriteLine($"Your name is {name}. You will get {candies} candies ");
            //string hello = "Hello world this  \" Gourav";
            //string hello = "Hello world this  \n Gourav";
            //Console.WriteLine(hello[1]);
            //Console.WriteLine(hello.IndexOf("is"));
            //Console.WriteLine(hello.Substring(5));


            //Console.WriteLine("Enter your age: ");
            //string ageStr= Console.ReadLine();
            //int age= Convert.ToInt32(ageStr);
            //bool isBanned = true;
            ////int age = 16;
            //if(age<2 && isBanned)//if else ladder
            //{
            //    Console.WriteLine("You are just born ");
            //}
            //else if( age<10 && isBanned)
            //{
            //    Console.WriteLine(" please finish your high school or you are ban");
            //}
            //else if ( age< 18 && isBanned)
            //{
            //    Console.WriteLine(" you are below 18");

            //}
            //else if ( age< 75 )
            //{
            //    Console.WriteLine(" You can drive");
            //}
            //else
            //{
            //    Console.WriteLine("You cannot drive");
            //}

            //int age = 20;
            //switch( age)
            //{
            //    case 18:
            //        Console.WriteLine("Please wait for an year");
            //        break;
            //    case 20:
            //        Console.WriteLine("You are 20");
            //          break ;
            //    default:
            //        Console.WriteLine("Enjoy");
            //        break;
            //}

            //loop
            //better alternative

            //int i= 0;
            //while (i < 90)
            //{
            //    Console.WriteLine(i+1);
            //    i++;
            //}

            //int j = 0;

            //do
            //{
            //    Console.WriteLine(j + 1);
            //    j++;
            //} while (j > 90);//this will run atleast one time

            // break and continue

            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i + 1);
            //    break;
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    if(i == 0) { continue; }

            //    Console.WriteLine(i + 1);

            //}
            //Break -> leave this loop forever
            //continue-> leave this particular iteration


            //Greet(" Gourav");
            //Greet(" Raja");
            //Console.WriteLine(Average(2, 6, 8));
            //float temp=Average(3,9, 0);
            //Console.WriteLine(Average(3,3,3));

            //OOPs - Classes and objects

            Player tommy = new Player();
            Console.WriteLine(tommy.getHealth());//access modifier
            tommy.setHealth(57);
            Console.WriteLine(tommy.getHealth());
            Console.ReadLine();

        }
    }
}
