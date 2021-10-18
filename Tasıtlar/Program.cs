using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasıtlar;

namespace Arabalar
{
    class Program
    {
        static void Main(string[] args)
        {
            while (0==0)
            {
                Console.WriteLine("Bir Taşıt Türü Seçiniz:\n 1-Kara TAşıtı\n 2-Hava Aracı\n 3-Deniz Aracı:");
                byte secim = byte.Parse(Console.ReadLine());

                if (secim == 1)
                {
                    Console.WriteLine("Kara Taşıtını Seçtiniz.");

                }
                else if (secim == 2)
                {
                    Console.WriteLine("Hava Aracını Seçtiniz.");
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Deniz Araçlarını Seçtiniz.");
                }
                else
                {
                    Console.WriteLine("Bir Sayı Seçmeniz Gerekmektedir.");
                }
                Console.WriteLine("----------------------------------");

                Console.WriteLine("2-Marka Giriniz:");
                Console.WriteLine("3-Model Yılı Giriniz:");
                Console.WriteLine("4-Vites Türü Giriniz:");
                Console.WriteLine("5-Yakıt Türü Giriniz:");
                Console.WriteLine("6-Kapı Sayısı Giriniz:");
                Console.WriteLine("7-Kilometre Giriniz:");

                Otomobil oto = new Otomobil();
                oto.Marka = Console.ReadLine();
                Console.WriteLine($"2-Girilen Marka:{oto.Marka}");
                Console.WriteLine("----------------------------------");

                oto.ModelYili = int.Parse(Console.ReadLine());
                Console.WriteLine($"3-Model Yılı:{oto.ModelYili}");
                Console.WriteLine("----------------------------------");


                oto.vitesTuru = Console.ReadLine();
                Console.WriteLine($"4-Girilen VitesTürü:{oto.vitesTuru}");
                Console.WriteLine("----------------------------------");


                oto.yakit = Console.ReadLine();
                Console.WriteLine($"5-Girilen Yakıt:{oto.yakit}");
                Console.WriteLine("----------------------------------");


                oto.kapiSayisi = byte.Parse(Console.ReadLine());
                Console.WriteLine($"6-Girilen Kapı Sayısı:{oto.kapiSayisi}");
                Console.WriteLine("----------------------------------");


                oto.kiloMetre = int.Parse(Console.ReadLine());
                Console.WriteLine($"7-Girilen Kilometre:{oto.kiloMetre}");
                Console.WriteLine("----------------------------------");

                if (secim == 1)
                {

                    FileStream fs = new FileStream(@"D:\Kullanici Tercihleri.txt", FileMode.Append, (FileAccess)FileShare.Write);
                    StreamWriter Sw = new StreamWriter(fs);

                    Sw.WriteLine("1- Kara Taşıtını seçtiniz.");
                    Sw.WriteLine("-----------------------");
                    Sw.WriteLine(oto.Marka);
                    Sw.WriteLine(oto.ModelYili);
                    Sw.WriteLine(oto.vitesTuru);
                    Sw.WriteLine(oto.yakit);
                    Sw.WriteLine(oto.kapiSayisi);
                    Sw.WriteLine(oto.kiloMetre);
                    Sw.Close();
                    fs.Close();
                }
                else if (secim == 2)
                {
                    FileStream fs = new FileStream(@"D:\Kullanici Tercihleri.txt", FileMode.Append, (FileAccess)FileShare.Write);
                    StreamWriter Sw = new StreamWriter(fs);

                    Sw.WriteLine("2-Hava Taşıtını Seçtiniz.");
                    Sw.WriteLine("-----------------------");
                    Sw.WriteLine(oto.Marka);
                    Sw.WriteLine(oto.ModelYili);
                    Sw.WriteLine(oto.vitesTuru);
                    Sw.WriteLine(oto.yakit);
                    Sw.WriteLine(oto.kapiSayisi);
                    Sw.WriteLine(oto.kiloMetre);
                    Sw.Close();
                    fs.Close();
                }
                else
                {
                    FileStream fs = new FileStream(@"D:\Kullanici Tercihleri.txt", FileMode.Append, (FileAccess)FileShare.Write);
                    StreamWriter Sw = new StreamWriter(fs);

                    Sw.WriteLine("3- Deniz Taşıtını Seçtiniz. ");
                    Sw.WriteLine("-----------------------");
                    Sw.WriteLine(oto.Marka);
                    Sw.WriteLine(oto.ModelYili);
                    Sw.WriteLine(oto.vitesTuru);
                    Sw.WriteLine(oto.yakit);
                    Sw.WriteLine(oto.kapiSayisi);
                    Sw.WriteLine(oto.kiloMetre);
                    Sw.Close();
                    fs.Close();
                }
                Console.WriteLine("Çıkmak istiyormusunuz? E/H");
                if (Console.ReadLine()=="E")
                {
                    break;
                }
            }
            
            

        
            Console.ReadLine();

        }
    }
}
