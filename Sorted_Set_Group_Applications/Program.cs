using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_Set_Group_Applications
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sorted set Küme işlemleri
            var A = new SortedSet<int>() { 1,2,3,4};//Rastgele 100 sayı oluşturduk.
            var B = new SortedSet<int>() { 1,2,5,6};
            #region

          


            Console.WriteLine();
            Console.WriteLine("A kümesi");
            foreach (int s in A)
            {
                Console.WriteLine($"{s,5}");
            }
            Console.WriteLine();
            Console.WriteLine("B kümesi");
            foreach (int s in B)
            {
                Console.WriteLine($"{s,5}");
            }
            #endregion

            A.UnionWith(B);
            Console.WriteLine("A ve B kümlesinin birleşimi");
            foreach (var s in A)
            {
                Console.WriteLine($"{s,5}");
            }

            A.IntersectWith(B);//A kümesinde olup,B kümesinde olmayan ne var.
            Console.WriteLine("A ve B kümelerinin kesişimi");
            foreach (var s in A)
            {
                Console.WriteLine($"{s,5}");
            }

            A.ExceptWith(B);
            Console.WriteLine("Bu bir denemedir.-----");
            foreach (var s in A)
            {
                Console.WriteLine($"{s,5}");
            }


        }
        static List<int> RastgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(0, 1000));
                
            }
            return list;
        }
    }
}
