using System;
using System.Collections.Generic;

namespace Algorithm_Examples_1
{
    internal class Program
    {
        /*
         * Rastgele 1 ile 100 arasında 15 sayı tutulacak. Tutulan sayılar diziye atanacak ve klavyeden 1 ile 100 arasında
         * bir sayı girilmesi istenecek. Girilen sayı dizide olup olmadığına bakılacak. Girilen sayı
         * varsa “Girdiğiniz sayı bulundu”
         * yoksa “Girdiğiniz sayı bulunamadı” yazdıracak C# kodunu yazınız.
        */

        static void Main()
        {
            List<int> list;
            int chosenNumber;

            Console.WriteLine("Bilgi: Çıkış yapmak için \"e\" tuşunu kullanabilirsiniz...");

            while (true)
            {
                list = CreateRandomNumbers();

                chosenNumber = GetUserInput();

                if (chosenNumber == -1) break; // check exit

                CheckChosenNumber(list, chosenNumber);
            }

            Console.Write("Çıkmak için bir tuşa basınız...");
            Console.ReadKey();
        }

        private static List<int> CreateRandomNumbers()
        {
            Random random = new Random();
            List<int> list = new List<int>();

            for (int i = 0; i < 15; i++)
            {
                int rastgeleSayi = random.Next(1, 101);
                list.Add(rastgeleSayi);
            }

            return list;
        }

        private static int GetUserInput()
        {
            int chosenNumber;
            while (true)
            {
                Console.Write("Lütfen 1 ile 100 arasında bir sayı giriniz: ");
                string girdi = Console.ReadLine();
                girdi = girdi.ToLower();
                if (girdi == "e")
                {
                    return -1;
                }
                else
                {
                    try
                    {
                        chosenNumber = Convert.ToInt32(girdi);
                        if (chosenNumber > 0 && chosenNumber < 101)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("1-100 arasında bir sayı girmediniz!\n");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Bir sayı girmediniz.\n");
                    }
                }
            }
            return chosenNumber;
        }

        private static bool CheckChosenNumber(List<int> list, int chosenNumber)
        {
            foreach (int memberOfList in list)
            {
                if (chosenNumber == memberOfList)
                {
                    Console.WriteLine("Tebrikler! Girdiğiniz " + chosenNumber + " sayısı rastgele sayılar içerisinde bulundu.\n");

                    Console.WriteLine("Sayılar bunlardı:");
                    foreach (var item in list) Console.WriteLine(item);

                    Console.Write("Oyun yeniden başlıyor!\n\n");
                    return true;
                }
                else
                {
                    Console.Write("Seçtiğiniz sayı rastgele sayılar içerisinde bulunamadı.\n\n");
                    return false;
                }
            }
            return false;
        }
    }
}