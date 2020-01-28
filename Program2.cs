using System;

namespace UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var boo = new Boo();

            var result = boo.Sum(10, 10);

            Console.WriteLine("Hello World!", result);
        }
    }
}
