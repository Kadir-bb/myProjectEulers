// 10 dan küçük doğal sayılardan 3 veya 5 in katı olan sayılar : 3, 5, 6 ve 9 dur.
// buna göre 1000 den küçük doğal sayıların 3 veya 5 in katı olan sayıları bul.

namespace C_sharp_proje
{
    class Program1
    {
        static void Main(string[] args)
        {
            int ustDeger, mod1, mod2;
            string islemTipi;

            ustDeger = 1000;
            mod1 = 3;
            mod2 = 5;
            islemTipi = "veya"; // ve/veya işlemleri

            if (SoruToplamBul(ustDeger, mod1, mod2, islemTipi) != -1)
            {
                Console.Write($"0 dan {ustDeger} sayısına kadar olan, {mod1} {islemTipi} {mod2} sayılarına kalansız bölünebilen ");
                Console.Write($"sayıların toplamı = {SoruToplamBul(ustDeger, mod1, mod2, islemTipi)}");
            }
        }

        // Bu fonksiyon, 0 dan ustDeger değişkenine kadar (ustDeger dahil değil), mod1 ve/veya mod2 ye tam olarak bölünebilen sayıların toplamını hesaplar.
        static int SoruToplamBul(int ustDeger_, int mod1_, int mod2_, string islemTipi_)
        {
            int toplam = 0;
            switch (islemTipi_)
            {
                case "veya":
                    for (int i = 0; i < ustDeger_; i++)
                    {
                        if (i % mod1_ == 0 || i % mod2_ == 0)
                        {
                            toplam += i;
                        }
                    }
                    return toplam;
                case "ve":
                    for (int i = 0; i < ustDeger_; i++)
                    {
                        if (i % mod1_ == 0 && i % mod2_ == 0)
                        {
                            toplam += i;
                        }
                    }
                    return toplam;
                default:
                    return -1;
            }

        }
    }

}
