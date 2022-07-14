using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset_Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Hashset
            //Tanımlama
            var sesliharf = new HashSet<char>()
            {
                'e','ı','i','o','ö','u','ü','b'
            };
            
            
            

            //foreach ifadesi ile işlemimizin bir çıktısını alalım.
            
            sesliharf.Add('a');//Hashsete char(karakter) ekleme işlemini gerçekleştirdik
            KoleksiyonYazdir(sesliharf);

            sesliharf.Remove('b');//Hashsetten char(karakter) çıkarma işlemini  gerçekleştirdik.
            KoleksiyonYazdir(sesliharf);
            var deneme = new List<int>();

            


            
            //ASCİ karakterler ile alfabe yazımı kullanıp,ekleme işlemi gerçekleştirdik.
            var alfabe = new List<char>();
            for (int i = 97; i < 123; i++)
            {
                alfabe.Add((char)i);//cast işlemi yapıp ilgil karakter için atama yapmış olduk
            }
            //Türkçede kullanılan sesli harflerde bulunmaktadır.
            alfabe.ForEach(a=>Console.WriteLine(a));


            //Kümeleme işlemlerimize bir göz atalım.
            //Yalnızca türkçede kullanılan sesli harfler nelerdir.
            // sesliharf.ExceptWith(alfabe);//küme işlemlerinde sesliharf fark alfabe anlamına gelmektedir.
           // sesliharf.UnionWith(alfabe);//Kümeleme işlemlerinde iki kümenin birleşimi anlamına gelmektedir.
            //sesliharf.IntersectWith(alfabe);//Her iki küme için kesişim ifadesi anlamına gelmektedir.

            Console.WriteLine("********************");
            KoleksiyonYazdir(sesliharf);
        }   

        static void KoleksiyonYazdir(HashSet<char> koleksiyon)//Program class'ından herhangi bir nesne üretmeden.Fonksiyon üretimi yapmak için static kullanımı yapıyoruz.
        {
            foreach (char item in koleksiyon)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Eleman sayisi: ");
            Console.WriteLine(koleksiyon.Count);
        }
    }
}
