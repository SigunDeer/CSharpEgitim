using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Double değişkenler
            ////double number;
            ////number = 4.85;
            ////Console.WriteLine(number);

            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePrice , orangePrice , strawberryPrice ,potatoPrice, tomatoPrice;

            //applePrice = 3.5;
            //orangePrice = 2.5;
            //strawberryPrice = 14.5;
            //potatoPrice = 2.5;
            //tomatoPrice = 3.5;

            //Console.WriteLine("---- Elma Birim Fiyat: " + applePrice);
            //Console.WriteLine("---- Portakal Birim Fiyat: " + orangePrice);
            //Console.WriteLine("---- Çilek Birim Fiyat: " + strawberryPrice);
            //Console.WriteLine("---- Patates Birim Fiyat: " + potatoPrice);
            //Console.WriteLine("---- Domates Birim Fiyat: " + tomatoPrice); 

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.250;
            //orangeGram = 1.500;
            //strawberryGram = 0.500;
            //potatoGram = 2.000;
            //tomatoGram = 3.600;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: Elma  \nMiktar: " + appleGram + "  \nToplam Fiyat: " + appleTotalPrice);
            //Console.WriteLine("-----------");
            //Console.WriteLine("Alınan Ürün: Portakal  \nMiktar: " + orangeGram + "  \nToplam Fiyat: " + orangeTotalPrice);
            //Console.WriteLine("-----------");
            //Console.WriteLine("Alınan Ürün: Çilek  \nMiktar: " + strawberryGram + "  \nToplam Fiyat: " + strawberryTotalPrice);
            //Console.WriteLine("-----------");
            //Console.WriteLine("Alınan Ürün: Patates  \nMiktar: " + potatoGram + "  \nToplam Fiyat: " + potatoTotalPrice);
            //Console.WriteLine("-----------");
            //Console.WriteLine("Alınan Ürün: Domates  \nMiktar: " + tomatoGram + "  \nToplam Fiyat: " + tomatoTotalPrice);

            //Console.WriteLine("Alışveriş toplam tutar: " + shoppingTotalPrice);
            #endregion

            #region Char değişkenler

            //char symbol;
            //symbol = 'A';
            //Console.WriteLine(symbol);



            #endregion


            #region Klavyeden Veri girişleri String Değişkenler
            //Console.WriteLine("**** C# Hava Yolları Yolcu bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentity;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu İl: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentity = Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine("---------");
            //Console.WriteLine("Yolcu " + "TC Kimlik No: "+ passengerIdentity + "\nYolcu Ad soyad: " + passengerName + " " + passengerSurname + "\n" + passengerDistrict +"/ "+ passengerCity);

            #endregion

            #region Klavyeden Tam sayı girişleri ve dönüşümler

            //int shoePrice , computerPrice, phonePrice, tvPrice;

            //shoePrice = 250;
            //computerPrice = 4500;
            //phonePrice = 2500;
            //tvPrice = 3500;

            //int shoeCount, computerCount, phoneCount, tvCount;

            //Console.Write("Ayakkabı Adet: ");
            //shoeCount = int.Parse(Console.ReadLine());
            //Console.Write("Bilgisayar Adet: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Telefon Adet: ");
            //phoneCount = int.Parse(Console.ReadLine());
            //Console.Write("Televizyon Adet: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoeCount * shoePrice) + (computerCount * computerPrice) + (phoneCount * phonePrice) + (tvCount * tvPrice);
            //Console.WriteLine(totalPrice);
            #endregion

            #region Klavyeden Ondalıklı Sayı işlemleri

            //double exam1 , exam2, exam3, result;

            //Console.Write("1. Sınav Notu: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2. Sınav Notu: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. Sınav Notu: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Ortalama: " + result);
            #endregion

            #region Klavyeden karakter girişleri

            //char gender;
            //Console.Write("Cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçilen Cinsiyet: " + gender);
            #endregion


        }
    }
}
