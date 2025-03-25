using System;


namespace evaluadordeNotas
{
    internal class Program
    {
        static void Main(string[] args)

        /*
         4.	Dado N notas de un estudiante calcular:
        •	Cuantas notas tiene reprobadas.
        •	Cuantas notas aprobadas.
        •	El promedio de notas.
        •	El promedio de notas aprobadas y reprobadas.

         */
        {
            //Declarando Variables
            int materias;
            int notas = 0;
            int nota = 0;
            int contador = 1;
            int contadorAprobado= 0;
            int contadorReprobado = 0;
            double notasAprobadas = 0;
            double notasReprobadas=0;
            double promedioNotas;
            double promedioAprobado;
            double promedioReprobado;

            Console.WriteLine("Te dire que notas has aprobado y cuales no");
            Console.WriteLine("Tambien te dare el promedio de aprobadas y reprobadas");
            Console.WriteLine("Cuantas notas vamos a evaluar?");
            materias = Convert.ToInt32(Console.ReadLine());

            while (contador <=materias)
            {
                Console.Write($"Ingrese la nota {contador}: ");

                //Ocupamos 2 variables una para guardar el acumulado de notas y el otro para hacer la evaluacion y asiganacion de notas aprobadas y reprobadas
                nota = Convert.ToInt32(Console.ReadLine());
                notas += nota;
                if (nota > 70)
                {
                    notasAprobadas += Convert.ToDouble(nota);
                    contadorAprobado++;

                }
                else 
                {
                    notasReprobadas += Convert.ToDouble(nota);
                    contadorReprobado++;
                }
                contador++;
            }

            //Calculando promedios para mostrar a usuario
            promedioNotas = notas / materias;
            promedioAprobado = Math.Round((notasAprobadas/contadorAprobado),2);
            promedioReprobado = Math.Round((notasReprobadas / contadorReprobado),2);

            //Console.WriteLine(contadorAprobado);
            //Console.WriteLine(contadorReprobado);

            
            Console.WriteLine($"Tienes un total de {contadorAprobado} Aprobadas y {contadorReprobado} Reprobadas ");
            Console.WriteLine($"El promedio de tus notas aprobadas es de {promedioAprobado} %");
            Console.WriteLine($"El promedio de tus notas reprobadas es de {promedioReprobado} %");
            Console.WriteLine($"Tu promedio general es de {promedioNotas}  %");
            
            Console.ReadKey();


        }
    }
}
