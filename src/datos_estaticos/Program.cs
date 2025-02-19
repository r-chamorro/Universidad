using System;
using System.Linq; // Libreria para usar el metodo Average() del arreglo en punto 2
using System.Net.Http.Headers;

namespace datos_estaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Estructura de datos estáticos. Arreglos en C#


4.	Construya un programa que realice la siguiente operación. Sean 2 vectores numéricos A y B de 6 elementos numéricos cada uno. El vector A se debe llenar solo con valores pares y el vector B solo con valores impares. En un vector C guarde el resultado de ejecutar 3A + 2B. Imprima el vector C en forma descendente. Determine el promedio del vector A y el promedio del Vector B.
5.	Crea un arreglo de números y escribe un programa que encuentre el valor máximo y el valor mínimo en ese arreglo.
6.	Crea un arreglo con varios números enteros y escribe un programa que cuente cuántos números son pares y cuántos son impares.
7.	Crea un arreglo de 5 elementos y escribe un programa que imprima el arreglo en orden inverso.
8.	Realice un programa que tenga las siguientes operaciones. Tiene 4 vectores A,B,C y D de 10 elementos numéricos cada uno, llene el vector A con números pares, el vector B con números impares, el vector C con la suma de A + B, el vector D con la resta de A – B. Determinar la suma de cada vector y utilizarlo para llenar el vector R que 4 elementos numéricos, es decir la suma del vector A corresponde a la posición 0 del Vector R, la suma del vector B corresponde a la posición 1 del vector R, y así respectivamente con C y D. Imprima el vector R.
9.	Crea un arreglo de 10 números enteros y escribe un programa que los ordene de menor a mayor.
10.	Crea un arreglo de 6 elementos y copia esos elementos a un segundo arreglo. Luego imprime ambos arreglos.
11.	Crea un arreglo de números con valores repetidos y escribe un programa que elimine los valores duplicados del arreglo.
12.	Realice un programa que me permita llenar un Vector A de 6 elementos numéricos y determinar suma de todos sus elementos, promedio y cuantos elementos están por encima del promedio. Realice la misma operación para el Vector B = 4A. 
             */

            //declarando 

            int opcion;

            Console.Title = "Arreglos en C#";
            Console.WriteLine("Bienvenido al Menu!");
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("1 - Sumar un arreglo de tamano 'n' ");
            Console.WriteLine("2 - Promedio de 5 valores");
            Console.WriteLine("3 - Adivina El valor interno");
            Console.WriteLine("0 - Para salir del programa");
            opcion = int.Parse(Console.ReadLine());


            
                switch (opcion)
                {
                    case 1:
                        //1.	Crea un arreglo de enteros y escribe un programa que calcule la suma de todos los elementos del arreglo.
                        Console.WriteLine("Por favor define la longitud de tu arreglo");
                        int acumulador = 0; //declarando variable para la suma acumulada
                        int i = int.Parse(Console.ReadLine()); // Declarando variable y asignando la longitud del arreglo
                        int[] enteros = new int[i]; // Declarando el arreglo de tamano i


                        for (int j = 0; j < i; j++) // Iteracion para llenar el arreglo
                        {
                            Console.WriteLine($"Por favor ingrese el valor para la posicion: {j + 1}");
                            enteros[j] = int.Parse(Console.ReadLine());
                        }

                        for (int j = 0; j < i; j++) // Iteracion para sumar los valores del arreglo
                        {
                            acumulador += enteros[j];
                        }
                        Console.WriteLine($"La sumatoria de su arreglo es igual a: {acumulador}");

                        break;

                    case 2:
                        //2.Crea un arreglo con 5 números y escribe un programa que calcule el promedio de esos números.

                        int[] numeros = new int[5]; // Declarando el arreglo de tamano 5
                        Console.WriteLine("Por favor ingresa 5 numeros y te devolvere el promedio");
                        for (int j = 0; j < 5; j++) // Iteracion para llenar el arreglo
                        {
                            Console.WriteLine($"Por favor ingrese el valor para la posicion: {j + 1}");
                            numeros[j] = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine($"El Promedio del arreglo es {numeros.Average()}");

                        break;



                    case 3:
                        //3.	Crea un arreglo de 10 números y permite al usuario ingresar un número. Escribe un programa que determine si ese número está presente en el arreglo.
                        Console.WriteLine("Abajo encontraras un arreglo con numeros entre el 1 y el 10");
                        Console.WriteLine("Por favor ingresa un numero y te dire si acertaste al valor interno");
                        int[] aleatorios = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        int numusuario = int.Parse(Console.ReadLine()); // usuario define numero a encontrar



                        if (aleatorios.Contains(numusuario))
                        {
                            Console.WriteLine("Felicidades! Acertaste al valor interno");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Lo siento, no acertaste al valor interno");
                            break;
                        }




                        break;




                    default:

                        Console.WriteLine("Debera selecciona un numero entero entre 1 y 12");
                        break;
                }

            


            Console.ReadKey();






        }
    }
}
