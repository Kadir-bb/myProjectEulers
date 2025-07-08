// 1 ile 10 arasındaki (dahil) sayıları bölenleri olarak kabul eden en küçük sayı 2520 dir.
// Bizden istenen ise bölenleri 1 ile 20 arasında olan bu en küçük sayıyı bulmak.

namespace C_sharp_proje
{
    class Program5
    {
        static void Main(string[] args)
        {
            List<int> asalSayilar = new List<int>();
            int sayiAraligi = 20; // Bu değeri değiştirerek 1 den 'sayiAraligi' na kadar olan sayıların ekokunu hesaplayabiliriz.
            int sayi = 1;

            // asal sayiları belirlediğimiz kısım
            for (int i = 2; i <= sayiAraligi; i++)
            {
                if (sayiAsalMi(i))
                {
                    asalSayilar.Add(i);
                }
            }

            // asal sayıları listeye aldık, kullanılma sıklıklarına göre bunları göstereceğiz (asal sayi, kullanılma sıklığı)
            List<(int, int)> sayiyiOlustur = new List<(int, int)>();
            foreach (int asalSayi in asalSayilar)
            {
                int sayininUssu = 0; // asal sayinin üs / kuvvet kısmı
                sayiyiOlustur.Add((asalSayi, sayininUssu));
                for (int i = asalSayi; i < sayiAraligi;)
                {
                    i *= asalSayi;
                    sayiyiOlustur[asalSayilar.IndexOf(asalSayi)] = (asalSayi, ++sayininUssu);
                }
            }
            foreach ((int, int) eleman in sayiyiOlustur)
            {
                sayi *= (int)Math.Pow(eleman.Item1, eleman.Item2);  // eleman1 taban sayımız, eleman2 üs sayımız 
            }
            Console.WriteLine($"1 den {sayiAraligi} aralığına (dahil) kadar olan sayıların EKOK'u {sayi}"); // cevap: 232792560
        }

        static bool sayiAsalMi(int sayi_)
        {
            for (int i = 2; i < sayi_; i++)
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
