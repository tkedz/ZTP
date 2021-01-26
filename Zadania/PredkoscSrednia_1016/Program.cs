using System;

namespace PredkoscSrednia_1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i < t; i++)
            {
                string[] tmp = Console.ReadLine().Split(' ');
                int v1 = int.Parse(tmp[0]);
                int v2 = int.Parse(tmp[1]);
                int vsr = (2 * v1 * v2) / (v1 + v2);
                Console.WriteLine(vsr);
            }
        }
    }
}
