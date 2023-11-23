using System;

namespace Algorithm_Examples_3
{
    internal class Program
    {
        // Sayı tahmin etme oyunu. Sayı doğru bilindiği zaman
        // kaçıncı seferde sayının tahmin edildiği söylensin.
        // Kaç tane sayı olacağını da kullanıcı seçsin.

        static void Main()
        {
            Random random = new Random();

            int randomNumber, maximumNumber, countOfTry = 1;
            string loop;

            Console.Write("Sonsuz Oyun - Sayıyı bildinizde devam etsin mi? Varsayılan: Hayır (E/H) -> ");
            loop = Console.ReadLine().ToLower();

            if (loop != "h" && loop != "e") loop = "h";

            maximumNumber = GetUserInputAndConvert(true, null);
            randomNumber = random.Next(0, maximumNumber);

            while (true)
            {
                int userInput = GetUserInputAndConvert(false, maximumNumber);

                if (userInput == randomNumber)
                {
                    Console.WriteLine("Sayıyı bildiniz! " + countOfTry + " kez denediniz.");
                    if (loop == "h")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Oyun Sıfırlanıyor...\n\n");
                        countOfTry = 1;
                        randomNumber = random.Next(0, maximumNumber);
                    }
                }
                else
                {
                    string errorText = (userInput > maximumNumber) ? "Sayı maksimum sayıdan büyük" : "Sayıyı bilemediniz";
                    Console.WriteLine(errorText + ". Tekrar deneyiniz.");

                    countOfTry++;
                }
            }

            Console.Write("Çıkmak için bir tuşa basınız...");
            Console.ReadKey();
        }

        static int GetUserInputAndConvert(bool first, int? maximumNumber)
        {
            int returnNumber, minimumNumber;
            string
            text = (first)?
                "Sayı 0 ile kaç arasında olsun? (sadece pozitif sayılar) -> "
              : "Sayıyı tahmin edin 0-" + maximumNumber + " (dahil) arasında bir sayı giriniz: ",

            errorText = (first)?
                "Lütfen altıdan büyük bir sayı giriniz."
              : "Lütfen pozitif bir sayı giriniz.";

            minimumNumber = (first) ? 7 : 0;

            while (true)
            {
                Console.Write(text);

                string input = Console.ReadLine();

                try
                {
                    returnNumber = Convert.ToInt32(input);

                    if (returnNumber >= minimumNumber) { break; }
                    else
                    {
                        Console.WriteLine(errorText);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lütfen bir sayı giriniz.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Yazdığınız sayı limitlerin dışında. Sıfıra daha yakın bir sayı seçiniz.");
                }
            }
            return returnNumber;
        }
    }
}