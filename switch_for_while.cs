using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Switch

    {
        static void Main(string[] args)
        {
            /*var season = Season.Autumn;
            var name = "John Smith";
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's perfect time to go to beach.");
                    break;

                default: 
                    Console.WriteLine("I don't know what is the season!");
                    break;*/

           /* while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                *//*if(String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                Console.WriteLine("@Echo: " + input);*//*

                if (!String.IsNullOrWhiteSpace(input))
                {
                Console.WriteLine("@Echo: " + input);
                    continue; 
                }
                break;
            }*/

            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++) 
            {
                buffer[i]=(char)('a' +random.Next(0, 26));

            }
            var password = new string(buffer);
        Console.WriteLine(password);

                   
            }
        }
    }

