using System;
using System.Linq;


namespace examaneFinal2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Juan", "Maria", "Pedro", "Mario", "Paul", "Pepe", "Julio", "Juana", "Teresa", "Matilda" }; // Arreglo de nombres
            string[] nombres_reveresa; // Arreglo de nombres al reves
            Console.WriteLine("\n");
            Console.WriteLine("Listado Ordenado");
            for (int i = 0; i < nombres.Length; i++) // Recorriendo arreglo
            {
                Console.WriteLine(nombres[i]); // Mostrando arreglo
            }
            Console.WriteLine("\n");

            Console.WriteLine("Listado Inverso");
            nombres_reveresa = nombres.Reverse().ToArray(); // Invirtiendo arreglo y enviando a array para mostrar
            for (int i = 0; i < nombres_reveresa.Length; i++) // Recorriendo arreglo
            {
                Console.WriteLine(nombres_reveresa[i]); // Mostrando arreglo
            }

            Console.ReadKey(); // Esperando tecla para cerrar


        }
    }
}
