using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_repeticion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ejercicios de estructura Ciclica:
            1- Escriba un programa que le pida al usuario su nombre y una clave. A continuación, le dirá
            que la clave ha caducado y que tiene que cambiarla, mostrando el siguiente mensaje “Su
            clave ha caducado. Por favor, introduzca su nueva clave”. Una vez leída esta clave, le
            pedirá que la confirme con el mensaje “Por favor, confirme su nueva clave”. Si la clave
            introducida coincide con la anterior, le informará que la clave se ha cambiado con éxito y si
            no, le mostrará el mensaje: “Por favor, vuelva a introducir su clave”, esta operación la
            repetirá un máximo de 5 veces, si coincide mostrará el mensaje: “La clave se ha cambiado
            con éxito”, en otro caso mostrara el mensaje: “Clave Incorrecta. Usuario Bloqueado”.
             */
            Console.Title = "Menu Principal";
            string usuario, clave, nuevaclave;
            int i = 1;

            Console.WriteLine("Por favor ingrese su usuario!");
            usuario = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su Contrasena!");
            clave = Console.ReadLine();
            Console.WriteLine("Su clave ha caducado");
            Console.WriteLine("Por favor ingresa tu nueva contrasena: ");
            clave = Console.ReadLine();
            Console.WriteLine("Por favor confirma tu contrasena");
            nuevaclave = Console.ReadLine();

            

            while (clave != nuevaclave  ) 
            {
                Console.WriteLine("La contrasena no coincide. Favor intenta de nuevo");
                nuevaclave = Console.ReadLine();
                i++;
                if (i == 5)
                {
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("Usuario Bloqueado!");
                    Console.ReadKey();
                    return;
                }

            }
            Console.WriteLine("Contrasena Actualizada con Exito");


            Console.ReadKey();

        }
    }
}
