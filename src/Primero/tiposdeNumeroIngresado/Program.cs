using System;


namespace tiposdeNumeroIngresado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             3.	Realizar un algoritmo que permita pedir 10 números naturales y determine e imprima cuantos son pares, impares, positivos y negativos.
             */

            int pares = 0;
            int impares = 0;
            int positivos = 0;
            int negativos = 0;
            int numero = 0;
            int counter = 1;

            Console.WriteLine("Ingresaras 10 numeros diferentes uno por uno!");
            Console.WriteLine("Procedere a clasificarlo en Pares, Impares, positivos y negativos");
            


            while (counter <= 10)
            {
                Console.WriteLine($"Ingresa el Numero {counter}");
                numero = Int32.Parse(Console.ReadLine());

                if (numero > 0&& numero%2==0)
                {
                    positivos++;
                    pares++;

                }
                else if (numero > 0 && numero % 2 != 0)
                {
                    positivos++;
                    impares++;
                }
                else if (numero < 0 && numero % 2 == 0)
                {
                    negativos++;
                    pares++;
                }
                else if (numero < 0 && numero % 2 != 0)
                {
                    negativos++;
                    impares++;
                }

                counter++;

            }

            Console.WriteLine($"De la lista existen {pares} Numeros Pares");
            Console.WriteLine($"De la lista existen {impares} Numeros Impares");
            Console.WriteLine($"De la lista existen {positivos} Numeros Positivos");
            Console.WriteLine($"De la lista existen {negativos} Numeros Negativos");
            Console.ReadKey();
        }
    }
}
