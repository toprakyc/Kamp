using System;
using System.Collections.Generic;
//metot yazmak daha kolaylar..
namespace Astroloji
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi1 = new Kisi();
            kisi1.Gunes = "Kova";   //veritabanından gelir
            kisi1.Ay = "Boga";
            kisi1.Merkur = "Kova";
            kisi1.Yukselen = "Balik";
            kisi1.Venus = "Oglak";
            kisi1.Mars = "Aslan";
            kisi1.Jupiter = "Yay";
            kisi1.Saturn = "Balik";
            kisi1.Pluto = "Yay";
            kisi1.Neptun = "Oglak";
            kisi1.Uranus = "Oglak";
            List<string> kisiler = new List<string> {kisi1.Gunes, kisi1.Ay, kisi1.Merkur,
                kisi1.Yukselen, kisi1.Venus, kisi1.Mars, kisi1.Jupiter, kisi1.Saturn,
                kisi1.Pluto, kisi1.Neptun, kisi1.Uranus};   //generic içine aldık..

            foreach (var item in kisiler)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Burc
    {
        public string Koc { get; set; }
        public string Boga { get; set; }
        public string Ikizler { get; set; }
        public string Yengec { get; set; }
        public string Aslan { get; set; }
        public string Basak { get; set; }
        public string Terazi { get; set; }
        public string Akrep { get; set; }
        public string Yay { get; set; }
        public string Oglak { get; set; }
        public string Kova { get; set; }
        public string Balik { get; set; }
    }
    class Kisi
    {
        public string Gunes { get; set; }
        public string Yukselen { get; set; }
        public string Merkur { get; set; }
        public string Ay { get; set; }
        public string Venus { get; set; }
        public string Mars { get; set; }
        public string Jupiter { get; set; }
        public string Saturn { get; set; }
        public string Pluto { get; set; }
        public string Neptun { get; set; }
        public string Uranus { get; set; }
    }
}
