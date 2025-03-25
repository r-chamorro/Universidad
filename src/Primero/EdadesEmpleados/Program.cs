using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdadesEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            3 - Escriba un programa que permita registrar las edades de los empleados de una fábrica (no
            se sabe cuántos) y verificar cuántos son mayores de edad (18 años o más) y cuántos son
            menores. Finalmente mostrar la cantidad de mayores de edad y los menores
            */
            
            int edad = 1;
            int mayores = 0;
            int menores = 0;

            Console.Title = "Personal";
            Console.WriteLine("Contador de personal!");
            Console.WriteLine("Para salir del programa ingrese un valor negativo");


            while (edad!=0) 
            {
                Console.WriteLine("Ingrese la edad del empleado!");
                edad = int.Parse(Console.ReadLine());
                if (edad >= 18)
                {
                    mayores++;
                    Console.WriteLine($"Tenemos {mayores} Empleados mayores de edad y {menores} Menores de edad!\n");
                }
                else if (edad < 18&&edad>0)
                {
                    menores++;
                    Console.WriteLine($"Tenemos {mayores} Empleados mayores de edad y {menores} Menores de edad!\n");
                }
                else 
                {
                    Console.WriteLine("Programa Finalizado");
                    Console.WriteLine($"Tenemos {mayores} Empleados mayores de edad y {menores} Menores de edad!\n");
                }
                
            }
            Console.ReadKey();








        }
    }
}
