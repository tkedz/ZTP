using System;

namespace MultipleClassInheritance
{
    class Program
    {
        interface IStart
        {
            public void dzialaj();
        }
        class Drukarka : IStart
        {

            public void dzialaj()
            { 
                Console.WriteLine("Rozpoczynam drukkowanie");
            }
        }

        class Skaner : IStart
        {
            public void dzialaj()
            {
                Console.WriteLine("Rozpoczynam skanowanie");
            }
        }

        class Ksero : IStart
        {
            Drukarka d = new Drukarka();
            Skaner s = new Skaner();

            public void dzialaj()
            {
                s.dzialaj();
                d.dzialaj();
            }

        }
      
        static void Main(string[] args)
        {
            Ksero k = new Ksero();
            k.dzialaj();
        }
    }
}
