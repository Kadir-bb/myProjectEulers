// Belirli bir sayıdan küçük olan bütün asal sayıların toplamını hesaplayan program

namespace C_sharp_proje
{
    class Program10
    {
        static void Main(string[] args)
        {
            long toplam = 0;
            int sayi = 2000000; // soruda belirlenen sayı 2 milyon

            for (int i = 2; i < sayi; i++)
            {
                if (sayiAsalMi(i))
                    toplam += i;
            }
            Console.WriteLine(toplam); // cevap 142913828922
        }

        static bool sayiAsalMi(int sayi_)
        {
            for (int i = 2; i <= Math.Sqrt(sayi_); i++)
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
