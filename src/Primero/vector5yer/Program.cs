using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vector5yer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.	Realice un vector con 10 elementos y devuelva la suma de los mismos

            int[] vector = { 88, 3, 9, 10, 11, 15, 18, 13, 55, 85 };
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                suma += vector[i];

            }
            Console.WriteLine("El resultado de la suma de los vectores creados es : " + suma);

            Console.ReadKey();

        }
    }
}
