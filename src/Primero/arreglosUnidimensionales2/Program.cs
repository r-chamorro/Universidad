using System;
using System.IO;
using System.Linq;
using System.Timers;
using System.Xml;


namespace arreglosUnidimensionales2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.Title = "Arreglos Unidimensionales 2";
            Console.WriteLine("Selecione una opcion del menu!");
            Console.WriteLine("1 - Promedio de Notas");
            Console.WriteLine("2 - Calculos con Vectores");
            Console.WriteLine("3 - Mas operaciones con Vectores");
            Console.WriteLine("4 - Revirtiendo un arreglo");
            Console.WriteLine("5 - Suma de valores en un arreglo");
            Console.WriteLine("6 - Promedio Pares");
            Console.WriteLine("7 - Vectores positivos y negativos");
            Console.WriteLine("8 - Promedio, Mayores y Menores");
            Console.WriteLine("9 - Buscador de Nombres");

            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    //1. Realice un programa que me permita obtener el promedio de notas guardadas en un arreglo, solicitando al usuario la cantidad de calificaciones a ingresar para promediar.

                    Console.WriteLine("Hola Bienvenido!");
                    Console.WriteLine("Te dare el promedio de tus notas");
                    Console.Write("Cuantas clases vamos a evaluar: ");
                    int cantidadDeNotas = int.Parse(Console.ReadLine()); // Cantidad de notas a evaluar
                    int[] clases = new int[cantidadDeNotas]; // Arreglo de notas
                    for (int i = 0; i < cantidadDeNotas; i++) // Iteracion para ingresar las notas
                    {
                        Console.Write($"Ingrese la nota de la clase {i + 1} : -");
                        clases[i] = int.Parse(Console.ReadLine());
                    }

                    if (clases.Average() >= 90) // Condicional para notas mayores a 90
                    {
                        Console.WriteLine($"Tu promedio es de {clases.Average()}");
                        Console.WriteLine($"Tienes un Promedio Sobresaliente! Excelente");
                    }
                    else if (clases.Average() >= 60 && clases.Average() < 90) // Condicional para notas mayores a 60 y menores a 90
                    {
                        Console.WriteLine($"Tu promedio es de {clases.Average()}");
                        Console.WriteLine($"Si pasas, muy bien!");
                    }
                    else // Condicional para notas menores a 60
                    {
                        Console.WriteLine($"Tu promedio es de {clases.Average()}");
                        Console.WriteLine($"Debes esforzarte mas, no has pasado");

                    }
                    break;

                case 2:
                    //2.	Sean los vectores d= (3,7,2) y e= (10,4,11) obtenga d*e donde resuelva lo siguiente: d*e= (d1 e1 + d2 e2 + d3 e3…)
                    int[] vectord = { 3, 7, 2 }; // Definiendo Vectores estaticos
                    int[] vectore = { 10, 4, 11 };
                    int sumaVectores = 0; // Variable para almacenar la operacion de los vectores


                    for (int i = 0; i < 3; i++) // Iteracion para multiplicar los valores de los vectores
                    {
                        sumaVectores += vectord[i] * vectore[i];
                    }
                    Console.WriteLine("Dado el Vector D: "); // Mostrando los valores del vector D
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Valor {i + 1}: {vectord[i]}");
                    }
                    Console.WriteLine("Dado el Vector E: "); // Mostrando los valores del vector E
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Valor {i + 1}: {vectore[i]}");
                    }

                    Console.WriteLine($"La suma de los valores de los vectores D y E es igual a: {sumaVectores} "); // Resultado
                    break;


                case 3:
                    //3.	Sean los vectores d= (8,8,2) y e=(10,15,17) obtenga 5d*4e donde resuelva lo siguiente: 5d*4e=(5d1 4e1 + 5d2 4e2 + 5d3 4e3…)
                    int[] vectord2 = { 8, 8, 2 }; // Declarando vectores estaticos
                    int[] vectore2 = { 10, 15, 17 };
                    int sumaVectores2 = 0; // Variable para almacenar la operacion de los vectores

                    for (int i = 0; i < 3; i++) // Operando Con vectores de acuerdo a solicitud de ejercicio
                    {
                        sumaVectores2 += (vectord2[i] * 5) * (vectore2[i] * 4);
                    }
                    Console.WriteLine("Dado el Vector D: ");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Valor {i + 1}: {vectord2[i]}");
                    }
                    Console.WriteLine("Dado el Vector E: ");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Valor {i + 1}: {vectore2[i]}");
                    }

                    Console.WriteLine($"La suma de los valores de los vectores D y E es igual a: {sumaVectores2} ");

                    break;


                case 4:
                    //4.	Realice un programa que lea el arreglo (14, 7, 3, 45, 78, 12, 56, 90, 123, 567) y lo muestre de la siguiente forma (567, 123, 90, 56, 12, 78, 45, 3, 7, 14)
                    int[] arreglo1 = { 14, 7, 3, 45, 78, 12, 56, 90, 123, 567 }; // Declarando arreglo estatico

                    Console.WriteLine("Dado el Arreglo: ");

                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write($"{arreglo1[i]}, ");
                    }
                    Console.WriteLine("Su inverso es: ");

                    for (int i = 9; i >= 0; i--)
                    {
                        Console.Write($"{arreglo1[i]}, ");
                    }
                    break;

                case 5:
                    //5.	Realice un vector con 10 elementos y devuelva la suma de los mismos
                    int[] vector10 = new int[10]; // Declarando arreglo para 10 elementos
                    int sumaVector10 = 0; // Variable para almacenar la suma de los elementos del arreglo

                    for (int i = 0; i < 10; i++) // Iteracion para ingresar los valores del arreglo
                    {
                        Console.Write($"Ingrese el valor {i + 1}: ");
                        vector10[i] = int.Parse(Console.ReadLine());
                    }

                    for (int i = 0; i < 10; i++) // Iteracion para sumar los valores del arreglo
                    {
                        sumaVector10 += vector10[i];
                    }

                    Console.WriteLine($"La sumatoria de todo el arreglo es igual a: {sumaVector10}");

                    break;

                case 6:
                    //6.Calcular el promedio de n números que son pares, los almacene en otro arreglo y al final muestre ambos arreglos en pantalla.
                    Console.Write("Por favor indique el tamano del arreglo a evaluar: ");
                    int cantidadNumeros = int.Parse(Console.ReadLine()); // Definiendo el tamano del arreglo
                    int[] numerosn = new int[cantidadNumeros]; // Declarando el arreglo usuario
                    int cantidadPares = 0; // Variable para almacenar la suma de los numeros pares
                    int[] numerospares; // Declarando el arreglo para los numeros pares

                    for (int i = 0; i < cantidadNumeros; i++) // Iteracion para ingresar los valores del arreglo
                    {
                        Console.Write($"Ingrese el valor {i + 1}: ");
                        numerosn[i] = int.Parse(Console.ReadLine());
                        if (numerosn[i] % 2 == 0) // Condicional para determinar si el numero es par
                        {
                            cantidadPares++; // Determinando el tamano del arreglo de pares
                        }

                    }

                    numerospares = new int[cantidadPares]; // Definiendo el tamano del arreglo de pares

                    for (int i = 0, j = 0; i < cantidadNumeros; i++) // Iteracion para ingresar los valores del arreglo de pares
                                                                     //Se crearon 2 variables una para el grupo original y la 2da para la iteracion del grupo de pares
                                                                     //Presentaba errores al contar pues es muy posible que el grupo original fuese mayor al de pares
                                                                     //Por lo que se creo una variable j para el grupo de pares la cual solo avanza si el valor es guardado en el arreglo
                    {
                        if (numerosn[i] % 2 == 0) // Condicional para determinar si el numero es par
                        {
                            numerospares[j] = numerosn[i]; // Almacenando los valores pares en el arreglo de pares
                            j++; // Incrementando el contador de pares al siguiente valor
                        }
                    }

                    Console.WriteLine("El valor inicial del arreglo es: ");
                    for (int i = 0; i < cantidadNumeros; i++) // Mostrando los valores del arreglo original uno por uno
                    {
                        Console.WriteLine($"Valor {i + 1}: {numerosn[i]}");
                    }
                    Console.WriteLine("El arreglo de pares es: ");

                    for (int i = 0; i < cantidadPares; i++) // Mostrando los valores del arreglo original uno por uno
                    {
                        Console.WriteLine($"Valor {i + 1}: {numerospares[i]}");
                    }

                    Console.WriteLine($"El promedio de los valores pares es: {numerospares.Average()}"); // Extrayendo el promedio de los valores pares

                    break;

                case 7:
                    //7.Realice un vector de tamaño 10 con números negativos y positivos.Luego almacene los valores negativos en un arreglo X y almacene los 
                    //valores positivos en un arreglo Y. Por ultimo mostrar en pantalla todos los arreglos. 

                    Console.WriteLine("Ingrese 10 numeros");

                    int[] vector10numeros = new int[10]; // Declarando el arreglo de 10 elementos
                    int cantidadNegativos = 0; // Variable para almacenar la cantidad de numeros negativos
                    int cantidadPositivos = 0; // Variable para almacenar la cantidad de numeros positivos
                    int[] vectorNegativos; // Declarando el arreglo de numeros negativos
                    int[] vectorPositivos; // Declarando el arreglo de numeros positivos


                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write($"Ingrese el numero {i+1}: ");
                        vector10numeros[i] = int.Parse(Console.ReadLine()); // LLenando el arreglo de 10 elementos
                        if (vector10numeros[i] > 0) // Condicional para determinar si el numero es positivo
                        {
                            cantidadPositivos++; // Incrementando el contador de positivos
                        }
                        else
                        {
                            cantidadNegativos++; // Incrementando el contador de negativos
                        }

                    }
                    vectorNegativos = new int[cantidadNegativos]; // Definiendo el tamano del arreglo de negativos
                    vectorPositivos = new int[cantidadPositivos]; // Definiendo el tamano del arreglo de positivos


                    for (int i = 0,j=0,k=0;i<10;i++)

                    {
                        if (vector10numeros[i] > 0) // Condicional para determinar si el numero es positivo
                        {
                            vectorPositivos[j]= vector10numeros[i]; // Incrementando el contador de positivos
                            j++;
                        }
                        else
                        {
                            vectorNegativos[k] = vector10numeros[i]; // Incrementando el contador de negativos
                            k++;
                        }
                    }

                    Console.WriteLine("Arreglo Original de Numeros!");

                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"Numero: {vector10numeros[i]}");
                    }

                    Console.WriteLine("Arreglo de Negativos!");
                    for (int i = 0; i < cantidadNegativos; i++)
                    {
                        Console.WriteLine($"Numero: {vectorNegativos[i]}");
                    }
                    Console.WriteLine("Arreglo de Positivos!");
                    for (int i = 0; i < cantidadPositivos; i++)
                    {
                        Console.WriteLine($"Numero: {vectorPositivos[i]}");
                    }



                    break;

                case 8:
                    //8.Realice un vector con n elementos numéricos. Luego calcule el promedio e indique los menores y los mayores al mismo.
                    Console.WriteLine("Hola Aqui crearas un arreglo y te dire el promedio, valor maximo y minimo");
                    int[] arreglonum; // Variable tamano de arreglo
                    Console.WriteLine("Por favor define el tamano del arreglo: "); // Solicitando el tamano del arreglo
                    int tamanoarreglo = int.Parse(Console.ReadLine()); // Definiendo el tamano del arreglo
                    arreglonum = new int[tamanoarreglo]; // Creando arreglo de tamano n de acuerdo a usuario

                    for (int i = 0; i < tamanoarreglo; i++)
                    {
                        Console.Write($"Ingrese el valor {i + 1}: ");
                        arreglonum[i] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine($"El promedio de los numeros brindados es: {arreglonum.Average()}");
                    Console.WriteLine($"El valor maximo es: {arreglonum.Max()}");
                    Console.WriteLine($"El valor minimo es: {arreglonum.Min()}");
                    break;



                case 9:

                    //9.	Realice un arreglo que permite ingresar 10 nombres y luego le solicite al usuario que nombre desea buscar y
                    //      si lo encuentra lo muestre de lo contrario retornarlo a solicitar otro nombre.
                    string[] nombres = new string[10]; // Declarando arreglo de texto de 10 elementos
                    string nombreabuscar; // Variable para almacenar el nombre a buscar

                    
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write($"Ingrese el nombre {i+1}: ");
                        nombres[i] = Console.ReadLine(); // Llenando el arreglo de nombres

                    }
                    Console.WriteLine("Veamos si recuerdas que nombres ingresaste");
                    Console.WriteLine("Escribe un nombre que creas que esta en la lista y yo te dire si aciertas");
                    do
                    {
                        nombreabuscar = Console.ReadLine(); // Solicitando el nombre a buscar
                        if (nombres.Contains(nombreabuscar)) // Condicional para determinar si el nombre esta en la lista
                        {
                            Console.WriteLine($"El nombre {nombreabuscar} esta en la lista");
                            Console.WriteLine("Programa Finalizado");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"El nombre {nombreabuscar} no esta en la lista");
                            Console.WriteLine("Por favor ingrese otro nombre");
                            
                        }
                    } while (nombres.Contains(nombreabuscar)==false);






                    break;

                        default:
                    Console.WriteLine("Por favor Seleccione un valor entero entre 1 y 9");
                    break;
            }
            Console.ReadKey();

        }
    }
}
