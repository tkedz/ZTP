using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_997
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while((input = Console.ReadLine())!=null)
            {
                string[] arr = input.Split(' ');
                int a = int.Parse(arr[1]);
                int b = int.Parse(arr[2]);

                switch(arr[0])
                {
                    case "+":
                        Console.WriteLine(a + b);
                        break;
                    case "-":
                        Console.WriteLine(a - b);
                        break;
                    case "*":
                        Console.WriteLine(a * b);
                        break;
                    case "/":
                        Console.WriteLine(a / b);
                        break;
                    case "%":
                        Console.WriteLine(a % b);
                            break;
                }
            }
        }
    }
}
