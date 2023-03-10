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


            

            if(1 == 2)
            {
                Console.WriteLine("nummerA is gelijk aan nummerB");
            }
            else
            {
                Console.WriteLine("nummerA is niet gelijk aan nummerB");//deze moet je zien
            }



            if (1 == 1 )
            {
                Console.WriteLine("nummerA is gelijk aan nummerC");//deze moet je zien
            }
            else
            {
                Console.WriteLine("nummerA is niet gelijk aan nummerC");
            }



            if (1 + 1 == 2)
            {
                Console.WriteLine("nummerA+ nummerC is gelijk aan nummerC");//deze moet je zien
            }


            if (1 != 2 )
            {
                Console.WriteLine("nummerA is niet gelijk aan nummerC");//deze moet je zien
            }




        }
    }
}