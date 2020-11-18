using System;
using System.Collections.Generic;

namespace fibonacci_sayıları
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciList = new List<int>() {0,1};
            //fibonacciList.Add();

            int index = 0;
            int sondeger = 0;
            int listeson = 0;

            Console.Write("Bitiş Değerini Giriniz: ");
            sondeger = Convert.ToInt32(Console.ReadLine());

            while (sondeger > index)
            {
                listeson = fibonacciList.Count;
                index = fibonacciList[listeson - 1] + fibonacciList[listeson - 2];

                if (sondeger >= index)
                {
                    fibonacciList.Add(index);
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < fibonacciList.Count; i++)
            {
                Console.WriteLine(fibonacciList[i] + " ");
            }
            Console.ReadKey();

        }
    }
}
