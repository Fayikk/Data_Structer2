using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var numbers = Array.CreateInstance(typeof(int),10);
            numbers.SetValue(5, 0);
            numbers.SetValue(6, 1);
            numbers.SetValue(7, 2);
            numbers.SetValue(8, 3);
            numbers.SetValue(9, 4);
            numbers.SetValue(31,5);
            numbers.SetValue(65, 9);
            //Yukarıda var değişkeni ile atamasını yaptığımız numbers'a değer ataması yapmak için.
            //SetValue metodu kullanmamız gerekecektir.
            //Dolaşma
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("sayilar[{0}] = {1} - numbers[{0}] = {2}",
                                    i, sayilar[i], numbers.GetValue(i));
            }
        }
    }
}
