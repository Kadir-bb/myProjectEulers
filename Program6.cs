// ilk 10 doğal sayıların kareleri toplamı 385 (1^2 + 2^2 + ... + 10^2 = 385)
// ilk 10 doğal sayıların toplamının karesi ise 3025 (1 + 2 + 3 + ... + 10)^2 = 3025
// Bu iki değerin arasındaki farka "Toplam Kare Farkı" denir ve buradaki örnek 3025 - 385 = 2640 tır.
// Bizden ise ilk 100 doğal sayının Toplam Kare Farkı isteniyor.

namespace C_sharp_proje
{
    class Program6
    {
        static void Main(string[] args)
        {
            // max deger değiştirilebilir, karelertoplamı en üstte açıklamadaki 1. kısım, parantezkarelertoplamı ise en üstteki 2. kısım
            int maxDeger = 100, karelerToplam = 0, parantezKarelerToplam = 0;
            var dogalSayilar = DogalSayilarListesiOlustur(maxDeger);

            foreach (int dogalSayi in dogalSayilar)
            {
                karelerToplam += dogalSayi * dogalSayi;
                parantezKarelerToplam += dogalSayi;
            }
            parantezKarelerToplam *= parantezKarelerToplam; // parantezKarelerToplam ** 2

            int sonuc = parantezKarelerToplam - karelerToplam;
            Console.WriteLine($"ilk {maxDeger} doğal sayıların Toplam Kare Farkı : {sonuc}");
        }

        // 1 den max değere kadar doğal sayı listesi oluşturalım
        static List<int> DogalSayilarListesiOlustur(int maxDeger_)
        {
            List<int> liste = new List<int>();
            for (int i = 1; i <= maxDeger_; i++)
            {
                liste.Add(i);
            }
            return liste;
        }
    }
}
