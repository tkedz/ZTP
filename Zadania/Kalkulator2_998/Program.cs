using System;

namespace Kalkulator2_998
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            string input;
            while ((input = Console.ReadLine()) != null)
            {
                string[] arr = input.Split(' ');
                int a = int.Parse(arr[1]);
                int b = int.Parse(arr[2]);

                switch (arr[0])
                {
                    case "+":
                        Console.WriteLine(numbers[a] + numbers[b]);
                        break;
                    case "-":
                        Console.WriteLine(numbers[a] - numbers[b]);
                        break;
                    case "*":
                        Console.WriteLine(numbers[a] * numbers[b]);
                        break;
                    case "/":
                        Console.WriteLine(numbers[a] / numbers[b]);
                        break;
                    case "%":
                        Console.WriteLine(numbers[a] % numbers[b]);
                        break;
                    default:
                        numbers[a] = b;
                        break;
                }
            }
        }
    }
}
