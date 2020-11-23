using System;

namespace LiczbyZnaczace_575
{
    class Program
    {
        static bool checkIfSignifiant(int number)
        {
            int sum = 0;
            int counter = 0;
            double sqrt = Math.Sqrt(number);
            for(int i=2; i < Math.Sqrt(number); i++)
            {
                if(number % i == 0)
                {
                    sum += i;
                    counter++;
                }
            }

            double avg = (sum * 1.0) / counter;

            if (avg <= sqrt) return true;
            return false;
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while(t > 0)
            {
                string[] tmp = Console.ReadLine().Split(' ');
                int num1 = int.Parse(tmp[0]);
                int num2 = int.Parse(tmp[1]);

                int counter=0;
                for(int i=num1; i<=num2; i++)
                {
                    if (checkIfSignifiant(i)) counter++;
                }
                Console.WriteLine(counter);

                t--;
            }
        }
    }
}
