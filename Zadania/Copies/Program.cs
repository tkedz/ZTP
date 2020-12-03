using System;

namespace Copies
{
    class Program
    {
        class Samochod
        {
            public int rokProdukcji;
            public OpisSamochodu opis;

            public Samochod(int rokProdukcji, string marka, string model)
            {
                this.rokProdukcji = rokProdukcji;
                this.opis = new OpisSamochodu(marka, model);
            }

            public object ShallowCopy()
            {
                return this.MemberwiseClone();
            }

            public Samochod DeepCopy()
            {
                return new Samochod(this.rokProdukcji, this.opis.marka, this.opis.model);
            }

            public void Wypisz()
            {
                Console.WriteLine(this.opis.marka + " " + this.opis.model + " " + this.rokProdukcji);
            }
        }

        class OpisSamochodu 
        {
            public string marka;
            public string model;

            public OpisSamochodu(string marka, string model)
            {
                this.marka = marka;
                this.model = model;
            }
        }
        static void Main(string[] args)
        {
            Samochod s1 = new Samochod(2012, "Ford", "Focus");
            Samochod s2 = s1.DeepCopy();

            s1.Wypisz();
            s2.Wypisz();

            s1.rokProdukcji = 2020;

            s1.Wypisz();
            s2.Wypisz();

            s1.opis.marka = "Opel";
            s1.opis.model = "Astra";

            s1.Wypisz();
            s2.Wypisz();
        }
    }
}
