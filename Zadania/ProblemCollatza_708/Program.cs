using System;

namespace ProblemCollatza_708
{
    class Program
    {
        static int calc(int xn, int counter)
        {
            if (xn == 1) return counter;
            else
            {
                counter++;
                if (xn % 2 == 0)
                    return calc(xn / 2, counter);
                else
                    return calc(3 * xn + 1, counter);
            }
        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[t];
            for(int i=0;i<t;i++)
            {
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(calc(tab[i], 0));
            }
        }
    }
}
