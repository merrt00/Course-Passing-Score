
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulYapısıOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 3 tane not alan ve bu notların ortalamasını bulan ve ortalaması eğer
            // 80-100 arasındaysa A+ yazdıran
            // 60-80 arasındaysa A yazdıran 
            // 40-60 arasındaysa B+ yazdıran
            // 40'tan küçükse F yazdıran program

            Console.WriteLine("Birinci notunuzu giriniz: ");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci notunuzu giriniz: ");
            int not2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ücüncü notunuzu giriniz: ");
            int not3 = Convert.ToInt32(Console.ReadLine());



            int ortalama = (not1 + not2 + not3) / 3;
            Console.WriteLine("Ortalamanız: " + ortalama);


            if (ortalama >= 80 && ortalama <= 100)Console.WriteLine(" Not değeriniz A+'dır.");

            else if (ortalama >= 60 && ortalama < 80)Console.WriteLine("Not degeriniz A'dır.");
            
            else if (ortalama >= 40 && ortalama < 60)
            {
                Console.WriteLine("Not degeriniz B+'dır.");
            }
            else
            {
                Console.WriteLine("Not degeriniz F'tir.");
            }
            Console.ReadLine();
        }
    }
}
