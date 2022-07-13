using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_applications
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan sayı istenecek ve birler onlar ve yüzler basamağı ayrı ayrı eklenecektir.
            Console.WriteLine("Yığın yapısına eklenmesini istediğiniz sayıyı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var sayiyigini = new Stack<int>();

            while (sayi>0)
            {
                int k = sayi % 10;
                sayiyigini.Push(k);
                sayi=sayi/10;
            }

            int i = 0;
            int n = sayiyigini.Count-1;
            foreach (var s in sayiyigini)
            {
                Console.WriteLine("sayı: " + s + " *" + Math.Pow(10,n-i)+"="+ s*Math.Pow(10,n-i));
            }
            
            
            ;
        }
    }
}
