using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesel_1261
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int[] mnozniki = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 };
            for(int i=0;i<t;i++)
            {
                string pesel = Console.ReadLine();
                int suma = 0;
                for(int j=0;j<pesel.Length;j++)
                {
                    suma += int.Parse(pesel[j].ToString()) * mnozniki[j];
                }

                if (suma > 0 && suma % 10 == 0)
                    Console.WriteLine("D");
                else Console.WriteLine("N");
            }
        }
    }
}
