using System;
using System.Globalization;


namespace EstructuraSelectiva_Practicas
{
    internal class Program
    {


        static void Main(string[] args)
        {
            /*
             EP1. Realizar una aplicación que permita simular lo siguiente: Solicitar Usuario y Contraseña si ambos son 
            correctos mostrar un menú que le permita ir a los ejercicios propuestos en caso de ser incorrecto aparezca la 
            ventana en fondo color ROJO con texto Blanco (“Usuario o Contraseña Incorrecto”) 
             */
            string usuario, contrasena, user, pass;
            usuario = "admin";
            contrasena = "1234";
            Console.Write("Bienvenido! Por Favor ingrese su usuario: ");
            user = Console.ReadLine();
            Console.Write("Gracias, por favor ingresa tu contreaña: ");
            pass= Console.ReadLine();

            if (usuario == user && contrasena == pass)
            {
                Console.WriteLine("Bienvenido Al menu de opciones!");
                Console.WriteLine("1 - Calculadora");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion) 
                {
                    /*
                     EP2. Escriba un programa que permita leer un valor entero, calcule lo siguiente: 
                    cubo, cuadrado, raíz cuadrada, tangente, seno, coseno. (Utilice 2 valores decimales para la salida) 
                     
                     */

                    case 1:
                        Console.WriteLine("Por favor ingrese un numero Cualquiera");
                        float numero = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Gracias! Hare operaciones con ese numero por ti");
                        Console.WriteLine($"El cubo de {numero} es: {Math.Round(Math.Pow(numero,3),2)}");
                        Console.WriteLine($"El Cuadrado de {numero} es: {Math.Round(Math.Pow(numero, 2), 2)}");
                        Console.WriteLine($"La raiz Cuadrada de {numero} es: {Math.Round(Math.Sqrt(numero), 2)}");
                        Console.WriteLine($"La tangente de {numero} es: {Math.Round(Math.Tan(numero), 2)}");
                        Console.WriteLine($"El Seno de {numero} es: {Math.Round(Math.Sin(numero), 2)}");
                        Console.WriteLine($"El coseno de {numero} es: {Math.Round(Math.Cos(numero), 2)}");
                        break;

                
                        default:

                        Console.WriteLine("Opcion Invalida, Por favor selecciona una de las opciones disponibles");
                        break;


                }
            }
            else
            {
                
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Usuario o Contraseña Incorrecto");
            }

            Console.ReadKey();


        }
    }
}
