using System;


namespace primerexamenparcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Realizar un menú para poder tener acceso a la solución de las siguientes operaciones.
        1. El dueño de una tienda compra un artículo a un precio determinado. Obtener el precio en que lo debe vender para obtener una ganancia del 40%
        2. Calcular la calificación de un alumno a partir de la nota numérica, de la siguiente manera: 
        AI (si nota<60); AE (si nota >=61 y nota<=75); AS (si nota >=76 y <=89); AA (si nota >=91). Utilice el operador condicional.  
        En caso que la nota sea <0 ó >100 mostrar un mensaje que diga nota invalida, Ingrese una nota valida. 
            (Personalice su ejercicio para que cambie de color según el resultado)
            */

            // Definiendo Variables a Usar
            int menu, nota;
            double precio, utilidad;

            try
            {

                Console.Title = "Examen I Parcial";
                Console.WriteLine("Bienvenido Al menu!");
                Console.WriteLine("Por favor seleccione una opcion");
                Console.WriteLine("1 - Calculo de Utilidad");
                Console.WriteLine("2 - Evaluacion de Notas");
                menu = Convert.ToInt32(Console.ReadLine());


                switch (menu)
                {

                    case 1:
                        // Calculadora de Utilidad
                        Console.WriteLine("Por favor ingresa el Precio original del Producto");
                        precio = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Deberas Vender el producto a {precio*1.4} para Tener un 40% de Ganancia!");



                        break;

                    case 2:

                        // Evaluacion de Nota por alumno
                        Console.WriteLine("Hola Ingresa tu nota y te dire tu rango");
                        nota = Convert.ToInt32(Console.ReadLine()) ;

                        if (nota > 0 && nota < 60)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.WriteLine("AI = Aprobado Insuficiente");

                        }
                        else if (nota >= 60 && nota <= 75)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.WriteLine("AE = Aprobado Escasamente");
                        }
                        else if (nota >= 76 && nota <= 90)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("AS = Aprobado Suficiente");
                        }
                        else if (nota >= 91 && nota <= 100)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("AA = Aprobado Altamente");
                        }
                        else if (nota > 100)
                        {
                            Console.WriteLine("Nota Invalida, ingresa un valor valido");

                        }
                        else

                        {
                            Console.WriteLine("Nota Invalida, ingresa un valor valido");
                        }





                        break;

                    default:

                        Console.WriteLine("Opcion Invalida, por favor seleccione del menu!");
                        break;
                }


            }
            catch (Exception)
            {

                Console.WriteLine("Opcion Invalida!");
            }
            finally 
            {
                Console.WriteLine("\n Programa Finalizado");
            }

        }
    }
}
