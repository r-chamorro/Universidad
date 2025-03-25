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
            Console.Title = "Estructuras Condicionales";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            // Declaracion de Variables:
            int opcion, edad, mate, espa, eng; // Declarando variables de tipo int
            double a, b,c; // Numeros que el usuario puede asignar en algunos programas

            Console.WriteLine("Bienvenido a su selector de Programas!");
            Console.WriteLine("Por favor digite el Numero del programa que deseas ejecutar");
            Console.WriteLine("1 - Confirmar mayoria de Edad");
            Console.WriteLine("2 - Evaluacion de Alumnos");
            Console.WriteLine("3 - Operaciones con 2 numeros");
            Console.WriteLine("4 - Determine el tipo de numero (Positivo, Negativo o Neutro)");
            Console.WriteLine("5 - Devuelve el mayor de 3 numeros");
            Console.WriteLine("6 - Es par o es impar?");
            Console.WriteLine("7 - Evaluador de Triangulos");

            opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    Console.Title = "Mayoria de Edad";
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
                    Console.Title = "Evaluacion Escolar";
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
                    Console.Title = "Calculos Matematicos";

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
                    Console.Title = "Negativo Positivo Neutro";
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
                    Console.Title = "3 Numeros, 3 opciones";
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

                case 6:
                    Console.Title = "Par o Impar";

                    /*
                     Determinar si un numero ingresado por teclado es par o impar.
                     */

                    Console.Write("Ingresa un numero entero y te dire si es par o impar: ");
                    opcion= int.Parse(Console.ReadLine());
                    if (opcion % 2 == 0)
                    {
                        Console.WriteLine("Esto es un numero Par!");
                    }
                    else
                    {
                        Console.WriteLine("Esto es un numero Impar!");
                    }


                    break;

                case 7:
                    /*
                    Realizar un programa que lea tres números enteros de un supuesto triángulo,
                    determine si realmente forman un triángulo, y muestre el tipo de triángulo que es
                    (si es un triángulo)
                     */
                    Console.Title = "Validador de Triangulos";

                    Console.WriteLine("\nBienvenido a tu Evaluador de triangulos!");
                    Console.WriteLine("\nTe dire si los valores que me brindas forman un triangulo");
                    Console.WriteLine("Y si son un triangulo te dire que tipo es!");
                    Console.WriteLine("Por favor ingresa el valor del primer lado");
                    a  = double.Parse((string)Console.ReadLine());
                    Console.WriteLine("Por favor ingresa el valor del segundo lado");
                    b = double.Parse((string)Console.ReadLine());
                    Console.WriteLine("Por favor ingresa el valor del tercer lado");
                    c = double.Parse((string)Console.ReadLine());


                    // Validando el triangulo:
                    if ((a + b) > c && (a + c) > b && (b + c) > a)
                    {
                        Console.WriteLine("Esto si es un triangulo!");
                        Console.WriteLine("Presiona una tecla y te dire de que tipo!!");
                        Console.ReadKey();
                        if (a == b && b == c)
                        {
                            Console.WriteLine("Todos los lados son iguales!");
                            Console.WriteLine("Esto es un Triangulo 'Equilátero' ");
                        }
                        else if (a == b || b == c || a == c)

                        {
                            Console.WriteLine("Al menos 2 de sus lados son iguales!");
                            Console.WriteLine("Esto es un Triangulo Isósceles!");
                        }
                        else
                        {
                            Console.WriteLine("Esto debe ser un Triangulo Escaleno!!");
                        }
                    }
                    else 
                    {
                        Console.WriteLine("No se tu pero no lo veo muy triangular!");
                        Console.WriteLine("Esto No es un triangulo!");
                    }
                    


                    break;
                
                default:
                    Console.WriteLine("Opcion No valida, intente de nuevo");
                    
                   break;
                        


            }

            



            Console.ReadKey();

        



        }
    }
}
