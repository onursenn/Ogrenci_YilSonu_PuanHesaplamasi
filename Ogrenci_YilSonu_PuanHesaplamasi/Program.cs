using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_YilSonu_PuanHesaplamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float d1, d2, d3, d4, sonuc;

            Console.Write("Matematik Sınav Ortalamanızı Girin: ");
            d1 = float.Parse(Console.ReadLine());
            Console.Write("Edebiyat Sınav Ortalamanızı Girin: ");
            d2 = float.Parse(Console.ReadLine());
            Console.Write("Tarih Sınav Ortalamanızı Girin: ");
            d3 = float.Parse(Console.ReadLine());
            Console.Write("Coğrafya Sınav Ortalamanızı Girin: ");
            d4 = float.Parse(Console.ReadLine());
            sonuc = (d1 + d2 + d3 + d4) / 4;

            if (sonuc < 50)
            {
                Console.WriteLine("Başarı Ortalamanız: "+sonuc+" Maalesef Sınıfta Kaldınız.");
            }
            if (sonuc >= 50 & sonuc <= 69.99)
            {
                Console.WriteLine("Başarı Ortalamanız: " + sonuc + " Tebrikler Sınıfı Geçtiniz.");
            }
            if (sonuc>=70 & sonuc<= 84.99)
            {
                Console.WriteLine("Başarı Ortalamanız: " + sonuc + " Tebrikler Sınıfı Başarıyla Geçerek Teşekkür Belgesi Aldınız.");
            }
            if(sonuc>=85 & sonuc <= 100)
            {
                Console.WriteLine("Başarı Ortalamanız: " + sonuc + " Tebrikler Sınıfı Başarıyla Geçerek Taktir Belgesi Aldınız.");
            }

            Console.Read();
        }
    }
}
