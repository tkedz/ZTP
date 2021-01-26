using System;

namespace Dwumiany_833
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i=0;i<t;i++)
            {
                string[] tab = Console.ReadLine().Split(' ');
                double n = double.Parse(tab[0]);
                double k = double.Parse(tab[1]);

                //symbol newtona
                double result = 1;
                for (int j = 1; j <= k; j++)
                    result = (result * (n - j + 1)) / j;

                Console.WriteLine(Math.Round(result));
            }
        }
    }
}
