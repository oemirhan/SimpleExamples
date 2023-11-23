using System;
using System.Collections.Generic;

namespace Algorithm_Examples_4
{
    internal class Program
    {
        // Kullanıcının verdiği sayı miktarı kadar sayının;
        // karelerini, toplamını ve karelerinin toplamını
        // hesaplayan programı yazınız.

        static void Main()
        {
            List<int> list = new List<int>();

            int sumOfSquares = 0, squareOfNumber, sumOfNumbers = 0;

            int numberOfNumber = GetUserInputAndConvert(true);

            for (int i = 0; i < numberOfNumber; i++)
            {
                int sayi = GetUserInputAndConvert(false);
                list.Add(sayi);
            }

            Console.WriteLine();

            foreach (int number in list)
            {
                Console.WriteLine("Sayı: " + number);
                squareOfNumber = number * number;
                Console.WriteLine("Sayının Karesi: " + squareOfNumber + "\n");
                sumOfNumbers += number;
                sumOfSquares += squareOfNumber;
            }
            Console.WriteLine("Kareler Toplamı: " + sumOfSquares);

            Console.Write("Çıkmak için bir tuşa basınız...");
            Console.ReadKey();
        }

        static int GetUserInputAndConvert(bool first)
        {
            int returnNumber;
            string text = (first)? "Kaç sayı hesaplanacak? -> ": "Sayı giriniz -> ";

            while (true)
            {
                try
                {
                    Console.Write(text);

                    string girdi = Console.ReadLine();
                    returnNumber = Convert.ToInt32(girdi);

                    if (first)
                    {
                        if (returnNumber > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen sıfırdan büyük bir sayı giriniz.");
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Lütfen bir sayı giriniz.");
                }
            }
            return returnNumber;
        }
    }
}