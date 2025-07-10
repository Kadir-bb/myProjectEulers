// Bir Pisagor üçlüsü, üç doğal sayıdan oluşur. Kenarları şu koşulu sağlasın diyelim. (a < b < c)
// a + b + c = 1000 koşulunu sağlayan sadece bir tane pisagor üçlüsü var ve bizden bunu bulmamız isteniyor.

namespace C_sharp_proje
{
    class Program9
    {
        static void Main(string[] args)
        {
            int a, b, c, m, n, toplam = 1000; // toplam -> a + b + c

            for (m = 1; m < toplam; m++)
            {
                for (n = 1; n < m; n++) // m > n > 0 koşulu pisagor üçlüleri için sağlanmalı.
                {
                    a = (int)(Math.Pow(m, 2)) - (int)(Math.Pow(n, 2)); // a = m^2 - n^2
                    b = 2 * m * n; // b = 2*m*n
                    c = (int)(Math.Pow(m, 2)) + (int)(Math.Pow(n, 2)); // c = m^2 + n^2

                    if (a + b + c == toplam)
                    {
                        Console.WriteLine(a * b * c); // cevap 31875000
                        return;
                    }
                }
            }
        }
    }
}
