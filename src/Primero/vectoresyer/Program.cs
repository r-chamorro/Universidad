using System;
using System.Linq;

namespace vectoresyer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.	Realice un programa que me permita obtener el promedio de notas guardadas en un arreglo,
            //solicitando al usuario la cantidad de calificaciones a ingresar para promediar.


            Console.WriteLine("Ingrese la cantidad de notas a promediar");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            int[] notas = new int[cantidad];
            
            Console.WriteLine("Ingrese las notas a promediar");


            for (int i = 0; i < cantidad; i++)
            {
                notas[i] = Convert.ToInt32(Console.ReadLine());

                
            } 

            notas.Average();

            Console.WriteLine("El promedio de las notas es: " + notas.Average());

            Console.ReadKey();
        }  
    }
}
