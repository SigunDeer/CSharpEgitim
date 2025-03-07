using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            #region if Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "Ankara" & country == "Türkiye")
            //{
            //    Console.WriteLine("Başkent ve Ülke doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Başkent ve Ülke yanlış.");
            //}

            //int number;
            //Console.Write("Bir sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number==5)
            //{
            //    Console.WriteLine("Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış");
            //}


            //int exam1 , exam2, exam3, average;
            //string result= "\nHata!";

            //Console.Write("1. Sınav Notu: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notu: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notu: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınavların ortalaması: " + average);

            //if (average >= 90)
            //{
            //    result = "Tebrikler";
            //}
            //else if (average >= 70 & average <90)
            //{
            //    result = "Orta";
            //}

            //Console.WriteLine(result);
            #endregion

            #region Örnek Proje uygulaması

            //int number;
            //number = 26;
            //int result = number % 25;
            //Console.WriteLine(result);

            //Console.WriteLine("**** Menü ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-------------");

            //string menuItem;

            //Console.Write("Menü seçimini yapın");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----Ana Yemekler----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-İskender");
            //    Console.WriteLine("2-Kebap");
            //    Console.WriteLine("3-Tavuk");
            //    Console.WriteLine("4-Köfte");
            //}

            int number1, number2, result;
            char symbol;

            Console.Write("1. Sayıyı giriniz: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("İşlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Sonuç: " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Sonuç: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Sonuç: " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Sonuç: " + result);
                    break;
                default:
                    Console.WriteLine("Hatalı işlem");
                    break;
            }
            #endregion
        }
    }
}
