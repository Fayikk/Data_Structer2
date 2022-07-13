using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary2
{   public class Personel
    {
        public Personel(string adi, string soyadi, decimal maas)//3 elemana bağlı olarak bir constructer yapısı oluşturmuş olduk.
        {
            Adi = adi;
            Soyadi = soyadi;
            Maas = maas;
        }

        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public decimal Maas { get; set; }

        

    }
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
