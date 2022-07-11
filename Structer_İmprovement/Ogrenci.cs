namespace Structer_İmprovement
{
    public struct Ogrenci {
        public Ogrenci(int numara, string adi, string soyadi,
            bool cinsiyet=true)
        {
            Numara = numara;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public int Numara { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }

        //Bir metodu geçersiz kılmak/ezmek/override process:
        public override string ToString()
        {
            return $"{Numara} {Adi} {Soyadi} "
                + string.Format("{0,5}", Cinsiyet == true ? "Bay" : "Bayan", 5);
        }
        
    }
}
