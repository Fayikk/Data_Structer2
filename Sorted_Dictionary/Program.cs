using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_Dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Bir kitap indeksi oluşturacaz
            //FTP denen kavram hangi sayfalarda geçiyor
            //Html hangi sayfalarda
            //ASP.net ve Css hangi sayfalarda
            //Jquery ve database kavramı hangi sayfalarda geçiyor.

            var kitapIndeks = new SortedDictionary<string, List<int>>()
            {
                { "HTML", new List<int>(){8,10,12} },
                { "CSS", new List<int>(){70,80,90} },
                { "JQUERY", new List<int>(){3,5,15} },
                { "SQL", new List<int>(){70,80} },
            };
            kitapIndeks.Add("FTP", new List<int>() { 3, 5, 7 });//FTP kavramı 3,5 ve 7.sayfalarda geçmektedir.
            kitapIndeks.Add("ASP.NET", new List<int>() { 50, 60 });

            //anahtar ve değer ifadesi için,iç içe for döngüsü kullanmak zorunda kaldık.Bunun sebebi ise şudur;
            //anahtar string bir tiptir ve değer ise int bu ikisine aynı kavram üzerinde ulaşmamız mümkün olamaz
            //bir kavram hem string hemde int değer döndüremez.Dolaysıyla iç içe dögü kurup dıştaki döngüye örtülü değişken ataması yaptıkki içteki int değer döndürecek döngü'ye problem yaşatmasın
            //Ve gerekli işlemler yapıldığında anahtar ve değer işlemlerine ulaşmış oluyoruz.
            foreach (var kavram in kitapIndeks)
            {
                Console.WriteLine(kavram.Key);
                foreach (int kavram1 in kavram.Value)
                {
                    Console.WriteLine("------>"+kavram1);
                }
            }
            Console.ReadKey();

        }
    }
}
