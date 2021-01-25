using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica_977
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab = Console.ReadLine().Split(' ');
            List<string> list = new List<string>(tab);
            list.Reverse();
            foreach (string s in list) 
            {
                Console.Write(s + ' ');
            }
        }
    }
}
