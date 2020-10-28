using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asal
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;

            Console.Write("İlk Değeri Giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Son Değeri Giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine(" Asal Sayılar Listesi ");
            Console.WriteLine(" ");
            for (int i = sayi1; i <= sayi2; i++)
            {
                bool asalsayi = true;
                for (int j = 2; j <= i - 1; j++)
                {
                    if (i % j == 0)
                     asalsayi = false;
                }
                if (asalsayi == true)
                {
                Console.WriteLine("  "+i);
                }

            }
 
     





            Console.ReadKey();
        }
    }
}
