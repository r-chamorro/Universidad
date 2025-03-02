using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de elementos: ");
        int n = int.Parse(Console.ReadLine());

        int[] vector = new int[n];
        double suma = 0;

        // Llenado del vector
        Console.WriteLine("\nIngrese los elementos:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
            suma += vector[i];
        }

        // Calcular promedio
        double promedio = suma / n;

        // Usando LINQ para separar mayores y menores
        var mayores = vector.Where(num => num >= promedio).ToArray();
        var menores = vector.Where(num => num < promedio).ToArray();

        // Mostrar resultados
        Console.WriteLine("\nVector Original:");
        Console.WriteLine(string.Join(" ", vector));

        Console.WriteLine($"\nPromedio: {promedio:F2}");

        Console.WriteLine("\nMayores o iguales al promedio:");
        Console.WriteLine(mayores.Length > 0 ? string.Join(" ", mayores) : "No hay números mayores o iguales al promedio.");

        Console.WriteLine("\nMenores al promedio:");
        Console.WriteLine(menores.Length > 0 ? string.Join(" ", menores) : "No hay números menores al promedio.");
    }
}
