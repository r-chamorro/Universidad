
using System;
using System.Security.Cryptography;

namespace EjerciciosdeCasos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Programas para practica de casos con la estrucutra Switch!             
            
            // Configuraciones esteticas del programa
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title= "Estructuras Switch";
            
            // Brindando las opciones de programas al usuario:
            

            // Definicion de Variables Generales
            int opcion, calificacion,c,d;   // Variables enteras usadas a travez de los programas disponibles
            char nota;                      // Variable de 1 caracter para selector de opciones en programa 2
            double a, b;                    // Variable decimales para operaciones matematicas en programa 3 
            bool igual;                     // Booleano para definir decision en programa 5
            string resultado;               // String para almacenar el resultado de la conversion en programa 7


            // Mostrando todos los programas disponibles para uso
            Console.WriteLine("Bienvenido a su selector de Programas!");
            Console.WriteLine("Por favor elige una opcion del listado!");
            Console.WriteLine("1 - Lector de Calificaciones!");
            Console.WriteLine("2 - Evaluador de Notas en letras!");
            Console.WriteLine("3 - Calculadora Simple!");
            Console.WriteLine("4 - Letras por departamentos!");
            Console.WriteLine("5 - Comparador de Numeros!");
            Console.WriteLine("6 - Formas Geometricas!");
            Console.WriteLine("7 - Convertidor de Numeros!");


            opcion = int.Parse(Console.ReadLine()); // Almacena la opcion seleccionada y ejecuta el programa que corresponde

            switch (opcion)
            {
               
                case 1:
                    /*
               Realice un programa que permita mostrar un mensaje, el cual debe estar en función de la calificación que proporciona el usuario, la cual es un número
               entero que va del 6 al 10. 
               ____________________________________________________________________
               CALIFICACIÓN        ||     MENSAJE
               ____________________________________________________________________
                   6               ||     Estudia en la próxima
                   7               ||     Has aprobado con las completas.
                   8               ||     Muy bien, sigue así.
                   9               ||     Perfecto, lo has logrado
                   10              ||     Excelente, eres uno de los mejores.!!
               Otra calificación   ||     Sigue adelante.
               --------------------------------------------------------------------
                */

                    // Mostrando instrucciones y funcionalidad del programa
                    Console.WriteLine("Bienvenido a tu evaluador de Notas");
                    Console.WriteLine("En esta escuela evaluamos del 1 al 10");
                    Console.Write("Por favor ingresa tu nota: ");
                    calificacion = int.Parse(Console.ReadLine());

                    // Proceso: Evaluando la seleccion del usuario para mostrar los posibles resultados
                    switch (calificacion) 
                    {
                        case 6:
                            Console.WriteLine("Estudia en la próxima");

                            break;

                        case 7:
                            Console.WriteLine("Has aprobado con las completas.");

                            break;

                        case 8:
                            Console.WriteLine("Muy bien, sigue así.");

                            break;

                        case 9:
                            Console.WriteLine("Perfecto, lo has logrado");

                            break;
                        case 10:
                            Console.WriteLine("Excelente, eres uno de los mejores.!!");
                            break;

                        default:
                            Console.WriteLine("Sigue adelante.");
                            break;
                    
                    }
                    break;

                case 2:
                    /*
                        Escribir un programa que introduzca una calificación (A-E) y emita el mensaje
                        correspondiente de acuerdo a la nota ingresada:
                        A- Excelente
                        B- Buena
                        C- Regular
                        D- Suficiente
                        E- No Suficiente
                     */

                    // Mostrando instrucciones y funcionalidad del programa
                    Console.WriteLine("Bienvenido a tu evaluador de calificaciones");
                    Console.WriteLine("En esta escuela evaluamos con letras");
                    Console.Write("Por favor ingresa la letra que corresponde a tu nota:");
                    nota = Char.Parse(Console.ReadLine()); 
                    switch (nota) 
                    {
                        case 'A': case 'a':
                            Console.WriteLine("Excelente");

                            break;

                        case 'B': case 'b':
                            Console.WriteLine("Buena");
                            break;
                        case 'C': case 'c':
                            Console.WriteLine("Regular");
                            break;
                        case 'D': case 'd':
                            Console.WriteLine("Suficiente");
                            break;
                        case 'E': case 'e':
                            Console.WriteLine("No Suficiente");
                            break;
                        default :
                            Console.WriteLine("Valor invalido, por favor intenta de nuevo!");
                            break;

                    }

                    break;

                case 3:
                    /*
                    Realice un programa que simule el comportamiento de una calculadora con
                    las 4 operaciones básicas: Suma, Resta, Multiplicación, División de dos
                    números ingresados por el usuario. Seleccione la operación utilizando la
                    instrucción switch
                     */
                    
                    // Mostrando instrucciones y funcionalidad del programa
                    
                    Console.WriteLine("Bienvenido a tu calculadora Basica!");
                    Console.WriteLine("Deberas ingresas 2 valores numericos y luego elegir que operacion hacer");
                    Console.Write("Ingresa el valor 1: ");
                    a = double.Parse(Console.ReadLine()); // Convierte el string en Double y Asigna la varialbe a
                    Console.Write("Ingresa el valor 2: ");
                    b = double.Parse(Console.ReadLine());// Convierte el string en Double y Asigna la varialbe b
                    Console.WriteLine("Excelente! Tengo los valores!");
                    Console.WriteLine("Ahora dime que deseas hacer?");
                    Console.WriteLine("1 - Sumar!");
                    Console.WriteLine("2 - Restar! ");
                    Console.WriteLine("3 - Multiplicar! ");
                    Console.WriteLine("4 - Dividir! ");
                    
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion) 
                    {
                        case 1:
                            Console.WriteLine($"El resultado de sumar {a} con {b} es igual a: {a+b}");

                            break;
                        case 2:
                            Console.WriteLine($"El resultado de restar {a} con {b} es igual a: {a - b}");
                            break;

                        case 3:
                            Console.WriteLine($"El resultado de multiplicar {a} con {b} es igual a: {Math.Round((a * b),2)}");
                            break;

                        case 4:
                            if (b == 0)
                            {
                                Console.WriteLine("No es posible dividir entre 0! Por favor intenta con otro Numero!");
                                break ;
                            }
                            else
                            {
                                Console.WriteLine($"El resultado de dividir {a} entre {b} es igual a: {Math.Round((a / b),2)}");
                            }
                            break;
                    }

                    break;

                case 4:
                    /*
                    Escribir un programa que introduzca una Letra mayúscula o minúscula. y
                    emita el mensaje correspondiente de acuerdo a lo siguiente:
                    ✓ M – Masaya, ciudad de las flores.
                    ✓ L – León, viva león jodido.
                    ✓ G – Granada, la gran sultana.
                    ✓ B – Boaco, Ciudad de dos pisos.
                     */

                    // Mostrando instrucciones y funcionalidad del programa

                    Console.WriteLine("Hola te dire que secreto esconde la letra que elijas!");
                    Console.WriteLine("Por favor selecciona una letra de la lista:");
                    Console.WriteLine("Opciones: ");
                    Console.Write("M, ");
                    Console.Write("L, ");
                    Console.Write("G, ");
                    Console.WriteLine("B");
                                        
                    nota = char.Parse(Console.ReadLine());
                    switch (nota) 
                    {
                        case 'm': case 'M':
                            Console.WriteLine("Masaya, ciudad de las flores.");
                            break;
                        case 'l': case 'L':
                            Console.WriteLine("León, viva león jodido.");
                            break;
                        case 'g': case 'G':
                            Console.WriteLine("Granada, la gran sultana.");
                            break;
                        case 'b': case 'B':
                            Console.WriteLine("Boaco, Ciudad de dos pisos.");
                            break;
                        default:
                            Console.WriteLine("Esa no me la se, intenta eligiendo de la lista sugerida!");
                            break;                    
                    }

                    break; 
             
                case 5:
                    /*
                    Escribir un programa que me permita ingresar 2 valores numéricos enteros, luego comparar si son iguales, almacenar en una variable bool para ser
                    utilizada como expresión en switch. Ejemplo: valor = a==b; (De esta forma obtendrá si es falso “False” o
                    verdadero “True”.) 
                    ✓ Si la expresión es verdadera – true. Mostrar el siguiente mensaje.
                        "Los valores ingresados son iguales"
                    ✓ Si la expresión es falsa – false. Mostrar el siguiente mensaje. "Los
                        valores ingresados son diferentes"
                     */

                    // Mostrando instrucciones y funcionalidad del programa

                    Console.WriteLine("Comparador de Numeros!");
                    Console.WriteLine("Por favor ingresa 2 numeros enteros y te dire si son iguales no!");
                    Console.WriteLine("Ingresa el primer numero: ");
                    c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo numero: ");
                    d = int.Parse(Console.ReadLine());
                    igual = c == d;
                    switch(igual)
                    {
                        case true:
                            Console.WriteLine($"Los numeros {c} y {d} son Iguales!");
                            break;
                        case false:
                            Console.WriteLine($"Los numeros {c} y {d} son Diferentes!");
                            break;
                    }
                    break;

                case 6:
                    /*
                    Escribir un programa que me permita mostrar un menú de opción utilizando
                    según lo siguiente:
                    1 – Circulo
                    2 – Cuadrado
                    3 – Triangulo
                    4 – Trapecio
                    Luego mostrar un mensaje por cada opción
                     */

                    // Mostrando instrucciones y funcionalidad del programa

                    Console.WriteLine("Selecciona una opcion!");
                    Console.WriteLine("1 - Circulo");
                    Console.WriteLine("2 - Cuadrado");
                    Console.WriteLine("3 - Triangulo");
                    Console.WriteLine("4 - Trapecio");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion) 
                    {
                        case 1:
                            Console.WriteLine("Ha seleccionado el Circulo");

                            break;
                        case 2:
                            Console.WriteLine("Ha seleccionado el Cuadrado");
                            break;
                        case 3:
                            Console.WriteLine("Ha seleccionado el Triangulo");
                            break;
                        case 4:
                            Console.WriteLine("Ha seleccionado el Trapecio");
                            break;
                        default:
                            Console.WriteLine("Invalido!, por favor seleccione un valor de la lista!");
                            break;
                    
                    }

                    break;

                case 7:
                    /*
                    Escribir un programa que permita introducir un número. y luego mostrar un
                    menú de opciones:
                    B – Binario
                    H – Hexadecimal
                    O – Octal.
                     */

                    // Mostrando instrucciones y funcionalidad del programa

                    Console.WriteLine( "Hola por favor ingresa un Numero");
                    c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Gracias! Ahora selecciona la opcion a la que lo quieres convertir:");
                    Console.WriteLine("B - Binario");
                    Console.WriteLine("H - Hexadecimal");
                    Console.WriteLine("O - Octal");
                    nota = char.Parse(Console.ReadLine());


                    /*
                    https://csharp.academy/how-to-convert-an-integer-to-binary-in-c/
                    Basado es la documentacion de esta pagina es posible convertir el valor de un numero INT a BIN utilizando la conversion de sistema
                    Convert.ToString(x,2); en este modo el primer elemento es un variable x y el segundo argumento es la potencia a la que ese numero se mostrara,
                    para nuestra necesidad, empleamos la potencia de base 2, que es la empleada en numeros binarios, para numeros octales usamos la potencia
                    en base 8
                    
                    Para Hexadecimales cambia un poco el tipo de conversion, en esta caso deberemos recurrir a la variable en la cual almacenamos el valor que 
                    el usuario nos da, esta variable al ser considerada un objeto tiene metodos, el metodo que ocupamos es el x.ToString("X") donde x es 
                    una variable cualquiera y "X" determina que estaremos recibiendo de regreso un valor como texto en formato Hexadecimal

                     */
                    
                    // Mostrando instrucciones y funcionalidad del programa

                    switch (nota)
                    {
                        case 'B': case 'b':
                            resultado = Convert.ToString(c,2);
                            Console.WriteLine($"El Numero {c} en Binario se expresa asi: {resultado}");

                            break;

                        case 'H': case 'h':
                            //resultado = c.ToString("X");
                            //Console.WriteLine($"El Numero {c} en Binario se expresa asi: {resultado}");
                            resultado = Convert.ToString(c, 16);
                            Console.WriteLine($"El Numero {c} en Binario se expresa asi: {resultado}");

                            break;
                        case 'O': case 'o':
                            resultado= Convert.ToString(c,8);
                            Console.WriteLine($"El Numero {c} en Octal se expresa asi: {resultado}");
                            break;
                            default :
                            Console.WriteLine("Invalido! Por favor selecciona una valor de los disponibles");

                            break;
                    }
                    break;
                default:
                    Console.WriteLine( "Invalido! Por favor selecciona de la lista!");
                    break;
            
            }


            
            
            
            Console.ReadKey();
        }
    }
}
