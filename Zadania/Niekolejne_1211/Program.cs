using System;

namespace Niekolejne_1211
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            if (n == 0) Console.WriteLine(n);
            else if (n == 2 || n == 1) Console.WriteLine("NIE");
            else
            {
                for(ulong i=1; i<=n;i+=2)
                {
                    Console.WriteLine(i);
                }

                for(ulong i=0; i<=n;i+=2)
                {
                    if (i != n) Console.WriteLine(i + " ");
                    else Console.WriteLine(i);
                }
            }
        }
    }
}
