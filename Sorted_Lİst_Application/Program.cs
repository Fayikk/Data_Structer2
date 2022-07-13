using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_Lİst_Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Kitapicerigi = new SortedList()
            {
                //Key değerim sayfa numaram,Value değerim sayfa içeriği olsun.

            };
            Kitapicerigi.Add(1, "Önsöz");
            Kitapicerigi.Add(50, "Degiskenler");
            Kitapicerigi.Add(40,"Operatörler");
            Kitapicerigi.Add(77, "Döngüler");
            Kitapicerigi.Add(45, "İlişkisel operatörler");
            Console.WriteLine("-----İÇİNDEKİLER-----");
            foreach (DictionaryEntry item in Kitapicerigi)
            {
                Console.WriteLine("Sayfa sayisi: " + item.Key + "   Sayfa İçeriği: " + item.Value);
                //Sorted listler yapıları gereği girilen sayıları kendi aralarında sıralam işlemine tabii tutarlar.
            }

        }
    }
}
