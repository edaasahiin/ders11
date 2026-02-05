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

            /*
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Toplam: {sayi1 + sayi2}");
            Console.WriteLine($"Fark: {sayi1 - sayi2}");
            Console.WriteLine($"Çarpım: {sayi1 * sayi2}");
            Console.WriteLine($"Bolum: {sayi1 / sayi2}");   
            Console.WriteLine($"Mod: {sayi1 % sayi2}");
            */

            /*
            Console.WriteLine("İlk sayıyı girin: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı girin: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Toplam: {num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1}'in karesi: {num1 * num1}");
            */

            /*
            Console.WriteLine("Dairenin yarıçapını giriniz(cm): ");
            double yaricap = Convert.ToDouble(Console.ReadLine());
            double alan = Math.PI * yaricap * yaricap;
            double cevre = 2 * Math.PI * yaricap;
            double cap = 2 * yaricap;

            Console.WriteLine($"pi sayısı: {Math.PI:F6}");
            Console.WriteLine($"Dairenin alanı: {alan:F2}");
            Console.WriteLine($"Dairenin çevresi: {cevre:F2}"); 
            Console.WriteLine($"Dairenin yarıçapı: {yaricap}");
            Console.WriteLine($"Dairenin çapı: {cap} cm");
            Console.WriteLine($"Yarıçap'ın karesi: {yaricap * yaricap}");
            Console.WriteLine($"Alanın karekökü: {Math.Sqrt(alan):F2}");
            */

            /*
            Console.WriteLine("Brüt maaşınızı giriniz: ");
            double brutmaas = Convert.ToDouble(Console.ReadLine());
            double vergi_kesintisi = brutmaas * 0.15;
            double sgk_kesintisi = brutmaas * 0.12;
            double toplam_kesinti = vergi_kesintisi + sgk_kesintisi;
            double net_maas = brutmaas - toplam_kesinti;

            Console.WriteLine($"Brüt maaşınız: {brutmaas:F2} TL");
            Console.WriteLine($"Toplam kesintiler: {toplam_kesinti:F2} TL");
            Console.WriteLine($"Net maaşınız: {net_maas:F2} TL");
            */

            /*
            Console.WriteLine("Lütfen yaşınızı giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas >= 18)
            {
                Console.WriteLine("Reşitsiniz.");
            }
            else
            {
                Console.WriteLine("Reşit değilsiniz.");
            }
            */

            /*
            Console.WriteLine("Sınav notunuzu giriniz: ");
            int not = Convert.ToInt32(Console.ReadLine());
            if (not >= 50)
            {
                Console.WriteLine("Geçtiniz.");
            }
            else
            {
                Console.WriteLine("Kaldınız.");
            }
            */

            /*
            Console.WriteLine("Lütfen notunuzu giriniz: ");
            int not = Convert.ToInt32(Console.ReadLine());
            if (not > 90)
            {
                Console.WriteLine("AA aldınız.");
            }
            else if (not > 80)
            {
                Console.WriteLine("BA aldınız.");
            }
            else if (not > 70)
            {
                Console.WriteLine("BB aldınız.");
            }
            else if (not > 60)
            {
                Console.WriteLine("CB aldınız.");
            }
            else if (not > 50)
            {
                Console.WriteLine("CC aldınız.");
            }
            else
            {
                Console.WriteLine("F aldınız.");
            }

            if (not >= 50)
            {
                Console.WriteLine("Tebrikler, dersten geçtiniz!");
            }
            else
            {
                Console.WriteLine("Üzgünüz, dersten kaldınız.");
            }
            */

            /*
            Console.WriteLine("Yaşınızı giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ehliyetiniz var mı?(evet-hayır): ");
            string ehliyet = Console.ReadLine();
            if (yas >= 18 && ehliyet == "evet")
            {
                Console.WriteLine("Araba kullanabilirsiniz.");
            }
            else
            {
                Console.WriteLine("Araba kullanamazsınız.");
            }

            if (yas < 18 || ehliyet == "hayır")
            {
                Console.WriteLine("Toplu taşıma kullan.");
            }
            */

            /*
            //switch ve case
            Console.WriteLine("Lütfen bir gün numarası giriniz(1/7): ");
            int gun = Convert.ToInt32(Console.ReadLine());
            string gun_adi;
            string tip;

            switch (gun)
            {
                case 1:
                    gun_adi = "Pazartesi";
                    tip = "Hafta içi";
                    break;
                case 2:
                    gun_adi = "Salı";
                    tip = "Hafta içi";
                    break;
                case 3:
                    gun_adi = "Çarşamba";
                    tip = "Hafta içi";
                    break;
                case 4:
                    gun_adi = "Perşembe";
                    tip = "Hafta içi";
                    break;
                case 5:
                    gun_adi = "Cuma";
                    tip = "Hafta içi";
                    break;
                case 6:
                    gun_adi = "Cumartesi";
                    tip = "Hafta sonu";
                    break;
                case 7:
                    gun_adi = "Pazar";
                    tip = "Hafta sonu";
                    break;
                default:
                    gun_adi = "Geçersiz gün";
                    tip = "hata";
                    break;
            }
            Console.WriteLine($"Gün: {gun_adi}, Tip: {tip}");
            */

            /*
            Console.WriteLine("Lütfen bir ay numarası giriniz(1-12): ");
            int ay = Convert.ToInt32(Console.ReadLine());
            string ay_adi;

            switch (ay)
            {
                case 1:
                    ay_adi = "Ocak";
                    break;
                case 2:
                    ay_adi = "Şubat";
                    break;
                case 3:
                    ay_adi = "Mart";
                    break;
                case 4:
                    ay_adi = "Nisan";
                    break;
                case 5:
                    ay_adi = "Mayıs";
                    break;
                case 6:
                    ay_adi = "Haziran";
                    break;
                case 7:
                    ay_adi = "Temmuz";
                    break;
                case 8:
                    ay_adi = "Ağustos";
                    break;
                case 9:
                    ay_adi = "Eylül";
                    break;
                case 10:
                    ay_adi = "Ekim";
                    break;
                case 11:
                    ay_adi = "Kasım";
                    break;
                case 12:
                    ay_adi = "Aralık";
                    break;
                default:
                    ay_adi = "Geçersiz ay";
                    break;
            }

            Console.WriteLine($"Ay: {ay_adi}");
            */

            /*
            Console.WriteLine("1'den 10'a kadar sayılar: ");
            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                toplam += i;
            }

            Console.WriteLine($"Toplam: {toplam}");
            */


            
            Console.WriteLine("Çarpmak istediğiniz sayıyı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                Console.WriteLine($"{sayi} * {i} = {sayi * i}");

            }

        }
    }
}
