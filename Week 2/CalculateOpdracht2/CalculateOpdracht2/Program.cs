using System;
using System.Net.Http.Headers;

namespace CalculateOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int controllersInMandje = 0;

            controllersInMandje = controllersInMandje + 2;
            //koop 2 controllers


            //hij is in voorraad snel kopen!
            int ps5 = 0;
            ps5 = ps5 + 1;

            //koop 1 ps5


            //koop de games:

            int eldenRing = 0;

            eldenRing = eldenRing + 1;


            int shantae = 0;

            shantae = shantae + 1;

            int spongebob = 0;

            spongebob = spongebob + 1;

            //hmmm weten we het zeker?
            //haal 1 game weg met -- of -= 1
            spongebob= spongebob -- ;
            //nu nog de prijs


            double ps5Prijs = 499.99;
            double controllerPrijs = 69.99;
            double gamePrijs = 59.99;


            double totaalControllerPrijs = 0;
            totaalControllerPrijs = controllerPrijs * controllersInMandje;
            double totaalgamePrijs = 0;
            totaalgamePrijs = (eldenRing * gamePrijs) +  (shantae* gamePrijs)  + ps5Prijs + totaalControllerPrijs;


            double totaalPrijs = 0;// tel hier alles bij elkaar op

            //er moet nu 759.95 staan
            Console.WriteLine(totaalgamePrijs);
        }
    }
}