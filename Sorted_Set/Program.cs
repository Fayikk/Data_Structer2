using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_Set
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SortedSet
            //Tanımlama
            var list = new SortedSet<string>();
            //Ekleme
            //Bu değer bizim için ya 'true' yada 'false' değer döndürecektir.
            if (list.Add("Fayik"))
            {
                Console.WriteLine("Fayik eklendi.");

            }
            else
            {
                Console.WriteLine("Ekleme başarısız.");
            }

            Console.WriteLine("{0}", list.Add("Ahmet") == true ?
                              "Ahmet eklendi" : "Ekleme başarısız.");

            list.Add("Mustafa");
            list.Add("Demir");
            list.Add("Deniz");
            list.Add("Süleyman");
            list.Add("Asaf");

            //Listeden eleman kaldırma.
            list.Remove("Süleyman");//yazılan item listeden kaldırılıyor.
          //  list.RemoveWhere(deger => deger.Contains("a"));//içerisinde "a" olan kelimeler koşullarımıza uygun olarak listeden kaldırıldılar.

            Console.WriteLine("\n İsimler listesi.");
            foreach (string item in list)

            {
                Console.WriteLine(item);
            }

        }
    }
}
