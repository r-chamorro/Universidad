using System;


namespace PromedioNumeros
{
    internal class Program
    {

        /*
         1.	Calcular el promedio de 5 números ingresados por teclado
         */
        static void Main(string[] args)
        {
            //Definicion de Variables
            double acumulador =0;
            int contador = 0;

            while (contador<5) 
            {
                Console.WriteLine("Por favor ingrese un numero!");
                acumulador = (double.Parse(Console.ReadLine()))+acumulador;
                contador++;


            }
            Console.WriteLine($"El promedio de estos numeros es: {Math.Round((acumulador/contador),2)}");
            //Console.WriteLine(contador);
            Console.ReadKey();
            





        }
    }
}
