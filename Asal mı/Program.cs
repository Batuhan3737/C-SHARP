using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asal_mı
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

            
            int sayi;
            string bol = "";
            bool asalsayi = true;
            bool cıkar = true;
                


                while (true)
                {
                Console.Write(" Sayı Giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi < 0)
                    {
                        Console.Write("Negatif bir sayı girdiniz. Başka Bir");
                    }
                    else
                    {
                        break;
                    }
                }
                if (sayi ==1 || sayi == 0)
                {
                    cıkar = false;
                }

            for (var i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    asalsayi = false;
                    bol += i + " ";
                }
            }
                if (asalsayi == false)
                {
                    Console.WriteLine(" " + sayi + " sayısı asal değildir. Bölenleri ise : " + bol + "ve " + sayi);
                    
                }

                else if (cıkar == false)
            {
                Console.WriteLine(" Girilen Sayı Asal Değildir.");
            }

                else
                {
                    Console.WriteLine(" Girilen Sayı Asaldır.");
                }

                
            }
            Console.ReadKey();
        }
    }
}
