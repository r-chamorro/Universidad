using System;
using System.Linq;


namespace arreglo4yer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //4.	Realice un programa que lea el arreglo (14, 7, 3, 45, 78, 12, 56, 90, 123, 567)
            //y lo muestre de la siguiente forma (567, 123, 90, 56, 12, 78, 45, 3, 7, 14)

            int [] arreglo1 = { 14, 7, 3, 45, 78, 12, 56, 90, 123, 567 };
            int[] arrevertido = new int[10];

            Console.WriteLine("Arreglo");

            arrevertido = arreglo1.Reverse().ToArray();



            for (int i = 0; i < 10 ; i++)
            {
                Console.WriteLine("Arreglo revertido " + arrevertido[i]);
            }
            Console.ReadKey();
        }
    }
}
