using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_Applications
{
    internal class Program
    {//Ne yapmak istiyoruz?
        //BTK akademiden yeni eğitimler.
        //btk-akademiden-yeni-eğitimler.(Nu şekilde yeni bir url yapısı oluşturuyoruz.)
        static void Main(string[] args)
        {
            Console.WriteLine("Başlık giriniz");
            string baslik = Console.ReadLine();

            //kucultme
            baslik=baslik.ToLower();

            //Hashtable
            var karakterSeti = new Hashtable()
            {//çift olarak tanımlama yapacağız
                {'ç','c'},
                {"ı","i" },
                {"ö","o" },
                {"ü","u"},
                {" ","-"},
                {"ş","s" }
               
            };
            foreach (DictionaryEntry item in karakterSeti)
            {
                baslik = baslik.Replace((char)item.Key,(char)item.Value);
                //Yukarıda char dönüşümünde cast işlemi gerçekleştirdik.Unboxing
            }
            Console.WriteLine(baslik);
        }
    }
}
