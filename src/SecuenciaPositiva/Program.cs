using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuenciaPositiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            2 - Escriba un programa que indique si una secuencia de números positivos introducida por el
            usuario desde el teclado está formada únicamente por valores pares. Para indicar que la
            secuencia ha terminado el usuario introducirá el valor 0. Nota: Asuma que la secuencia
            vacía cumple la propiedad, es decir que está formada sólo por valores pares. 
             */
            int numero=1;
            Console.Title = "Contador de Pares";
            Console.WriteLine("Este programa te indicara si todos los numeros que ingresas son pares, \npara terminar escribe 0");
            

            while (numero != 0)
            {
                Console.Write("Ingrese un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    Console.WriteLine("El numero es Par!\n");
                }
                else if (numero %2!=0)
                {
                    Console.WriteLine("Este numero es impar!\n");
                }
            }
            Console.WriteLine("Has salido del Programa!");
            Console.ReadKey();



        }
    }
}
