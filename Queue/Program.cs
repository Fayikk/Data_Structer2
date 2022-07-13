using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //queue sesli harfleri tutan bir kuyruk yapısı oluşturalım.
            var karakterkuyrugu = new Queue<char>();
           
            //Kuyruğa ekleme işlemi
            karakterkuyrugu.Enqueue('a');//Burada generic yapıların avantajından faydalanabiliyoruz.
            karakterkuyrugu.Enqueue('e');
            karakterkuyrugu.Enqueue('ı');
            karakterkuyrugu.Enqueue('i');
            karakterkuyrugu.Enqueue('o');

            //Diziye atama işlemi gerçekleştirdik.
            var dizi = karakterkuyrugu.ToArray();

            Console.WriteLine("kuyruktaki eleman sayımız: "+karakterkuyrugu.Count);
            //enqueue yapısı üzerine geldiğimiz zaman bizden int değer istediğini göreceğizdir.
            //Bu da int tanımlanmış generic bir yapıya char titpnde bir değişken vb girilmesini engelleyerek tip güvenliği sağlamaktadır.

            //karakter çıkarmak işlemi
            Console.WriteLine("Kuyruğun başındaki eleman çıkartılacaktır.");

            Console.WriteLine("kuyruktan çıkartılan ifade: " + karakterkuyrugu.Dequeue());
            Console.WriteLine("kuyruktaki eleman sayımız: "+karakterkuyrugu.Count);

        }
    }
}
