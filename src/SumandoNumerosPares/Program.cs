using System;

namespace SumandoNumerosPares
{
    internal class Program
    {
        static void Main(string[] args)
        /*
         2.	Calcular la suma de los números pares comprendidos entre 10 y un número mayor ingresado por teclado (ejemplo: 20) 
            la suma los pares son 10 + 12 + 14 +16+18+20 = 80

         */

        {
            //Variables
            int numeroTotal = 0;
            int numInicial = 10;
            int numFinal;
            Console.WriteLine("Ingrese un numero como Limite Superior de la operacion!");
            Console.WriteLine("Sumare todos los numeros Pares entre el 10 y el numero que elijas!");
            numFinal = int.Parse(Console.ReadLine());

            while (numInicial<= numFinal) 
            
            {
                if (numFinal % 2 == 0) 
                
                {
                    numeroTotal = numeroTotal + numFinal;
                    //Console.WriteLine(numFinal+"\n");
                    //Console.WriteLine(numeroTotal);
                }
                numFinal--;

            }

            Console.WriteLine($"La suma de todos los valores es igual a {numeroTotal}");

            Console.ReadKey();
        }
    }
}
