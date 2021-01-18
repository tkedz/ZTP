using System;

namespace Faktoryzacja_1609
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dzielniki = new int[8000001];

            dzielniki[0] = 1;
            for (int i = 1; i < 8000001; i++)
                dzielniki[i] = i;

            for(int i=2;i*i<=8000000;i++)
            {
                if (dzielniki[i] == i)
                {
                    for (int j = i * i; j <= 8000000; j += i)
                        if (dzielniki[j] == j)
                            dzielniki[j] = i;
                }
            }


            int t = int.Parse(Console.ReadLine());
            for(int i=0;i<t;i++)
            {
                int liczba = int.Parse(Console.ReadLine());
                Console.Write(dzielniki[liczba]);
                liczba /= dzielniki[liczba];
                while(liczba > 1)
                {
                    Console.Write("*" + dzielniki[liczba]);
                    liczba /= dzielniki[liczba];
                }
                Console.WriteLine();
            }

        }
    }
}
