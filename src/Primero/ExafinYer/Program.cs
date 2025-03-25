using System;
using System.Linq;



namespace ExafinYer
{
    internal class Program

    //Realice un programa que lea el arreglo
    //(14, 7, 3, 45, 78, 12, 56, 90, 123, 567)
    //y lo muestre de la siguiente forma
    //(567, 123, 90, 56, 12, 78, 45, 3, 7, 14)
    {
        static void Main(string[] args)
        {
            int[] primarre = {14, 7, 3, 45, 78, 12, 56, 90, 123, 567 };
            int[] secarre = new int[10];

            secarre = primarre.Reverse().ToArray();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(secarre[i]);

            }

     
            Console.ReadKey();
        } 
         
    }
}
