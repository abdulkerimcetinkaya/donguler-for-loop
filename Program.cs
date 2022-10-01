using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(String[] args)
        {
            // System.Console.WriteLine("Lütfen bir sayı giriniz : ");
            // int sayac = int.Parse(Console.ReadLine());
            // for (int i = 0; i < sayac; i++)
            // {
            //     if (i % 2 == 1)
            //         Console.WriteLine(i);
            // }



            // int tekToplam = 0;
            // int cifttoplam = 0;

            // for (int i = 0; i < 1000; i++)
            // {
            //     if (i % 2 == 0)
            //         cifttoplam += i;
            //     else
            //     {
            //         tekToplam += i;
            //     }

            // }

            // Console.WriteLine("Tek toplam : " + tekToplam);
            // Console.WriteLine("Çift toplam : " + cifttoplam);


            // Break - Continue

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)

                    break;
                Console.WriteLine(i);

            }



            for (int i = 1; i < 10; i++)
            {
                if (i == 4)

                    continue;
                Console.WriteLine(i);

            }

            
        }
    }
}
