using System;
using System.Collections.Generic;
using System.Linq;

namespace Sumy_727
{
    class Program
    {
        static void sum(List<int> list, int x, int number)
        {
            if(number == 0)
            {
                for(int i=0;i<list.Count;i++)
                {
                    Console.Write(list[i] + " ");
                }
                Console.WriteLine();
                return;
            }

            for(int i=x;number-i>=0;i++)
            {
                list.Add(i);
                sum(list, i, number - i);
                list.RemoveAt(list.Count - 1);
            }
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int t = int.Parse(Console.ReadLine());
            while(t > 0)
            {
                int number = int.Parse(Console.ReadLine());
                sum(list, 1, number);
                Console.WriteLine();
                t--;
            }
        }
    }
}
