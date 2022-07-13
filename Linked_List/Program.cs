using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sehirler = new LinkedList<string>();
            sehirler.AddFirst("Ordu");
            sehirler.AddFirst("Trabzon");
            sehirler.AddLast("İstanbul");
            sehirler.AddAfter(sehirler.Find("Ordu"), "Samsun");//ilk parametremiz node düğümüdür,sonraki parametre ise ekleme yapmak istediğimiz şehri seçip yazmalıyız.
            //Samsun öncesine Giresun ekleyelim.Farklı bir yöntem kullanarak.
            sehirler.AddBefore(sehirler.First.Next.Next, "Giresun");
            sehirler.AddBefore(sehirler.Last.Previous.Previous.Next.Next, "Sinop");

            //Console.WriteLine(sehirler.First);
            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);//Trabzon bizim ilk düğümümüzdür.
            }
        }
    }
}
