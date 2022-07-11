using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structer2
{
    public class Program
    {
        static void Main(string[] args)
        {

            //SByte deneme = 128;
            /*Console.WriteLine(deneme);*///Burada hata alırız çünkü SByte ifadesi pozitif 127 sayısını tutabilecek kadar yere sahiptir.


            //8-bit integer
            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Alt limit  : {SByte.MinValue}");
            //sbyte tipinin minimum değerini verir
            Console.WriteLine($"Üst limit  : {SByte.MaxValue}");
            //maksimum değerini verir
            Console.WriteLine($"{sizeof(SByte),20}");
            Console.ReadKey();

            //Unsigned 8-bit integer
            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"Alt limit  : {Byte.MinValue}");
            Console.WriteLine($"Üst limit  : {Byte.MaxValue}");
            Console.WriteLine($"{sizeof(Byte),20}");
            Console.ReadKey();

            //signed 16-bit integer
            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"Alt limit  : {Int16.MinValue}");
            Console.WriteLine($"Üst limit  : {Int16.MaxValue}");
            Console.WriteLine($"{sizeof(Int16),20}");
            Console.ReadKey();

            //Unsigned 16-bit integer
            Console.WriteLine(nameof(UInt16));
            Console.WriteLine($"Alt limit  : {UInt16.MinValue}");
            Console.WriteLine($"Üst limit  : {UInt16.MaxValue}");
            Console.WriteLine($"{sizeof(UInt16),20}");
            Console.ReadKey();


            //signed 32-bit integer
            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Alt limit  : {Int32.MinValue}");
            Console.WriteLine($"Üst limit  : {Int32.MaxValue}");
            Console.WriteLine($"{sizeof(Int32),20}");
            Console.ReadKey();

            //Double
            Console.WriteLine(nameof(Double));
            Console.WriteLine($"Alt limit  : {Double.MinValue}");
            Console.WriteLine($"Üst limit  : {Double.MaxValue}");
            Console.WriteLine($"{sizeof(Double),20}");
            Console.ReadKey();
            Console.WriteLine();


            //İnteger
            Console.WriteLine(sizeof(int));
        }
    }
}
