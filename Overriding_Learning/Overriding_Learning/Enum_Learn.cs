/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Learning
{
    public enum Days
    {
        Monday=1, Tuesday=66, Wednesday=9,Thursday=56, Friday=43
    }
    internal class Enum_Learn
    {
        public static Days MeetingDate { get; set; } = Days.Monday;
        public static void Main()
        {
            *//*            Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Hello World!");*//*

            // Days d = (Days)1;
           // Days d = Days.Tuesday;

            foreach(int i in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(i+": "+ (Days)i);
            }
            foreach (var s in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(MeetingDate);
            // MeetingDate = "Saturday"; will give error
            MeetingDate = Days.Tuesday;
            Console.WriteLine(MeetingDate);

            // Console.WriteLine((int)d);


        }
    }
}
*/