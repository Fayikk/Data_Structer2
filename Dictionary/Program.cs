using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Dictionary

            var telefonKodlari = new Dictionary<int, string>()
            {
                { 332,"Konya" },
                {424,"Elazığ" },
                {466,"Art" }, };

            //Ekleme
            telefonKodlari.Add(412, "Diyarbakır");
            telefonKodlari.Add(322, "Adana");
            telefonKodlari.Add(222, "Istanbul");
            telefonKodlari.Add(216, "Istanbul");
            

            //Erişim sağlama
            telefonKodlari[466] = "Artvin";

            //ContainKey

            //telefonKodlari.ContainsKey(412);//Bool bir ifade dönmesini bekliyoruz.
            if (!telefonKodlari.ContainsKey(212))
            {
                Console.WriteLine("\a Ankaranın kod bilgisi tanımlı değil!");
                Console.WriteLine("Eklendi.");
                telefonKodlari.Add(212, "Ankara");
            }

            //ContainValue işlemi
            if (!telefonKodlari.ContainsValue("Malatya"))
            {
                Console.WriteLine("\a Malatyanın kod bilgisi tanımli değil.");
                telefonKodlari.Add(331, "Malatya");
                Console.WriteLine("Malatya değer bilgisi başarıyla eklendi.");
            }

            //Kaldirma işlemi
            telefonKodlari.Remove(322);//Adana ifadesini silmiş olduk.


            foreach (var item in telefonKodlari)
            {
                Console.WriteLine(item.Value+"::"+item.Key,5);

            }
        }
    }
}
