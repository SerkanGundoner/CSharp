using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] regions = new string[5, 3]
            {
            {"İstanbul", "İzmit", "Sakarya" },
            {"İzmir","Muğla","Manisa" },
            {"Ankara", "Sivas", "Niğde" },
            {"Adana", "Mersin","KahramanMaraş" },
            {"Muş", "Batman", "Bitlis" },
        };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            { 
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
            Console.WriteLine("*****");
            

        }


            Console.ReadLine();


        }
    }
}
