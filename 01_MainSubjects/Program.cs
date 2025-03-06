using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma komutları
            //Console.Write("Merhaba Dünya");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Salatalar");
            //Console.WriteLine("4- Tatalılar");
            //Console.WriteLine("5- İçecekler");
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion


            #region String Değişkenler
            //string name;
            //name = "Mert";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Mert";
            //customerSurname = "Kaptan";
            //customerPhone = "0532 123 45 67";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";


            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("E-Posta: " + customerEmail);
            //Console.WriteLine("Adres: " + district + " / " + city);
            //Console.WriteLine("------------------------------------");


            //customerName = "Ali";
            //customerSurname = "kaya";
            //customerPhone = "0532 123 45 67";
            //customerEmail = "test@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";
            //Console.WriteLine();

            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("E-Posta: " + customerEmail);
            //Console.WriteLine("Adres: " + district + " / " + city);
            //Console.WriteLine("------------------------------------");

            #endregion


            #region Int Değişkenler

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;


            Console.WriteLine("**** Menü Fiyatları ****");
            Console.WriteLine();
            Console.WriteLine("Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("Kola: " + cokePrice + " TL");
            Console.WriteLine("Su: " + waterPrice + " TL");
            Console.WriteLine("Patates Kızartması: " + friesPrice + " TL");
            Console.WriteLine("Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("**** Menü Fiyatları ****");


            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaCount;
            int totalLemonadePrice;

            hamburgerCount = 2;
            cokeCount = 1;
            waterCount = 1;
            friesCount = 1;
            pizzaCount = 1;
            lemonadeCount = 2;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaCount = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;


            Console.WriteLine("--------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Patates Kızartması Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaCount + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("--------------------------");

            Console.WriteLine();
            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaCount + totalLemonadePrice;
            Console.WriteLine("Toplam Tutar: " + (totalPrice) + " TL");


            #endregion

        }
    }
}
