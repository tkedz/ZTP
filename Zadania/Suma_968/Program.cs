using System;

namespace Suma_968
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 0;

            for (int i = 0; i < 10; i++)
            {
                a = int.Parse(Console.ReadLine());
                b += a;
                Console.WriteLine(b);
            }
        }
    }
}
