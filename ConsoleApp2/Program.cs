/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = int.Parse(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = int.Parse(Console.ReadLine());


        int fark = sayi1 - sayi2;


        Console.WriteLine($"iki sayının farkı: {fark}");

using System;


class Program
{
    static void Main()
    {
        int sayi = 5;
        int karesi = sayi * sayi;


        Console.WriteLine($"{sayi} sayısının karesi: {karesi}");
    }
}
*/
/*
using System;
using System.Xml.Serialization;

class Program
{
    static void Main()
    {
        int sayi = 10;
        int bolen = 3;
        int kalan = sayi % bolen;


        Console.WriteLine($"{sayi} sayısının {bolen} ile bölümünden kalan: {kalan}");
    }
}
*/

/*
using System;

class Program
{
    static void Main()
    {

        Console.Write("1.sayıyı girin: ");
        int sayi1 = int.Parse(Console.ReadLine());

        Console.Write("2. sayıyı girin: ");
        int sayi2 = int.Parse(Console.ReadLine());

        Console.Write("3.sayıyı girin: ");
        int sayi3 = int.Parse(Console.ReadLine());

        Console.Write("4.sayıyı girin: ");
        int sayi4 = int.Parse(Console.ReadLine());


        int toplam = sayi1 + sayi2 + sayi3 + sayi4;
        int carpim = sayi1 * sayi2 * sayi3 * sayi4;


        Console.WriteLine($"Toplam: {toplam}");
        Console.WriteLine($"Çarpım: {carpim}");
    }
}
*/
/*
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("1.sayıyı girin: ");
            double sayi1 = double.Parse(Console.ReadLine());

            Console.Write("2.sayıyı girin: ");
            double sayi2 = double.Parse(Console.ReadLine());



            if (sayi2 == 0)
            {
                Console.WriteLine("Bir sayı 0'a bölünemez!");
            }
            else
            {

                double bolum = sayi1 / sayi2;
                Console.WriteLine($"Bölüm: {bolum}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Lütfen geçerli bir sayı girin.");
        }
    }
}
*/
/*
using System;
class Program
{
    static void Main()
    {
        try
        {

            Console.Write("Uzun kenarı girin: ");
            double uzunkenar = double.Parse(Console.ReadLine());

            Console.Write("Kısa kenar girin: ");
            double kısakenar = double.Parse(Console.ReadLine());

            Console.Write("Yüksekliği girin: ");
            double yukseklik = double.Parse(Console.ReadLine());


            double hacim = uzunkenar * kısakenar * yukseklik;



            Console.WriteLine($"Dikdörtgenler prizmasının hacmi: {hacim}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Lütfen geçerli bir sayı girin.");
        }
    }
}
*/