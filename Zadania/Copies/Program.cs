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

            public void Wypisz()
            {
                Console.WriteLine(this.opis.marka + " " + this.opis.model + " " + this.rokProdukcji);
            }

            public object ShallowCopy()
            {
                return this.MemberwiseClone();
            }

            public Samochod DeepCopy()
            {
                Samochod result = new Samochod(this.rokProdukcji, this.opis.marka, this.opis.model);
                return result;
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
            Samochod s1 = new Samochod(2012, "Ford", "focus");
            Samochod s2 = s1.DeepCopy();


            s1.Wypisz();
            s2.Wypisz();

            s2.rokProdukcji = 2015;
            s2.opis.marka = "Ferrari";
            s2.opis.model = "Ferrari";

            Console.WriteLine();
            s1.Wypisz();
            s2.Wypisz();

        }
    }
}


//public object ShallowCopy()
//{
//    return this.MemberwiseClone();
//}

//public Samochod DeepCopy()
//{
//    return new Samochod(this.rokProdukcji, this.opis.marka, this.opis.model);
//}
