using System;

namespace GraEuklidesa_804
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[t];
            int[] b = new int[t];

            for(int i=0;i<t;i++)
            {
                string[] tab = Console.ReadLine().Split(' ');
                a[i] = Convert.ToInt32(tab[0]);
                b[i] = Convert.ToInt32(tab[1]);
            }

            for(int i=0;i<t;i++)
            {
                while(a[i] != b[i])
                {
                    if(a[i] < b[i])
                    {
                        b[i] -= a[i];
                    }
                    else if(a[i] > b[i])
                    {
                        a[i] -= b[i];
                    }
                }
                Console.WriteLine(a[i] + b[i]);
            }
        }
    }
}
