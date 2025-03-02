using System;
using System.Collections.Generic;
using System.Linq;


namespace CalProm6Yer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //6.	Calcular el promedio de n números que son pares, los almacene en otro arreglo y al final muestre ambos arreglos en pantalla.

            {
                Console.Write("Ingrese la cantidad de números: ");
                int n = int.Parse(Console.ReadLine());

                int[] numeros = new int[n];
                int[] pares = new int[n];
                int suma = 0;

                // Llenar el arreglo original

                
                
                for (int i = 0, j = 0; i < n; i++)
                {
                    Console.Write($"Ingrese el número {i + 1}: ");
                    numeros[i] = int.Parse(Console.ReadLine());

                    if (numeros[i] % 2 == 0)
                    {
                        pares[j] = numeros[i];
                        j++;
                    }

                }
                Console.WriteLine("Resultado de numeros ");
                for (int i = 0; i < n; i++)
                {

                    Console.Write($"{numeros[i]} ");
                }
                Console.WriteLine("Resultado de numeros pares ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{pares[i]} ");  
                }

                {
                   

                }
                Console.ReadKey();
            }
        }




    }
}

