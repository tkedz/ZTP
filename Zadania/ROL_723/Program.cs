using System;
using System.Collections.Generic;

namespace ROL_723
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                Queue<string> q = new Queue<string>(Console.ReadLine().Split(' '));
                q.Dequeue();
                var item = q.Dequeue();
                q.Enqueue(item);

                foreach (var x in q)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
