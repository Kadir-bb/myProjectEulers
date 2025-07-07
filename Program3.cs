// 13915 sayısının asal bölenleri 5,7,13 ve 29 dur.
// Biz ise 600851475143 sayısının en büyük asal bölenini bulacağız.
namespace C_sharp_proje
{
    class Program3
    {
        static void Main(string[] args)
        {
            long soru = 600851475143;
            int soruSayisininKarekoku = (int)Math.Sqrt(soru);
            int asalSayi = 2;
            bool asalMi = true;

            for (int i = soruSayisininKarekoku + 1; i >= 2 + 1; i--)
            {
                if (soru % i == 0) // i sayısı, sorumuzdaki sayının bir böleni ise
                {
                    asalMi = true;
                    for (int j = 2; j < Math.Sqrt(i); j++) // i nin asal olup olmadığının kontrolü
                    {
                        if (i % j == 0) // i, j ye bölünürse asal olmaz
                        {
                            asalMi = false;
                            break;
                        }
                        // şart sağlandı, i asal ve soru sayısını bölüyor, aynı zamanda sorumuzun en büyük asal çarpanı
                    }
                    if (asalMi)
                    {
                        asalSayi = i;
                        break;
                    }
                }
            }
            Console.WriteLine($"{soru} sayisinin en büyük asal böleni : {asalSayi}"); // cevap : 6857
        }
    }
}