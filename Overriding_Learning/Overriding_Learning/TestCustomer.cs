using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Learning
{
    internal class TestCustomer
    {
        static void Main()
        {
            // creating instance of Custormer class
            Custormer obj = new Custormer(101,false,"Gourav",5000,Cities.Channai,"West Bengal");

            Console.WriteLine("Custid: "+ obj.Custid); // here Custid is property.
            //obj.Custid = 908; //becaue of using public field in the customer class we can modify the value
            // can't be assigned as the property is read only

            Console.WriteLine("Custid: " + obj.Custid);
            obj.Status=true; Console.WriteLine("Now Changes Customer Status: " + obj.Status);
            if(obj.Status==true )
            {
            Console.WriteLine(" Current Customer Status is active"); // we can modify this property also as it get , set

            }
            else { Console.WriteLine("Current customer Status is in-active"); }

            Console.WriteLine("Customer Name: " + obj.Cname);
            obj.Cname += " Kumar Shaw";
            Console.WriteLine("Customer Modified Name: " + obj.Cname);

            Console.WriteLine("Customer Balance :"+ obj.Balance);
            obj.Balance += 2000; // Assignment failed so below statement will print the old balance. as obj.Status was false;
            Console.WriteLine("Customer updated Balance is : "+ obj.Balance);
            obj.Balance -= 6000;// if assingment failed it will print the old value

            Console.WriteLine("Customer updated Balance is: "+obj.Balance);
            obj.Balance -= 400;
            Console.WriteLine("Customer updated Balance is: " + obj.Balance);

            Console.WriteLine("Current City is : "+ obj.City);

            obj.City = Cities.Delhi;// it will not change as it is different fromt the 6 city that is supported
            Console.WriteLine("Modified City is : "+ obj.City);

            Console.WriteLine("State is: " +obj.State);
            obj.State = "Rajesthan";
            Console.WriteLine("Modified state is: " + obj.State);

            Console.WriteLine("Current Country is : " + obj.Country);
            Console.ReadLine();
        }
    }
}
