// Belirli bir sayıdan küçük olan bütün asal sayıların toplamını hesaplayan program

namespace C_sharp_proje
{
    class Program10
    {
        static void Main(string[] args)
        {
            int sayi = 2000000;
            bool[] asalMi = new bool[sayi];

            Console.WriteLine($"{sayi} sayısına kadar olan asal sayıların toplamı = {asalSayilarToplami(sayi, asalMi)}");
        }

        static long asalSayilarToplami(int sayi_, bool[] asalMi_)
        {
            for (int i = 2; i < sayi_; i++)
            {
                asalMi_[i] = true; // 0 ve 1 hariç olan sayıları asal kabul edelim
            }

            for (int i = 2; i * i < sayi_; i++)
            {
                if (asalMi_[i])
                {
                    for (int j = i * i; j < sayi_; j += i)
                    {
                        asalMi_[j] = false;
                    }
                }
            }
            long toplam = 0;
            for (int i = 2; i < sayi_; i++)
            {
                if (asalMi_[i])
                    toplam += i;
            }
            return toplam;
        }
    }
}
