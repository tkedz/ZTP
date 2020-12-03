using System;

namespace LENLCS_498
{
    class Program
    {
        static int LENLCS(string s1, string s2, int n, int m)
        {
            if (n < 0 || m < 0) return 0;

            if (s1[n] == s2[m])
                return 1 + LENLCS(s1, s2, n - 1, m - 1);
            else
                return Math.Max(LENLCS(s1, s2, n, m - 1), LENLCS(s1, s2, n - 1, m));
        }
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());

            while(d > 0)
            {
                int n = int.Parse(Console.ReadLine());
                string s1 = Console.ReadLine();
                int m = int.Parse(Console.ReadLine());
                string s2 = Console.ReadLine();

                Console.WriteLine(LENLCS(s1, s2, n-1, m-1));

                d--;
            }
        }
    }
}
