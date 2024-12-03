using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/*
* En este programa unire todas las solicitudes a ejecutar
  */





namespace estructurasSelectivas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de Variables:
            int edad; // Almacena la edad del usuario para determinar mayoria de edad
            int opcion; // La opcion que elija el usuario ejecutara el programa
            int mate, espa, eng; // Notas de las materias a evaluar
            double a, b,c; // Numeros que el usuario puede asignar en algunos programas

            Console.WriteLine("Bienvenido a su selector de Programas!");
            Console.WriteLine("Por favor digite el Numero del programa que deseas ejecutar");
            Console.WriteLine("1 - Confirmar mayoria de Edad");
            Console.WriteLine("2 - Evaluacion de Alumnos");
            Console.WriteLine("3 - Operaciones con 2 numeros");
            Console.WriteLine("4 - Determine el tipo de numero (Positivo, Negativo o Neutro)");
            Console.WriteLine("5 - Devuelve el mayor de 3 numeros");

            opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {
                case 1:

                    /*
                        Ejercicio 1:
                        Realizar un programa que me permita leer la edad de una persona, determinar y señalar si la persona es mayor o menor de edad, utilizando la estructura de
                        control selectiva if-else para solucionar el problema
 
                    */

                    // Asignacion de valores:
                    Console.WriteLine("Bienvenido a su confirmador de edad");
                    Console.WriteLine("Te ayudare a confirmar si eres mayor de edad o no");
                    Console.WriteLine("Por favor ingrese su edad");
                    edad = int.Parse(Console.ReadLine());

                    if (edad >= 18)
                    {
                        Console.WriteLine($"Tienes {edad} años, eres Mayor de edad!");
                    }
                    else
                    {
                        Console.WriteLine($"Tienes {edad} años, eres Menor de edad!");
                    }

                    break;


                case 2:

                    /*
                        Determinar si un alumno aprueba o reprueba el curso, sabiendo que aprobará si
                        su promedio de tres calificaciones es mayor o igual a 70; reprueba en caso
                        contrario.
                     */
                    // Asignacion de valores a las materias:
                    Console.WriteLine("Bienvenido a tu evaluacion de alumnos");
                    Console.WriteLine("Por favor indica las notas de las siguientes clases: ");
                    Console.Write("Matematica: ");
                    mate = int.Parse(Console.ReadLine());
                    Console.Write("Español: ");
                    espa = int.Parse(Console.ReadLine());
                    Console.Write("Ingles: ");
                    eng = int.Parse(Console.ReadLine());

                    // Proceso de evaluacion
                    if ((espa + eng + mate) / 3 >= 70)

                    {
                        Console.WriteLine("Usted ha Aprobado!");
                    }
                    else
                    {
                        Console.WriteLine("Usted ha Reprobado!");
                    }
                    break;

                case 3:
                    /*
                        Realice un programa que permita leer dos números, si son iguales que los
                        multiplique, si el primero es mayor que el segundo que los reste y sino que realice
                        la suma.
                     */


                    Console.WriteLine("Bienvenido a Calculos Matematicos!");
                    Console.WriteLine("Deberas elegir 2 numeros cualquiera!");
                    Console.WriteLine("Si son iguales los multiplicare!");
                    Console.WriteLine("Si el primero es mayor que el segundo los restare!");
                    Console.WriteLine("Si no se cumplen las anteriores entonces los sumare!");
                    Console.WriteLine("Por favor digite el primer numero");
                    a = double.Parse(Console.ReadLine()); // Asignando primer Valor
                    Console.WriteLine("Por favor digite el segundo numero");
                    b = double.Parse(Console.ReadLine()); // Asignando Segundo Valor

                    // Decision de operacion a ejecutar
                    if (a == b)
                    {
                        Console.Write("Estos valores iguales al multiplicarse dan como resultado: ");
                        Console.WriteLine(a * b);
                    }
                    else if (a > b)
                    {
                        Console.Write("El primer numero es mayor, asi que los restare y da como resultado: ");
                        Console.WriteLine(a - b);
                    }
                    else
                    {
                        Console.WriteLine("El segundo numero es el mayor en este caso, asi que los sumare: ");
                        Console.WriteLine(a + b);
                    }
                    break;

                case 4:
                    Console.Write("Ingresa un numero cualquiera, yo te dire si es Positivo, negativo o neutro ");
                    a = double.Parse(Console.ReadLine()); // Guardando el valor entregado por el usuario

                    // Proceso: decidiendo que numero nos dio el usuario
                    if (a == 0)
                    {
                        Console.WriteLine("El numero 0 es el unico numero considerado NEUTRO!");
                    }
                    else if (a > 0)
                    {
                        Console.WriteLine("Estamos a la derecha del 0, esto es POSITIVO!");
                    }
                    else
                    {
                        Console.WriteLine("Estamos a la izquierda del 0, esto es NEGATIVO!");
                    }
                    break;

                case 5:
                    /*
                        Leer tres números diferentes y determinar cuál es el mayor de ellos, utilizando
                        la estructura de control selectiva if-else para solucionar el problema y
                        anidamientos.
                    */

                    Console.WriteLine("Ingresa 3 numero diferentes y yo determinare cual es el mayor!");

                    Console.WriteLine("Primer Numero");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Segundo Numero");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Tercer Numero");
                    c = double.Parse(Console.ReadLine());
                    if (a > b && a > c)
                    {
                        Console.WriteLine($"El Primer numero es el Mayor: {a}");
                    }
                    else if (b > a && b > c)
                    {
                        Console.WriteLine($"El Segundo numero es el Mayor: {b}");

                    }
                    else if (c > a && c > b)
                    {
                        Console.WriteLine($"El Tercer numero es el Mayor: {c}");
                    }
                    else
                    {
                        Console.WriteLine("Los numeros no son diferentes!!");
                    }

                    break;
            }

            



            Console.ReadKey();

        



        }
    }
}
