using System;

namespace Algorithm_Examples_6
{
    internal class Program
    {
        // login / Kullanıcı Giriş Uygulaması

        static void Main()
        {
            Console.Write("Kullanıcı Adınızı Giriniz: ");
            string kullaniciAdi = Console.ReadLine().ToLower();

            if (kullaniciAdi == "emirhan")
            {
                Console.Write("Şifrenizi Giriniz: ");
                string sifre = Console.ReadLine();

                if (sifre == "123")
                {
                    Console.WriteLine("Giriş başarılı.");
                }
                else
                {
                    Console.WriteLine("Şifre yanlış.");
                }
            }
            else
            {
                Console.WriteLine("Kullanıcı adı yanlış.");
            }

            Console.Write("Çıkmak için bir tuşa basınız...");
            Console.ReadKey();
        }
    }
}
