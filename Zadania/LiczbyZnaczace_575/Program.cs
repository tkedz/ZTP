using System;
using System.Collections.Generic;

namespace LiczbyZnaczace_575
{
    class Program
    {
        static bool czyPierwsza(int a)
        {
            if (a % 2 == 0)
                return (a == 2);
            for (int i = 3; i <= Math.Sqrt(a); i += 2)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            List<int> liczbyZnaczace = new List<int>();

            for(int i=2; i < Math.Sqrt(1000000000); i++)
            {
                if(czyPierwsza(i))
                {
                    liczbyZnaczace.Add(i * i);
                }
            }

            int t = int.Parse(Console.ReadLine());
            while(t > 0)
            {
                string[] tmp = Console.ReadLine().Split(' ');
                int a = int.Parse(tmp[0]);
                int b = int.Parse(tmp[1]);

                int counter = 0;
                for(int i=0; i<liczbyZnaczace.Count; i++)
                {
                    if (liczbyZnaczace[i] >= a && liczbyZnaczace[i] <= b) counter++;
                    if (liczbyZnaczace[i] > b) break;
                }
                Console.WriteLine(counter);
                t--;
            }
        }
    }
}
