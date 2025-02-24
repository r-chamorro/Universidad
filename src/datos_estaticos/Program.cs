using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Linq; // Libreria para usar el metodo Average() del arreglo en punto 2
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace datos_estaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Estructura de datos estáticos. Arreglos en C#







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
            Console.WriteLine("4 - Vectores Numericos");
            Console.WriteLine("5 - Definir Max y Min de arreglo 'n'");
            Console.WriteLine("6 - Contador Pares e Impares");
            Console.WriteLine("7 - Arreglo Inverso");
            Console.WriteLine("8 - Operaciones de Vectores");
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


                    case 4:
                    //4.Construya un programa que realice la siguiente operación.Sean 2 vectores numéricos A y B de 6 elementos numéricos cada uno.                    
                    //El vector A se debe llenar solo con valores pares y el vector B solo con valores impares. En un vector C guarde el resultado de ejecutar 3A + 2B.
                    //Imprima el vector C en forma descendente.Determine el promedio del vector A y el promedio del Vector B.

                    int par, impar;
                    double promedioA, promedioB;

                    int[] a_par= new int[6]; //Declarando varialbes a emplear
                    int[] b_impar = new int[6];
                    int[] c_suma = new int[6];


                    Console.WriteLine("Ingrese Valores Pares para el arreglo 'A' ");
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write($"Ingrese el valor numero {j + 1}: ");
                        par = int.Parse(Console.ReadLine());
                        if (par % 2 == 0)
                        {
                            a_par[j] = par;

                        }
                        else 
                        { 
                            Console.WriteLine("Este arreglo solo permite numeros Pares! Intenta de nuevo");
                            j--;
                        }
                        
                    }
                    
                    Console.WriteLine("Ingrese Valores Impares para el arreglo 'B' ");
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write($"Ingrese el valor numero {j + 1}: ");
                        impar = int.Parse(Console.ReadLine());
                        if (impar % 2 != 0)
                        {
                            b_impar[j] = impar;

                        }
                        else {
                            Console.WriteLine("Este arreglo solo permite numeros Impares! Intenta de nuevo");
                                j--; }
                    }

                    for (int j=0; j<6;j++) 
                    {
                        c_suma[j] = (3 * a_par[j]) + (2 * b_impar[j]);

                    }

                    Array.Sort(c_suma); // Ordenando los Valores del arreglo C
                    Array.Reverse(c_suma); // Invirtiendo el orden del arreglo C
                    Console.WriteLine("El valor del elemento C de forma descendente");

                    for (int j = 0; j <6; j++)
                    {
                        Console.WriteLine($"Numero {j+1} es: {c_suma[j]}");                        
                    }
                    Console.WriteLine($"El promedio del grupo A es: {Math.Round(a_par.Average(),2)}");
                    Console.WriteLine($"El promedio del grupo B es: {Math.Round(b_impar.Average(),2)}");


                    break;

                    case 5:
                    //5.	Crea un arreglo de números y escribe un programa que encuentre el valor máximo y el valor mínimo en ese arreglo.

                    
                    Console.WriteLine("Por favor define el tamano del arreglo a evaluar");
                    i= int.Parse(Console.ReadLine()); // Asignando la longitud del arreglo
                    int[] arreglo = new int[i]; // Declarando el arreglo de tamano n
                    Console.WriteLine($"Por favor ingresa {i} numeros y te devolvere el valor maximo y minimo");
                    
                    for (int j = 0; j < i; j++) // Iteracion para llenar el arreglo
                    {
                        Console.Write($"Por favor ingrese el valor para la posicion {j + 1}: ");
                        arreglo[j] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine($"El valor Maximo es {arreglo.Max()} y el valor minimo es {arreglo.Min()}");
                    


                    break;

                    case 6:
                    //6.	Crea un arreglo con varios números enteros y escribe un programa que cuente cuántos números son pares y cuántos son impares.

                    Console.WriteLine("Por favor define el tamano del arreglo a evaluar");
                    i = int.Parse(Console.ReadLine()); // Asignando la longitud del arreglo
                    int contador_pares = 0; // definiendo variables para contar pares e impares
                    int contador_impares = 0;// definiendo variables para contar pares e impares
                    int[] arreglo_enteros = new int[i]; // Declarando el arreglo de tamano n
                    Console.WriteLine($"Por favor ingresa {i} numeros y te dire cuantos pares y cuantos impares tiene");


                    for (int j = 0; j < i; j++) // Iteracion para llenar el arreglo
                    {
                        Console.Write($"Por favor ingrese el valor para la posicion {j + 1}: ");
                        arreglo_enteros[j] = int.Parse(Console.ReadLine());
                    }


                    for (int j = 0; j < i; j++)
                    {
                        if (arreglo_enteros[j] % 2 == 0)
                        {
                            contador_pares++;
                        }
                        else
                        {
                            contador_impares++;

                        }

                    }
                    Console.WriteLine($"El arreglo tiene {contador_pares} numeros pares y {contador_impares} numeros impares");


                    break;

                    case 7:
                    //7.	Crea un arreglo de 5 elementos y escribe un programa que imprima el arreglo en orden inverso.
                    int[] arreglo_inverso = new int[5]; // Declarando el arreglo de tamano 5
                    Console.WriteLine("Por favor ingresa 5 numeros y te devolvere el arreglo en orden inverso");
                    for (int j = 0; j <5; j++) // Iteracion para llenar el arreglo
                    {
                        Console.WriteLine($"Por favor ingrese el valor para la posicion: {j+1}");
                        arreglo_inverso[j] = int.Parse(Console.ReadLine());
                    }


                    arreglo_inverso = arreglo_inverso.Reverse().ToArray(); // Invertir el orden del arreglo


                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine($"Numero {j+1} = {arreglo_inverso[j]}");
                    }

                    break;

                    //case 8:
                    ////8.	Realice un programa que tenga las siguientes operaciones. Tiene 4 vectores A,B,C y D de 10 elementos numéricos cada uno, 
                    ////llene el vector A con números pares, el vector B con números impares, el vector C con la suma de A + B, el vector D con la resta de A – B. 
                    ////Determinar la suma de cada vector y utilizarlo para llenar el vector R que 4 elementos numéricos, es decir la suma del vector A corresponde a la 
                    ////posición 0 del Vector R, la suma del vector B corresponde a la posición 1 del vector R, y así respectivamente con C y D. Imprima el vector R.
                    //int[] vectorA = new int[10];
                    //int[] vectorB = new int[10];
                    //int[] vectorC = new int[10];
                    //int[] vectorD = new int[10];

                    ////Primera Forma aleatorio fallida -_-
                    ////System.Random aleatorio = new System.Random();
                    ////Console.WriteLine($"Numero Aleatorio {aleatorio}");

                    ////Segunda Forma aleatorio, creando instancia aleatoria para generacion.
                    //Random aleatorio = new Random();
                    ////int numaleatorio = aleatorio.Next(1,101); //Numero aleatorio asignado a variable de prueba. No se necesito en final de proyecto
                    ////Console.WriteLine($"Prueba Impresion Aleatoria segunda forma {numaleatorio}");

                    //for (int j = 0; j < 10; j++)
                    //{
                    //    if(numeroaleatorio aleatorio.Next()%2==0)
                    //    {
                    //        vectorA[j] = aleatorio.Next(1, 101);
                    //    }
                    //    else
                    //    {
                    //        j--;
                    //    }



                    //}





                    //break;


                default:

                        Console.WriteLine("Debera selecciona un numero entero entre 1 y 12");
                        break;
                }

            


            Console.ReadKey();






        }
    }
}
