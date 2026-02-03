using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Merhaba, benim adım Eda");
            string ad = "Eda"; // metinsel değer
            int yas = 23; // tam sayı veri türü
            long nufus = 2500000000; // büyük tam sayı
            float sicaklik = 5.3f; // ondalıklı sayı
            double pi = 3.14567893759; // büyük ondalıklı sayı
            Console.WriteLine($"Yaş: {yas}");
            Console.WriteLine($"Ad: {ad}");
            Console.WriteLine($"Nüfus: {nufus}");
            Console.WriteLine($"Sıcaklık: {sicaklik}");
            Console.WriteLine("Pi Syaısı: " + pi);
            char harf = 'Z';
            bool evli_mi = false;
            Console.WriteLine("Evli mi: " + evli_mi);
            */

            /*
            Console.Write("Adınıdızı giriniz: ");
            string isim = Console.ReadLine();
            Console.WriteLine("Merhaba " + isim + " hoş geldin!");

            Console.WriteLine("Yaşınızı giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Boyunuzu giriniz: ");
            double boy = Convert.ToDouble(Console.ReadLine());

            var bilgi = $"Yaşınız {yas} ve {boy} boyundasınız.";
            //console.WriteLine("Yaşınız " + yas + boy + " boyundasınız."); 
            Console.WriteLine(bilgi);
            */

            /*
            Console.Write("Adınızı giriniz: ");
            string ad = Console.ReadLine();
            Console.Write("Bölümünüzü giriniz: ");
            string bolum = Console.ReadLine();  
            Console.Write("Yaşınızı giriniz: ");  
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Not ortalamanızı giriniz: ");
            double not_ort = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Adınız: {ad}, Bölümünüz: {bolum}, Yaşınız: {yas}, Not ortalamanız: {not_ort}");
            */


            /*
            int sayi1 = 15;
            int sayi2 = 4;
            Console.WriteLine(${sayi1} + {sayi2} = {sayi1 + sayi2});
            Console.WriteLine(${sayi1} - { sayi2} = { sayi1 - sayi2});
            Console.WriteLine(${sayi1} * { sayi2} = { sayi1 * sayi2});
            Console.WriteLine(${sayi1} / { sayi2} = { sayi1 / sayi2});  
            double ondalik_sonuc = (double)sayi1 / sayi2; // tam sayı bölme işlemi sonucunu ondalık yapmak için tür dönüşümü
            Console.WriteLine($"{sayi1} / {sayi2} = {ondalik_sonuc}");
            Console.WriteLine($"{sayi1} % {sayi2} = {sayi1 % sayi2}"); // mod alma işlemi
             */

            /*
            int sayac = 10;
            Console.WriteLine($"Sayacın ilk değeri: + {sayac}");
            Console.WriteLine($"++sayac: {++sayac}");
            Console.WriteLine($"sayac++: {sayac++}");
            Console.WriteLine($"Sayacın son değeri: {sayac}");

            int toplam = 100;
            toplam += 50;
            Console.WriteLine($"(toplam += 50) {toplam}");
            toplam -= 70;
            Console.WriteLine($"(toplam -= 70) {toplam}");
            */

            /*
            Console.Writeline($"10 > 15 : {10 > 15}"); // false)
            Console.WriteLine($"5 < 10 : {5 < 10}"); // true
            Console.WriteLine($"10 == 10 : {10 == 10}");
            Console.WriteLine($"10 != 5 : {10 != 5}");
            */

            /*
            Console.WriteLine($"Karekök 16: {Math.Sqrt(16)}");
            Console.WriteLine($"2 üzeri 5: {Math.Pow(2, 5)}");  
            Console.WriteLine($"Pi sayısı: {Math.PI}");
            Console.WriteLine($"Mutlak Değer: {Math.Abs(-25)}");
            */

            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi1 = Console.ReadLine();
            int sayi2 = Console.ReadLine();
            Console.WriteLine($"Toplam: {sayi1 + sayi2}");
            Console.WriteLine($"Fark: {sayi1 - sayi2}");
            Console.WriteLine($"Çarpım: {sayi1 * sayi2}");
            Console.WriteLine($"Bolum: {sayi1 / sayi2}");   
            Console.WriteLine($"Mod: {sayi1 % sayi2}"); 














        }
    }
}
