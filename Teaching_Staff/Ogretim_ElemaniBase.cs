namespace Teaching_Staff
{
    public class Ogretim_ElemaniBase
    {
        //prop and double tab->snippet
        //Property özellik
        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }

        //Override etme(ezme işlemini uygulamış olduk.)
        public override string ToString()
        {
            return $"{SicilNo,-5}\n" +
                $"{Adi,-5}\n" +
                $"{Soyadi,-5}\n" +
                string.Format("{0}", Cinsiyet == true ? "Bay" : "Bayan", 5);
        }
    }
}