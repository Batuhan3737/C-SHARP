using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using System.ComponentModel;

namespace alan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                                      Alan Hesaplama");
            Console.WriteLine("");

            int sayi1 = 0, sayi2 = 0, cevap;

            while (0 == 0 ) {
                
                    Console.Write("1. Değeri Giriniz: ");
                while (0 == 0) { 
                try
                {
                    sayi1 = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Girdiğiniz Değer Sayı Değil:");
                }
                    break;
            }
                if (sayi1 < 1)
                {
                    Console.WriteLine(" Lütfen 0 dan küçük değer girmeyiniz");
                }
                else if (sayi1>1)              
                { break; } 
            }

            while (0 == 0)
            {

                Console.Write("2. Değeri Giriniz: ");
                while (0 == 0)
                {
                    try
                    {
                        sayi2 = Convert.ToInt16(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Girdiğiniz Değer Sayı Değil:");
                    }
                    break;
                }
                if (sayi2 < 1)
                {
                    Console.WriteLine(" Lütfen 0 dan küçük değer girmeyiniz");
                }
                else if (sayi2 > 1)
                { break; }
            }



            cevap = sayi1 * sayi2;

            Console.WriteLine("CEVAP: "+ cevap );
            Console.ReadLine();
            
        }
    }
}
