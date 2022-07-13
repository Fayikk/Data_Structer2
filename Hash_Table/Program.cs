using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    public class Program
    {
        static void Main(string[] args)
        {   
            //Hashtable
            //örtülü veri türü ile tanımlama işlemimizi gerçekleştiriyoruz.
            var sehirler = new Hashtable();

            //Ekleme işlemi
            sehirler.Add(21,"Diyarbakır");
            sehirler.Add(34, "İstanbul");
            sehirler.Add(44, "Malatya");
            Console.ReadKey();

            Console.WriteLine(sehirler[21]);//Bu şekilde anahtarlar ile değerlere ulaşma işlemini gerçekleştirebiliriz.
           
            //Döngünü tipinin dictionary entry olması gerekmektedir.
            foreach (DictionaryEntry sehir in sehirler)//Dictionary entry sayesinde çift olarak aldık.
            {
                Console.WriteLine($"{sehir.Key, - 5}" +
                                   $"{sehir.Value,-20}"+"\n");
            }

            //Sadece anahtarları almak istersek nasıl bir tanım yapmamız gerekmektedir.
            var anahtarlar = sehirler.Keys;

            foreach (var item in anahtarlar)//Burada yalnızca anahtarları aldık.
            {
                Console.WriteLine(item);
                Console.WriteLine("\n");
            }

            ICollection degerler = sehirler.Values;//Buradada sadece değerleri almış olduk.
            foreach (var item1 in degerler)
            {
                Console.WriteLine(item1);
            }
            Console.WriteLine("Özel elemana erişme\n");

            Console.WriteLine(sehirler[21]);//Diyarbakır çıktısını verecektir.
            //Eleman silme işlemi
            Console.WriteLine("eleman silme işlemi denemesi");
            sehirler.Remove(21);//Diyarbakır ifadesini hashtable'dan kaldıralım.
                                //şimdi test edelim
            Console.WriteLine(sehirler[21]);//Herhangi bir değer yazdırmayacktır gerekli silme işlemleri gerçekleştirilmiştir.
        
        }
    }
}
