using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Learning
{
    public abstract class Figure // parent class
    {
        public double width, height, radius;
        public float pi = 3.14f;
        public abstract double GetArea();  // declaring in the parent class it will help to maintain signature of the method like here signature is double for GetArea and it will be same for alll the inherited class

    }

    public class Rectangle : Figure // inherating the parent class
    {
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;

        }
        public override double GetArea()
        {
            return width * height;
        }
    }
    public class Circle : Figure // inherating the parent class
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return pi * radius * radius;
        }
    }
    public class cone : Figure
    {
        public cone(double height, double radius)
        {
            this.height = height;
            this.radius = radius; // we have to initialize the parameters in the constructor.
        }

        public override double GetArea()
        {
            return pi * radius * radius + Math.Sqrt(height * height + radius * radius);
        }
    }
    public class TestMethods
    {
        public static void Main()
        {
            Rectangle r = new Rectangle(10.23, 34.56); // creating instance of the class to use it in the main method
            r.height = 10;
            r.width = 20;// changing the parameter of the rectangle
            Console.WriteLine(r.GetArea());
            Circle c = new Circle(5);
            Console.WriteLine(c.GetArea());
            cone con = new cone(5, 4);
            Console.WriteLine(con.GetArea());
        }
    }


}
