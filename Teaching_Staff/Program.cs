using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teaching_Staff
{
    public class Ogretim_Elemani : Ogretim_ElemaniBase
    {
        //Bu bir default constructer'dır.
        public Ogretim_Elemani()
        {
            Console.WriteLine("Constructer calisti")
;        }
        //Default constructer dışında elle yazılan constructer ifadesini bu şekilde ayarlayabiliriz.
        public Ogretim_Elemani(int sicilNo, string adi, string soyadi, bool cinsiyet)
        {
            SicilNo = sicilNo;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            //Tanıma ifadesinin yapıldığı kısımdayız
            //Ogretim_Elemani ogrGor = new Ogretim_Elemani(9897,"fayik","veznedaroglu",true)
            {
                //Öğretim elemanlarının property'lerine direkmen buradan ulaşabiliriz.
                //Adi = "Muhammed Emre",
                //Soyadi = "Çolak",
                //SicilNo = 2345,
                //Cinsiyet = true,
                
            };

            //Örtülü değişken tanımı yapalım.
            var ogretimelemanılistesi = new List<Ogretim_Elemani>()
            {
                //süslü parantezler içerisine elemanlarımızı ekleyelim.
                new Ogretim_Elemani(100,"nigar","bulut",false),
                new Ogretim_Elemani(101,"kübra","arslan",false),
                new Ogretim_Elemani(102,"Bilal","alataş",true),
                new Ogretim_Elemani(103,"Sergen","deveci",true),
                new Ogretim_Elemani(104,"demet","özbağ",false),
                new Ogretim_Elemani(105,"Kader","deniz",false),


            };
           //ogretimelemanılistesi.ForEach(personel=>Console.WriteLine(personel+"\n"));

            var ogretimelemanılistesi2 = ogretimelemanılistesi;
            //ogretimelemanılistesi2.ForEach(personel2=>Console.WriteLine(personel2+"\n"));

            ogretimelemanılistesi2.Add(new Ogretim_Elemani(106, "Kenan", "Subaşı", true));
            ogretimelemanılistesi2.RemoveAt(0);
            //ogretimeelemanı2'ye ekleme yapıldı
            ogretimelemanılistesi.ForEach(personel => Console.WriteLine(personel + "\n"));
            ogretimelemanılistesi2.ForEach(personel2=>Console.WriteLine(personel2+"\n"));
            //Son eklenen kenan subaşı ifadesi her iki yapıda referans tip oldukları için değişiklikler her ikisinede atanmış oldu.
            //aynı şekilde removeAt komutuyla silinen 0 indeksli karakterde her iki listeden'de silinmiş oldular. 
            
            
            
            Console.ReadKey();
            
            //Atama kısmındayız
            //ogrGor.Adi = "Mustafa";
            //ogrGor.Soyadi = "Ulaş";
            //ogrGor.SicilNo = 1234;
            //ogrGor.Cinsiyet = true;

            
        }
    }
}
