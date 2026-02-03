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






        }
    }
}
