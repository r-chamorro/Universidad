using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vect3tercero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.	Sean los vectores d= (8,8,2) y e=(10,15,17) obtenga 5d*4e donde resuelva lo siguiente: 5d*4e=(5d1 4e1 + 5d2 4e2 + 5d3 4e3…)

            int[] d = { 8, 8, 2 };
            int[] e = { 10, 15, 17 };
            int resultado = 0;



            for (int i = 0; i < 3; i++)
            {
                resultado += (5 * d[i]) * (4 * e[i]);

            }
            Console.WriteLine("El resultado de 5d * 4e es: " + resultado);

            Console.ReadKey();
        }
    }
}
