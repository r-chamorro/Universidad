using System;


namespace multiplicarPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             10.	Hacer un programa que nos permita introducir un numero por teclado y realice lo siguiente: 
            comprobar si es par, e imprimir su tabla de multiplicar.
             
             */

            //Declarando Variables
            int numero;

            Console.WriteLine("Ingrese un numero entero");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("Es un Numero Par y su Tabla de multiplicar es: ");
                Console.WriteLine("____________________");
                for (int i = 1; i < 10; i++)
                {

                    Console.WriteLine($"{i} x{numero} = {numero * i}");
                    //Console.WriteLine($"{i} x 2 = {i * 2}");
                    //Console.WriteLine($"{i} x 3 = {i * 3}");
                    //Console.WriteLine($"{i} x 4 = {i * 4}");
                    //Console.WriteLine($"{i} x 5 = {i * 5}");
                    //Console.WriteLine($"{i} x 6 = {i * 6}");
                    //Console.WriteLine($"{i} x 7 = {i * 7}");
                    //Console.WriteLine($"{i} x 8 = {i * 8}");
                    //Console.WriteLine($"{i} x 9 = {i * 9}");

                }
                Console.WriteLine("____________________");
            }
            else
            {
                Console.WriteLine("El numero no es par");
                Console.WriteLine("Programa Finalizado");



            }
        }
    }
}
