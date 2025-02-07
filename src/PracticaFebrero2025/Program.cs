using System;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;

namespace PracticaFebrero2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variable
            int opcion;
            do {
                //Definiendo el menu
                Console.WriteLine("\nBienvenido Al menu!");
                Console.WriteLine("1 - Contador del 1 al 1000");
                Console.WriteLine("2 - Contador de pares del 1 al 500");
                Console.WriteLine("3 - Contador de impares del 250 al 680");
                Console.WriteLine("4 - Mayoria de Edad por Grupos");
                Console.WriteLine("5 - Separar alumnos en Femenino y Masculino");
                Console.WriteLine("6 - Evaluador de Estatura");
                Console.WriteLine("7 - Tablas de Multiplicar");
                Console.WriteLine("8 - Suma de numeros naturales");

                Console.WriteLine("0 - Salir del programa\n");
                Console.Write("Por favor Selecciona una opcion: ");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion) {
                    case 1:
                        //1)	Realizar un programa que me permita ver los números naturales del 1 al 1000
                        for (int i = 1; i <= 1000; i++)
                        {
                            Console.WriteLine(i);
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        //2)	Realice un programa que me permita mostrar los números pares del 1 al 500
                        for (int i = 1; i <= 500; i++)
                        {
                            if (i%2==0)
                            {
                                Console.WriteLine(i);
                            }                           
                        }
                        Console.ReadKey();
                        break;


                    case 3:
                        //3)	Realice un programa que me permita mostrar los números impares del 250 al 680
                        for (int i = 250; i <= 680; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        //4)	Crear un programa que me permita conocer el total de personas mayores de edad y su promedio de edades de un grupo de 10.
                        //variables 
                        int edad, cantidad;
                        int acumulador = 0;
                        Console.WriteLine("Cuantas personas vamos a evaluar?");
                        cantidad = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Ok, espero {cantidad} registros!");
                        for (int i = 1; i <= cantidad; i++)
                        {
                            Console.WriteLine($"Por favor ingrese la edad de la persona Numero {i}");
                            edad = int.Parse(Console.ReadLine());
                            if (edad >= 18)
                            {
                                acumulador++;
                            }
                        }
                        Console.WriteLine($"De los {cantidad} de registros encontramos {acumulador} Mayores de edad!");

                        Console.ReadKey();
                        break;

                    case 5:
                        //5)	Realice un programa que me permita conocer de un grupo de 10 alumnos cuantos son mujeres y cuanto son varones.
                        int varones = 0;
                        int mujeres = 0;
                        int  alumnos = 0;
                        string genero;
                        Console.WriteLine("Cuantos alumnos vamos a evaluar?");
                        alumnos= int.Parse(Console.ReadLine());
                        Console.WriteLine($"Ok, espero {alumnos} Alumnos!");
                        for (int i = 1; i <= alumnos; i++)
                        {
                            Console.WriteLine($"El Alumno numero {i} es Varon o Mujer?");
                            Console.WriteLine("Escribe V si es Varon o M si es Mujer");
                            genero = Convert.ToString(Console.ReadLine());
                            switch (genero)
                            {
                                case "V": case "v":
                                    varones++;
                                    break;
                                case "m": case "M":
                                    mujeres++;
                                    break;
                            }                            

                        }
                        Console.WriteLine($"De los {alumnos} de registros encontramos {varones} Varones y {mujeres} Mujeres!");


                        Console.ReadKey();
                        break;

                    case 6:
                        /*
                         6)	Realizar un programa que me permita ingresar la estatura de un grupo de 10 personas y posteriormente realice las siguientes decisiones. 
                            • Si estatura es menos a 1.40mts mostrar “Estatura Baja”
                            • Si estatura se encuentra entre 1.40mts y 1.70 mts mostrar “Estatura normal”
                            • Si estatura es mayor a 1.70mts mostrar “Estatura Alta”
                         */

                        // variables
                        float altura;

                        Console.WriteLine("Evaluaremos la altura de 10 personas!");

                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine($"Por favor ingrese la estatura de la persona Numero {i} en [Metros]");
                            altura = float.Parse(Console.ReadLine());
                            if (altura < 1.40)
                            {
                                Console.WriteLine("Estatura Baja");
                            }
                            else if (altura >= 1.40 && altura <= 1.70)
                            {
                                Console.WriteLine("Estatura Normal");
                            }
                            else if (altura > 1.70)
                            {
                                Console.WriteLine("Estatura Alta");
                                
                            }
                        }
                        Console.ReadKey();
                        break;


                    case 7:
                        /*
                         7)	Realizar un programa que me permita mostrar la tabla de multiplicar dada por el usuario.
                         */
                        int numero;
                        Console.WriteLine("Dame un numero entero y te regresare su tabla de multiplicar!");
                        numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("+-----------+");
                        for (int i = 1; i < 11; i++)
                        {
                            Console.WriteLine($"|  {numero} * {i} = {numero*i}");
                        }
                        Console.WriteLine("+-----------+");
                        Console.ReadKey();
                        break;

                    case 8:
                        /*8)	Realice un programa que permita conocer la suma de los N primeros números naturales. Donde N es un numero digitado por el usuario.*/
                        //Variables empleadas
                        int numerico;
                        int acumlativo = 0;

                        Console.WriteLine("Sumare todos los numeros hasta el que tu elijas!");
                        numerico = int.Parse(Console.ReadLine());

                        for (int i = 0; i <=numerico; i++)
                        {
                            acumlativo += i;
                        }
                        Console.WriteLine($"La suma de los numeros hasta el {numerico} es = {acumlativo}");
                        Console.ReadKey();
                        break;


                    case 0:
                        Console.WriteLine("Programa Finalizado!");
                        break;

                    default:
                        Console.WriteLine("Opcion Invalida se espera un numero del 1 al 8!");
                        Console.ReadKey();
                        break;


                }


            }
            while (opcion !=0);

            Console.ReadKey();
        }
    }
}
