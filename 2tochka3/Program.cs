using System;

namespace Test
{
    class Program
    {

        static void main(string[] args)
        {
            int a = -3;
            int b = 3.5;

            if (a * b > 0)
            {
                a = -a;
                b = -b;
            }
            else
            {
                a = b = 0;
            }

            Console.WriteLine($"{a} {b}");

            Console.ReadLine();
        }
    }
}