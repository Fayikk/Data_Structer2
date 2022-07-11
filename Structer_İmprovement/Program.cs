using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structer_İmprovement
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //interpolasyon
            //Console.WriteLine(
            //    $"{ogr4.Numara}\n"
            //    + $"{ogr4.Adi}\n" +
            //    $"{ogr4.Soyadi}\n" +
            //    $"{ogr4.Cinsiyet}");//farkettiyseniz cinsiyet tanımını yukarıda yapmadık 
            //Nedeni ise zaten struct yapımız içerisinde onun oluşturduğumuz constructer'ında default olarak true değeri atamıştık.

            
            var ogrencilistesi = new List<Ogrenci>() { 
            new Ogrenci(20, "Buse", "Karlidağ",false),
            new Ogrenci(23, "Fayik", "Veznedaroglu",true)

        };
                //Lambda expression metodu kullanmış olduk.
                ogrencilistesi.ForEach(o => Console.WriteLine(o));
            
           
        }
    }
}
