using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Basics
{
    public struct Ogrenci
    {
        public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet)//Bu bir constructer yapısıdır.
        {
            Console.WriteLine("Constructer calisti");
            Numara = numara;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        //bir yada daha fazla veri türüne ihtiyacımız varsa bunları struct yapısı içerisinde kullanabiliriz.
        //değer tiplidirler.
        //program main yordamı içerisinde çalışmaya başlar
        public int Numara { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }

        //set-> atama değeri yapmamızı sağlamaktadır.Kapsülleme
        //get-> okuma değerlerinin gerçekleştirildiği yerdir.
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //struct7
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Numara = 10;
            ogrenci.Adi = "Fayik";
            ogrenci.Soyadi = "Veznedaroglu";
            ogrenci.Cinsiyet = true;
            Console.WriteLine("-------------");
            Console.WriteLine(ogrenci.Numara);
            Console.WriteLine(ogrenci.Adi);
            Console.WriteLine(ogrenci.Soyadi);
            Console.WriteLine(ogrenci.Cinsiyet);
            //Alternatif kullanım
            var ogrenci2 = new Ogrenci() { Numara = 12, Adi = "eren", Soyadi = "demir", Cinsiyet = true };

            Console.WriteLine(ogrenci2.Adi);
            //String interpolasyonu
            //Console.WriteLine($"{ogrenci.Numara}")->şeklinde devam ettirilebilir.
            Console.ReadKey();


            //alternatif 3
            var ogr3 = new Ogrenci(1076, "Büşra", "Alen", false);//Constructer yapı kullanımı.
            Console.WriteLine($"{ogr3.Adi}" + $"{ogr3.Soyadi}");

        }
    }
}
