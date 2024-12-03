using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayordeEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de Variables:
            int edad;


            // Asignacion de valores:
            Console.WriteLine("Bienvenido a su confirmador de edad");
            Console.WriteLine("Te ayudare a confirmar si eres mayor de edad o no");
            Console.WriteLine("Por favor ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine($"Tienes {edad} años, eres Mayor de edad!");
            }
            else
            {
                Console.WriteLine($"Tienes {edad} años, eres Menor de edad!");
            }
        }
    }
}
