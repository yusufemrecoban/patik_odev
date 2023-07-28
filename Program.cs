using System;

namespace patik_odev{
    class Program{
        static void Main(string[] args){
           Console.WriteLine("kaç tane sayı girmek istiyorsunuz: ");
              int sayi = Convert.ToInt32(Console.ReadLine());
              int[] sayilar = new int[sayi];
                for(int i = 0; i < sayi; i++)
                {
                    Console.WriteLine("sayı giriniz: ");
                    sayilar[i] = Convert.ToInt32(Console.ReadLine());
                }
                foreach( int sayim in sayilar)
                {
                    if( sayim%2==0)
                    {
                        Console.WriteLine("çift sayılar");
                        Console.WriteLine(sayim);
                    }
                }
           Console.ReadLine();
        }
    }
}