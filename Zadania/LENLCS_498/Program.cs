using System;
using System.Collections.Generic;

namespace LENLCS_498
{
    class Program
    {
        static int LENLCS(string s1, string s2, int n, int m, Dictionary<KeyValuePair<int, int>, int> map)
        {
            if (map.ContainsKey(new KeyValuePair<int, int>(n, m)))
                return map[new KeyValuePair<int, int>(n, m)];

            if (n < 0 || m < 0)
                map.Add(new KeyValuePair<int, int>(n, m), 0);
            else if(s1[n]==s2[m])
                map.Add(new KeyValuePair<int, int>(n, m), 1 + LENLCS(s1,s2,n-1,m-1,map));
            else
                map.Add(new KeyValuePair<int, int>(n, m), Math.Max(LENLCS(s1, s2, n, m - 1, map), LENLCS(s1, s2, n - 1, m, map)));

            return map[new KeyValuePair<int, int>(n,m)];
        }
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            Dictionary<KeyValuePair<int, int>, int> map = new Dictionary<KeyValuePair<int, int>, int>();

            while(d > 0)
            {
                int n = int.Parse(Console.ReadLine());
                string s1 = Console.ReadLine();
                int m = int.Parse(Console.ReadLine());
                string s2 = Console.ReadLine();

                Console.WriteLine(LENLCS(s1, s2, n-1, m-1, map));

                d--;
            }
        }
    }
}
