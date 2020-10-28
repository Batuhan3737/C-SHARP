using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_sayıdan_öncekilerei_2şer_2şer_atlayarak_toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0, cevap = 0;


            while (true)
            {

                while (true)
                {
                    try
                    {
                        Console.Write("Bir Sayı Giriniz: ");
                        sayi = Convert.ToInt16(Console.ReadLine());
                    }
                    catch
                    {

                        Console.Write("Girdiğiniz Değer Sayı Değil: ");
                    }
                    { break; }

                }
                if (sayi < 0)
                {
                    Console.Write("Lütfen Pozitif ");
                }
                else if (sayi >= 0)
                { break; }
            }

            for (int i = 0; i < sayi; i++)
            {
                cevap += i++;
            }


            Console.WriteLine("cevap: " + cevap);
            Console.ReadLine();
        }
    }
}
