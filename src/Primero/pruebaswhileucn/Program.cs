using System;


namespace pruebaswhileucn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, clave, confirmacion;
            

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su clave: ");
            clave = Console.ReadLine();


            Console.WriteLine("Su clave ha caducado, por favor introduzca nueva clave");
            clave = Console.ReadLine();

            Console.WriteLine("Confirme su clave: ");
            confirmacion = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                if (clave == confirmacion)
                {
                    Console.WriteLine("Clave cambiada con exito");
                    break;
                }
                else
                {
                    Console.WriteLine("Las claves no coinciden, intente nuevamente");
                    Console.WriteLine("Confirme su clave: ");
                    confirmacion = Console.ReadLine();
                }
            }

            Console.ReadKey();





        }
    }
}
