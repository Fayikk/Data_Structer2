using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class Program
    {
        static void Main(string[] args)
        {
            //stack tanımlama
            var karakterYigini = new Stack<char>();//stack of char deklare'si.
            for (int i = 0; i < 90; i++)
            {
                karakterYigini.Push((char)i);
                Console.WriteLine("eklenen karakter: "+(char)i);
            
            }
            Console.WriteLine("Yığındaki eleman sayısı: " + karakterYigini.Count());

            Console.WriteLine("Yığından çıkarma işlemi için bir tuşa basınız.");
            Console.ReadKey();

            while (karakterYigini.Count>0)
            {
                Console.WriteLine(karakterYigini.Pop()+"  yığından çıkartıldı.");
                Console.WriteLine("Yığındaki eleman sayısı: "+karakterYigini.Count());

            }
            //Yığındaki ifadeleri diziye aktarmak
            var dizi = karakterYigini.ToArray();

            //Ekleme
            karakterYigini.Push('F');
            Console.WriteLine(karakterYigini.Peek());//Hangi ifadenin eklendiğini görmek için peek() ifadesini kullanıyoruz.
            karakterYigini.Push('A');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('Y');
            Console.WriteLine(karakterYigini.Peek());

            karakterYigini.Push('İ');
            Console.WriteLine(karakterYigini.Peek());

            karakterYigini.Push('K');
            Console.WriteLine(karakterYigini.Peek());

            //Yığından Çıkarma işlemini yapalım
            Console.WriteLine(karakterYigini.Pop() +":"+ "yıgından çıkartıldı.");
            Console.WriteLine(karakterYigini.Pop() +":"+ "yıgından çıkartıldı.");
            Console.WriteLine(karakterYigini.Pop() +":"+ "yıgından çıkartıldı.");
            Console.WriteLine(karakterYigini.Pop() +":"+ "yıgından çıkartıldı.");
            Console.WriteLine(karakterYigini.Pop() +":"+ "yıgından çıkartıldı.");
        }
    }
}
