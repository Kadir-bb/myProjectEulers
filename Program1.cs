// 10 dan küçük doğal sayılardan 3 veya 5 in katı olan sayılar : 3, 5, 6 ve 9 dur.
// buna göre 1000 den küçük doğal sayıların 3 veya 5 in katı olan sayıları bul.
namespace C_sharp_proje
{
    class Program1
    {
        static void Main(string[] args)
        {
            int ustDeger, mod1, mod2;

            ustDeger = 1000;
            mod1 = 3;
            mod2 = 5;

            Console.WriteLine($"x £ [0,{ustDeger}), x £ (x % {mod1} == 0 && x % {mod2} == 0) olan x sayılarının toplamı = {SoruToplamBul(ustDeger, mod1, mod2)}");
        }

        // Bu fonksiyon, 0 dan ustDeger değişkenine kadar (ustDeger dahil değil), mod1 ve mod2 ye tam olarak bölünebilen sayıların toplamını hesaplar.
        static int SoruToplamBul(int ustDeger_, int mod1_, int mod2_)
        {
            int toplam = 0;
            for (int i = 0; i < ustDeger_; i++)
            {
                if (i % mod1_ == 0 || i % mod2_ == 0)
                {
                    toplam += i;
                }
            }
            return toplam;
        }
    }

}
