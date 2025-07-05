// 10 dan küçük doğal sayılardan 3 veya 5 in katı olan sayılar : 3, 5, 6 ve 9 dur.
// buna göre 1000 den küçük doğal sayıların 3 veya 5 in katı olan sayıları bul.
namespace C_sharp_proje
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    toplam += i;
                }
            }
            Console.WriteLine("toplam : " + toplam); // cevap : 233168
        }
    }

}