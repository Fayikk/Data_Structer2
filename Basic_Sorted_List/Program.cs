using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Sorted_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Sorted list temelleri
            //Tanımlama
            var list = new SortedList()
            {
                {1,"Bir" },
                {2,"İki" },
                {3,"Üç" },
                {4,"Dört" },
                {5,"Beş" },
                {6,"Altı" }
            };
            //Dışarıdan ekleme işlemi
            list.Add(10, "On");
            list.Add(11,
                "OnBir");
            //Dolaşma
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine(item.Key +"-"+item.Value);
            }
            Console.WriteLine("Listedeki eleman sayısı: {0} ",list.Count);
            Console.WriteLine("Listenin kapasitesi :{0} ", list.Capacity);
            list.TrimToSize();//Kapasiteyi set etme işlemini gerçekleştirir.
            Console.WriteLine("Listenin kapasitesi : {0}", list.Capacity);
            //Erişme
            //Key yardımıyla yapalım
            Console.WriteLine(list[10]);//erişimde indeks değeri değildir.key değeri ile çağırma işlemini gerçekleştirdik.
            //İndekse bağlı olarak elemanları getirelim.
            Console.WriteLine(list.GetByIndex(2));
            Console.WriteLine(list.GetKey(0));//getkey metodu ile indise bağlı olarak,anahtar getirme,yakalama işlemini gerçekleştirmiş olduk.


            Console.WriteLine("Liste sonundaki elemanın değeri:");
            Console.WriteLine(list.GetByIndex(list.Capacity-1));

            var anahtarlar = list.Keys;
            foreach (var item in anahtarlar)//Anahtarları alma işlemimi burada gerçekleşitiriyorum.
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------Degerler--------------");
            var degerler = list.Values;
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }
            //Update(güncelleme) işlemi yapmak.

            Console.WriteLine("Update(Güncelleme)");
            if (list.ContainsKey(11))
            {
                list[11] = "Eleven";
            }
            Console.WriteLine("************");
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }
            //Remove işlemi(Kaldırma) işlemini gerçekleştirmiş olduk.
            Console.WriteLine("KALDIRMA İŞLEMİ");
            list.Remove(2);
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

        }
    }
}
