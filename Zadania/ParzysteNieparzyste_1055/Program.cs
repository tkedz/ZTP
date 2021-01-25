using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParzysteNieparzyste_1055
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string parzyste = "";
            string nieparzyste = "";
            for (int i = 0; i < t; i++)
            {
                string[] tmp = Console.ReadLine().Split(' ');
                for (int j = 1; j < tmp.Length; j++)
                {
                    if (j % 2 == 0)
                        parzyste += tmp[j] + " ";
                    else nieparzyste += tmp[j] + " ";
                }
                Console.WriteLine(parzyste + nieparzyste);
            }
        }
    }
}
