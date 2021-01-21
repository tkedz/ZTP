using System;

namespace JGGHACK_1346
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i=0;i<t;i++)
            {
                string input = Console.ReadLine();
                string passwd = "";

                for(int j=0;j<input.Length;j+=2)
                {
                    int tmp = ((int)input[j] - 65) +  ((int)input[j + 1] - 65) * 16;

                    passwd += (char)tmp;
                }

                Console.WriteLine(passwd);
            }
        }
    }
}
