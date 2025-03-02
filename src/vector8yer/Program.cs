using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] nombres = new string[10];

        // Ingresar los 10 nombres
        Console.WriteLine("Ingrese 10 nombres:");
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.Write($"Nombre {i + 1}: ");
            nombres[i] = Console.ReadLine();
        }

        bool encontrado = false;

        // Búsqueda con LINQ usando Any()
        while (!encontrado)
        {
            Console.Write("\nIngrese el nombre que desea buscar: ");
            string nombreBuscar = Console.ReadLine();

            encontrado = nombres.Any(nombre => nombre.Equals(nombreBuscar, StringComparison.OrdinalIgnoreCase));

            if (encontrado)
            {
                Console.WriteLine($"¡Nombre encontrado!: {nombreBuscar}");
            }
            else
            {
                Console.WriteLine("Nombre no encontrado, inténtelo de nuevo.");
            }
        }

        
    }
}
