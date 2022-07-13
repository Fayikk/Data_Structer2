using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            //sesli harfleri listede tutalım ve sesli harfleri kuyrukta tutalımmı(y/n)

            var sesliHarfler = new List<char>()
            {
                'a',
                'e',
                'ı',
                'i',
                'o',
                'ö',
                'ü',
                'u',
            };
            var kuyruk = new Queue<char>();
            //Bu elemanları sırasıyla dolaşmak için bir foreach ifadei yazalım

            ConsoleKeyInfo secim;
            ConsoleKeyInfo secim1;
            foreach (char k in sesliHarfler)
            {
                Console.WriteLine(k + "" + "Kuyruğa eklensinmi?(y/n)");
                secim = Console.ReadKey();

                if (secim.Key==ConsoleKey.Y)
                {
                    kuyruk.Enqueue(k);
                    Console.WriteLine(k+"   kuyruğa eklendi.");
                    //Dinamiklik
                    Console.WriteLine("Kuyruktaki eleman sayısı: " + kuyruk.Count);
                }
                else if(secim.Key == ConsoleKey.N)
                {
                    Console.WriteLine("Kuyruğa ekleme işlemi yapılmadı.");
                    Console.WriteLine("Kuyruktaki eleman sayısı: "+kuyruk.Count);
                }
                else
                {
                    Console.WriteLine("Birşeyler Yolunda Gitmedi.");

                }
            }
            //var deneme= new Queue<char>();  
            Console.WriteLine("Kuyruktan eleman kaldırılması için 'esc' tuşuna basın ");
            secim1 = Console.ReadKey();
            if (secim1.Key==ConsoleKey.Escape)
            {
                Console.WriteLine();
                while (kuyruk.Count > 0)
                {
                    Console.WriteLine(kuyruk.Peek() + " Kuyruktan çıkartılıyor.");
                    Console.WriteLine(kuyruk.Dequeue() + " kuyruktan çıkartıldı ");
                    Console.WriteLine("Kuyruktan çıkartma işlemi tamamlandı: " + kuyruk.Count + " tane elemana sahip kuyruğumuz.");
                }
                Console.WriteLine(" \n kuyruktan çıkartma işlemi yapıldı.");
            }
            
        }
    }
}
