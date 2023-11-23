using System;

namespace Algorithm_Examples_5
{
    internal class Program
    {
        // if-else / Ders Geçme-Kalma ve Ortalama Hesaplama Uygulaması

        static void Main()
        {
            var not1 = GetUserInput("Birinci notu giriniz: ");
            var not2 = GetUserInput("İkinci notu giriniz: ");
            var not3 = GetUserInput("Üçüncü notu giriniz: ");

            int ortalama = (not1 + not2 + not3) / 3;

            Console.WriteLine("Not Ortalamanız: " + ortalama);

            string status = (ortalama >= 50) ? "Geçtiniz!" : "Kaldınız.";
            Console.WriteLine(status);

            Console.Write("Çıkmak için bir tuşa basınız...");
            Console.ReadKey();
        }

        static int GetUserInput(string text)
        {
            Console.Write(text);

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}