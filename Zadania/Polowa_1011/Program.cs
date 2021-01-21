using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polowa_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string s;
            for(int i=0; i<t; i++)
            {
                s = Console.ReadLine();
                string substr = s.Substring(0, s.Length / 2);
                Console.WriteLine(substr);
            }
        }
    }
}
