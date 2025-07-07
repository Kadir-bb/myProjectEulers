// Palindromik sayılar, tersten okunuşu normal okunuşu ile aynı olan sayılara denir.
// En büyük iki basamaklı iki tane sayının üretebildiği palindrom sayı 9009 dur. (91 * 99)
// Biz ise iki tane üç basamaklı sayılar ile üretilebilecek en büyük palindrom sayıyı bulmaya çalışacağız.

using System.Diagnostics;

namespace C_sharp_proje
{
    class Program4
    {
        static void Main(string[] args)
        {
            string palindrom = "";
            int enBuyukPalindrom = 0, x = 0, y = 0;
            for (int i = 999; i >= 100; i--)
            {
                // arama uzayını burada yarı yarıya küçültmüş oluyoruz. yani 900 x 950 ile 950 * 900 aynı olduğu için bu işlemden burada sıyrılıyoruz.
                for (int j = i; j >= 100; j--)
                {
                    palindrom = (i * j).ToString();

                    if (palindrom == TersCevir(palindrom) && Convert.ToInt32(palindrom) > enBuyukPalindrom)
                    {
                        x = i;
                        y = j;
                        enBuyukPalindrom = Convert.ToInt32(palindrom);
                        break;
                    }
                }
            }
            Console.WriteLine($": 3 basamaklı 2 tane sayı ile oluşturulabilen en büyük palindrom sayı : {x} * {y} = {enBuyukPalindrom}");
            // cevap 993 * 918 = 906609
        }

        static string TersCevir(string palindrom_)
        {
            int diziBoyutu = palindrom_.Length;
            char[] palindromDizi = palindrom_.ToArray<char>();

            for (int i = 0; i < diziBoyutu / 2; i++)
            {
                char karakter = palindrom_[i];
                palindromDizi[i] = palindromDizi[diziBoyutu - (i + 1)];
                palindromDizi[diziBoyutu - (i + 1)] = karakter;
            }
            string strPalindromDizi = new string(palindromDizi);
            return strPalindromDizi;
        }
    }
}