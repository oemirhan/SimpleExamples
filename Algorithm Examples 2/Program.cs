using System;
using System.Collections.Generic;

namespace Algorithm_Examples_2
{
    internal class Program
    {
        /*
         * 50 elemandan oluşan bir dizi oluşturulacak ve içine 100 ile 500 arasında rastgele sayılar atanacak.
         * Tek sayıları araya boşluk bırakılarak bir satıra, çift sayıları araya boşluk bırakılarak bir satıra yazdıran
         * C# kodunu yazınız.
         * Örnek:
         * 121 101 341 499 345
         * 100 200 120 340 498
        */

        static void Main()
        {
            int cift, tek;

            List<int> list = CreateRandomNumbers();

            Console.Write("Tek Sayılar: ");

            tek = PrintNumbers(list, false);

            Console.Write("\nÇift Sayılar: ");

            cift = PrintNumbers(list, true);

            Console.WriteLine("\n\nTek Sayı Adedi: " + tek);
            Console.WriteLine("Çift Sayı Adedi: " + cift);

            Console.Write("Çıkmak için bir tuşa basınız...");
            Console.ReadKey();
        }

        private static int PrintNumbers(List<int> list, bool isEvenNumber)
        {
            int count = 0;
            foreach (var memberOfList in list)
            {
                if (isEvenNumber)
                {
                    if (memberOfList % 2 == 0)
                    {
                        Console.Write(memberOfList + " ");
                        count++;
                    }
                }
                else
                {
                    if (memberOfList % 2 != 0)
                    {
                        Console.Write(memberOfList + " ");
                        count++;
                    }
                }
            }
            return count;
        }

        private static List<int> CreateRandomNumbers()
        {
            Random random = new Random();
            List<int> list = new List<int>();

            while (list.Count < 50)
            {
                int randomNumber = random.Next(100, 501);

                if (!list.Contains(randomNumber)) list.Add(randomNumber);
            }

            return list;
        }
    }
}