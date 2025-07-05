// Bir fibonacci dizisindeki her yeni terim, kendinden önceki 2 terimin toplanması ile üretilir.
// Elimizde 1 ve 2 ile başlayan fibonacci dizisi olsun, bu dizinin son terimi 4 milyonu geçmeyecek şekilde olsun.
// Bu dizideki çift değerli terimlerin toplamını bul.

namespace C_sharp_proje
{
    class Program
    {
        static void Main(string[] args)
        {
            int birinciSayi = 1, ikinciSayi = 2, uretilenSayi = 0, toplam = 2; // toplama 2 terimini dahil ettik.

            while (uretilenSayi < 4000000)
            {
                uretilenSayi = birinciSayi + ikinciSayi;
                if (uretilenSayi % 2 == 0)
                {
                    toplam += uretilenSayi;
                }
                birinciSayi = ikinciSayi;
                ikinciSayi = uretilenSayi;
            }

            Console.WriteLine("Fibonacci dizisindeki terimlerin toplamı : " + toplam); // cevap 4613732

        }
    }

}
