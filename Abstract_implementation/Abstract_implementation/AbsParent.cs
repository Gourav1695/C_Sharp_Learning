using System.Security.Cryptography.X509Certificates;

namespace Abstract_implementation
{
    abstract class AbsParent
    {
        public void add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);
    /*    static void Main()
        {
            AbsParent parent = new AbsParent(); // creating the instance of the class

            parent.add(1, 2);
            parent.sub(2, 1);
            Console.ReadLine();
        }*/
    }

}