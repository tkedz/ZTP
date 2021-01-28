using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Dodawanie_1293
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i<t;i++)
            {
                string[] tmp = Console.ReadLine().Split(' ');
                BigInteger number1 = BigInteger.Parse(tmp[0]);
                BigInteger number2 = BigInteger.Parse(tmp[1]);
                Console.WriteLine(number1 + number2);
            }


            //Dziala ale nie przechodzi przez spoja to ponizej

            //int t = int.Parse(Console.ReadLine());
            //for(int i=0;i<t;i++)
            //{
            //    int carry = 0;
            //    string[] tmp = Console.ReadLine().Split(' ');
            //    List<char> number1 = tmp[0].ToList();
            //    List<char> number2 = tmp[1].ToList();
            //    number1.Reverse();
            //    number2.Reverse();

            //    List<int> result = new List<int>();
            //    int j;
            //    int numOfIterations = Math.Min(number1.Count, number2.Count);
            //    for(j=0;j<numOfIterations;j++)
            //    {
            //        result.Add((number1[j] - '0') + (number2[j] - '0') + carry);
            //        if(result[j]>9)
            //        {
            //            carry = 1;
            //            result[j] -= 10;
            //        }
            //        else
            //        {
            //            carry = 0;
            //        }
            //    }

            //    if(j==number1.Count && j < number2.Count)
            //    {
            //        for(; j<number2.Count; j++)
            //        {
            //            result.Add((number2[j] - '0') + carry);
            //            carry = 0;
            //        }
            //    }
            //    else if(j==number2.Count && j < number1.Count)
            //    {
            //        for(; j<number1.Count; j++)
            //        {
            //            result.Add((number1[j] = '0') + carry);
            //            carry = 0;
            //        }
            //    }

            //    result.Reverse();
            //    for (j = 0; j < result.Count; j++)
            //        Console.Write(result[j]);
            //    Console.WriteLine();
            //}
        }
    }
}
