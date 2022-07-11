using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Value_Type
{
    public struct Nokta
    {
        public int x { get; set; }
        public int y { get; set; }
        public override string ToString()
        {
            return $"{x},{y}"; 
        }
        //default constructer
        //def cons struct yapısında kullanılamaz dolayısıyla elle 
        //bu iafdeyi düzenleme işlemine tabi tutup elle gerekli düzenlemeleri yapıyoruz.
        public Nokta(int X,int Y )
        {
           x = X;
           y = Y;
        }
        //Yapımıza yeni bir üye eklemesi yapabiliriz->Metot
        public void SetOrigin()//Metodun herhangi bir geri dönüş değeri olmadığından metoda void eklemesi yapmak zorundayız.
        {
            this.x = 0;
            this.y = 0;
        }
        public void degistir()
        {
            var gecici = this.x;
            x = y;
            y = gecici;
            //İfadelerin deger tip olduklarını unutmamamız gerekmektedir.

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Struct yapısı değer tiplidir.
            var n1=new Nokta(3,6); n1.degistir();//6,3 degerini alacağız değer tipler sadece value değişikliği yapmaktadırlar.
                          //Console.WriteLine(n1);
            var n2 = n1;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            n2.x= -1 * n2.x;
            Console.WriteLine(n2);
            Console.ReadKey();
        }
    }
}
