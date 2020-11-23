using System;
using System.Collections.Generic;
using System.Linq;

namespace Sumy_727
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());
            var lists = new List<List<List<int>>>();
            for (int i = 0; i < liczbaTestow; i++)
            {
                int n = int.Parse(Console.ReadLine());
                var listOfLists = Sumy(n);
                lists.Add(listOfLists);
            }
            foreach (var item in lists)
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(string.Join(" ", item2));
                }
                Console.WriteLine();
            }
        }
        private static List<List<int>> Sumy(int n)
        {
            var list = new List<List<int>>();
            if (n == 1)
            {
                list.Add(new List<int>() { 1 });
                return list;
            }
            else
            {
                var poprzednialista = Sumy(n - 1);
                for (int i = 0; i < poprzednialista.Count; i++)
                {
                    poprzednialista[i].Insert(0, 1);
                }
                if (n > 5)
                {
                    int start;
                    if (n % 2 == 0)
                    {
                        start = n / 2;
                    }
                    else start = (n - 1) / 2;
                    for (int x = start; x > 2; x--)
                    {
                        var lista2 = new List<int>();
                        int roznica = n - x;
                        lista2.Add(x);
                        lista2.Add(roznica);
                        poprzednialista.Add(lista2);
                    }
                }

                List<List<int>> nowelisty = new List<List<int>>();
                foreach (var item in poprzednialista)
                {
                    if (item.Count > 2)
                    {
                        if (item[0] == item[1] && item[1] != item[2])
                        {
                            var lista3 = new List<int>();
                            lista3.AddRange(item);
                            lista3.Add(item[0] + item[1]);
                            lista3.RemoveAt(0);
                            lista3.RemoveAt(0);

                            nowelisty.Add(lista3);
                        }
                    }
                }
                foreach (var item in nowelisty)
                {
                    poprzednialista.Add(item);
                }

                poprzednialista.Add(new List<int> { n });

                var rlist = poprzednialista.Select(lst => lst.OrderBy(i => i).ToList())
                    .OrderBy(lst => lst[0]).ToList();
                return rlist;
            }
        }
    }
}
