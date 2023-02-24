using System;

namespace CalculateOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            double totaalPrijs = 759.95;

       
            

            double prijsProcentBetalen = 100 - 20;

     
            totaalPrijs = (totaalPrijs / 100) * prijsProcentBetalen;
            


            //Der staat nu 607.96 staan
            Console.WriteLine($"te betalen {totaalPrijs}");
        }
    }
}