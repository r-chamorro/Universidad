using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectoR10yer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10] { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 };
            int[] X = new int[10]; // Arreglo para negativos
            int[] Y = new int[10]; // Arreglo para positivos
            int j = 0; // Índice para negativos
            int k = 0; // Índice para positivos

       
            for (int i = 0; i < 10; i++)
            {
                if (vector[i] < 0)
                {
                    X[j] = vector[i];
                    j++;
                }
                else
                {
                    Y[k] = vector[i];
                    k++;
                }
            }

          
            Console.WriteLine("Vector Original:");
            foreach (int num in vector)
            {
                Console.Write(num + " ");
            }

            
            Console.WriteLine("\n\nArreglo X (Negativos):");
            for (int i = 0; i < j; i++) 
            {
                Console.Write(X[i] + " ");
            }

            Console.WriteLine("\n\nArreglo Y (Positivos):");
            for (int i = 0; i < k; i++) 
            {
                Console.Write(Y[i] + " ");
            }

            Console.WriteLine("\n");
        }
        
       
    }
}



