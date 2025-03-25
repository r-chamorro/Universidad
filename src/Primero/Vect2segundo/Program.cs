using System;
using System.Linq;


namespace Vect2segundo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2.Sean los vectores d = (3, 7, 2) y e = (10, 4, 11) obtenga d*e donde resuelva lo siguiente: d* e = (d1 e1 + d2 e2 + d3 e3…)

            int[] d = { 3, 7, 2 };
            int[] e = { 10, 4, 11 };
            int obtenga = 0;


            for (int i = 0; i < 3; i++)
            {
                obtenga += d[i] * e[i];

            }

            Console.WriteLine("El resultado de d * e es: " + obtenga);

            Console.ReadKey();
        }
        
        
    }
}
