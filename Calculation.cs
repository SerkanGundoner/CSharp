using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = new int[5];
            int toplam = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("sayi girin :");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                toplam = sayilar[i] + toplam;
                // i zaten 0 1 2... olucak 

            }
            Console.WriteLine("TOPLAM SONUC:  " + toplam);
            Console.ReadKey();






        }
      


    }
}
