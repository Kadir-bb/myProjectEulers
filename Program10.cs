// Belirli bir sayıdan küçük olan bütün asal sayıların toplamını hesaplayan program

namespace C_sharp_proje
{
    class Program10
    {
        static void Main(string[] args)
        {
            int sayi = 2000000;

            Console.WriteLine($"{sayi} sayısına kadar olan asal sayıların toplamı = {asalSayilarToplami(sayi)}");
        }

        static long asalSayilarToplami(int sayi_)
        {
            bool[] asalMi = new bool[sayi_];
            for (int i = 2; i < sayi_; i++)
            {
                asalMi[i] = true; // 0 ve 1 hariç olan sayıları asal kabul edelim
            }

            for (int i = 2; i * i < sayi_; i++)
            {
                if (asalMi[i])
                {
                    for (int j = i * i; j < sayi_; j += i)
                    {
                        asalMi[j] = false;
                    }
                }
            }
            long toplam = 0;
            for (int i = 2; i < sayi_; i++)
            {
                if (asalMi[i])
                    toplam += i;
            }
            return toplam;
        }
    }
}
