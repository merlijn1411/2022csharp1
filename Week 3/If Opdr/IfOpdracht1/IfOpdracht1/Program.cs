using System;

namespace IfOpdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
       

            int nummerA = 1;
            int nummerB = 2;
            int nummerC = 1;


            

            if(nummerA == nummerB)
            {
                Console.WriteLine("nummerA is gelijk aan nummerB");
            }
            else
            {
                Console.WriteLine("nummerA is niet gelijk aan nummerB");//deze moet je zien
            }



            if (nummerA == nummerC)
            {
                Console.WriteLine("nummerA is gelijk aan nummerC");//deze moet je zien
            }
            else
            {
                Console.WriteLine("nummerA is niet gelijk aan nummerC");
            }



            if (nummerA + nummerC == nummerB)
            {
                Console.WriteLine("nummerA+ nummerC is gelijk aan nummerC");//deze moet je zien
            }


            if (nummerA != nummerB)
            {
                Console.WriteLine("nummerA is niet gelijk aan nummerC");//deze moet je zien
            }




        }
    }
}