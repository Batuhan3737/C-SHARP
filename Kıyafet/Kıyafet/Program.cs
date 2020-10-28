using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kıyafet
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renk = new string[3];
            string[] beden = new string[4];
            string[] kol = new string[2];
            string[] fiyat = new string[25];
            int fiyatsayac = 0;
            int fiyatgoster;


            //--- --- --- --- --- RENK --- --- --- --- --- --- ---//

               Console.WriteLine(" RENK SEÇİMİ ");

               Console.Write("1. Rengi Giriniz: ");
               renk[0] = Console.ReadLine();

               Console.Write("2. Rengi Giriniz: ");
               renk[1] = Console.ReadLine();

               Console.Write("3. Rengi Giriniz: ");
               renk[2] = Console.ReadLine();
               Console.WriteLine("   ");




            //--- --- --- --- --- BEDEN --- --- --- --- --- --- ---//

                Console.WriteLine(" BEDEN SEÇİMİ ");

                Console.Write("1. Bedeni Giriniz: ");
                beden[0] = Console.ReadLine();

                Console.Write("2. Bedeni Giriniz: ");
                beden[1] = Console.ReadLine();

                Console.Write("3. Bedeni Giriniz: ");
                beden[2] = Console.ReadLine();

                Console.Write("4. Bedeni Giriniz: ");
                beden[3] = Console.ReadLine();
                Console.WriteLine("   ");


            //--- --- --- --- --- KOL U. --- --- --- --- --- --- ---//

                Console.WriteLine(" KOL ÇEŞİDİ ");
            
                Console.Write("1. Kol Boyunu Giriniz: ");
                kol[0] = Console.ReadLine();

                Console.Write("2. Kol Boyunu Giriniz: ");
                kol[1] = Console.ReadLine();
                Console.WriteLine("   ");


            //--- --- --- --- --- FOR --- --- --- --- --- --- ---//

                Console.WriteLine(" ");
                Console.WriteLine("FİYAT LİSTESİ");
                Console.WriteLine(" ");

            for (int i = 0; i < 3; i++)
            {
                for (int b = 0; b < 4; b++)
                {
                    for (int r = 0; r < 2; r++)
                    {
                        Random rnd = new Random();
                        int sayi = rnd.Next(20,100);
                        Console.WriteLine(renk[i]+" "+beden[b]+" "+ kol[r]+" Fİyat: "+ sayi);

                        fiyat[fiyatsayac] = sayi.ToString();
                        fiyatsayac++;
                    }
                }
            }

            Console.WriteLine("  ");
            Console.Write("Hangi Ürünün Fiyatını Öğrenmek İstiyorsunuz: ");
            fiyatgoster = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ürün Fiyatı: "+ fiyat[fiyatgoster]);

                Console.ReadKey();

            }
        }
    }
