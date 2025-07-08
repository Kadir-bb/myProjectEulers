// Bu örnekte bizden istenen şey, ilk 10001. asal sayı 
// (sıra değişkenine göre hangi asal sayının kaçıncı asal sayı olduğunu gösteren program)

namespace C_sharp_proje
{
    class Program7
    {
        static void Main(string[] args)
        {
            int sayi = 2;
            int sira = 10001 /*asal sayının kaçıncı sırada olduğu*/ , geciciSira = sira;
            while (true)
            {
                if (asalMi(sayi))
                {
                    geciciSira--;
                    if (geciciSira == 0)
                    {
                        Console.WriteLine($"{sira}. sıradaki asal sayi : {sayi}");
                        return;
                    }
                }
                sayi++;
            }
        }

        static bool asalMi(int sayi_)
        {
            for (int i = 2; i < (int)Math.Sqrt(sayi_) + 1; i++)
            {
                if (sayi_ % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
