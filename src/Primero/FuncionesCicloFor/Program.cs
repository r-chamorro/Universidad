using System;


namespace FuncionesCicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            4 - Realice un programa en C# que muestre por pantalla las siguientes funciones: f(x) = x, f(x)
            = 2x, f(x) = x2, f(x) = √x. El programa mostrará las imágenes de dichas funciones para todos
            los valores de x comprendidos entre 1 y un número N dado por el usuario. Por ejemplo,
            para N = 6, el programa mostrará
             */

            int numero;
            double pordos, cuadrado, raiz;

            Console.Title = "Funciones Matematicas";
            Console.WriteLine("operaciones Matematicas!");
            Console.WriteLine("Ingrese un Numero");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,10} | {1,10} | {2,10} | {3,10}","f(x) = x","f(x) = 2x","f(x) = x^2", "f(x) = √x");
            Console.WriteLine("--------------------------------------------------");

            for (int i = 1; i <= numero; i++)
            {

                pordos = i * 2;
                cuadrado = Math.Round(Math.Pow(i, 2),2);
                raiz =Math.Round(Math.Sqrt(i),2);
                Console.WriteLine("{0,10} | {1,10} | {2,10} | {3,10}", i,pordos,cuadrado,raiz);

                
            }


            Console.ReadKey();

        }
    }
}
