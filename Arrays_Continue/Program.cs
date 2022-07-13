using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Continue
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[] {5,17,9,48,6};
            var numbers = Array.CreateInstance(typeof(int), 5);
            var arr = new ArrayList(sayilar);

            //setvalue fonksiyonu ile gerekli güncellemelride yapabiliriz.
            numbers.SetValue(1, 0);
            numbers.SetValue(2, 1); 
            numbers.SetValue(6, 2);
            numbers.SetValue(4, 3);
            numbers.SetValue(5, 4);
            //numbers.SetValue(6, 5);


           

            arr[0] = 9;
            arr[1] = 3;
            arr[2] = 1;
            arr[3] = 2;
            arr[4] = 6;

            sayilar.CopyTo(numbers, 0);
            Array.Sort(sayilar);//Sıralama işlemlerimizi küçükten büyüğe doğru sıralar.



            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"sayilar[{i}] =" +
                                    $"{sayilar[i],3} - " +
                                    $"numbers[{i}]" +
                                    $"{numbers.GetValue(i),3}" +
                                    $"arr[{i}]=" +
                                    $"{arr[i],3}");
            }
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers.GetValue(i)+"\n");
            }
            //Sort() ifadesi sıralama işlemlerimizi gerçekleştirir.
            
                        
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.WriteLine(arr[2]);

        }
    }
}
