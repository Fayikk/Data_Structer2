using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComporable

{   
    
    
    
    //IComparable ile sınıfımıza karşılaştırma özelliği kazandırmış olduk.
    public class Sehir:IComparable<Sehir>
    {

        public int PlakaNo { get; set; }
        public string SehirAdi { get; set; }
        public Sehir(int plakaNo, string sehirAdi)
        {
            PlakaNo = plakaNo;
            SehirAdi = sehirAdi;
        }
        public override string ToString()
        {
            return $"{PlakaNo, -10} {SehirAdi,-10}";//İnterpolasyon işlemi gerçekleştirdik.
        }

        public int CompareTo(Sehir other)
        {
            if (this.PlakaNo<other.PlakaNo)
            {
                return -1;
            }
            else if (this.PlakaNo == other.PlakaNo)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Lİst
            var sayilar = new List<int>()
            {
                19,98,15,45,75,67
            };
            sayilar.Sort();
            sayilar.ForEach(s => Console.WriteLine(s));

            //Sehir listesi
            var sehirler = new List<Sehir>()
            {
                new Sehir(6,"Ankara"),
                new Sehir(23, "Elazığ"),
                new Sehir(21, "Diyarbakır"),
                new Sehir(34, "İstanbul"),
                new Sehir(44, "Malatya"),

            };
            sehirler.Add(new Sehir(01, "Adana"));
            sehirler.Sort();
            sehirler.ForEach(s => Console.WriteLine(s));
        }
    }
}
