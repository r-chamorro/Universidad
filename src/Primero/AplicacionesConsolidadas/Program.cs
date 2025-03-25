using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionesConsolidadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Menu de aplicaciones disponibles para el usuario:
            // Dejaremos acceso a los primeros 4 programas asignados por el maestro.

            // Definiendo Variables generales:
            
            int opcion;         // Almacenara la opcion que el usuario seleccione para ejecutar el programa del grupo
            string nombre;      // Almacenara el nombre de la persona si emplea el sistema de facturas.
            double subtotal;    // Almacenara el valor del subtotal del usuario en el sistema de facturas
            double iva;         // Almacena el resultado de multiplicar el subtotal por 15% impuestos sobre la venta
            double propina;     // Almacena el resultado de multilpicar el subtotal por 10% tarifa de servicio
            double total;       // Almacena el resultado de sumar al subtotal el valor del IVA y la propina
            string hospital;    // Almacena el nombre del hospital a presupuestar
            int tipoPresupuesto;// Registra si el usuario empleara valores estandar o manuales.
            double presupuesto; // Registra el monto a ser empleado por el usuario en el hospital
            double gineco;      // Almacena el porcentaje de presupuesto asigando a este departamento en el hospital
            double trauma;      // Almacena el porcentaje de presupuesto asigando a este departamento en el hospital
            double pedia;       // Almacena el porcentaje de presupuesto asigando a este departamento en el hospital
            double precio;      // Almacena el precio del producto
            double utilidad;    // Almacena el valor del producto mas la utilidad, es decir el precio de venta
            int fecha;          // Almacena el anno de nacimiento del usuario

            Console.WriteLine("Menu de programas Disponibles: ");
            Console.WriteLine("1 - Factura Desglozada");
            Console.WriteLine("2 - Presupuesto Anual Hospitalario");
            Console.WriteLine("3 - Calculo de utilidad");
            Console.WriteLine("4 - Calculadora de Edad");
            Console.Write("Por favor seleccione el numero del programa que desea ejecutar: ");

            //Definiendo Programa a emplear
            opcion   = Convert.ToInt32(Console.ReadLine());
            switch (opcion) 
            { 
            case 1:
            // Gestor desglozado de facturas.
            // Toma un nombre y un valor decimal para darte los detalles de
            // IVA, propina y luego un subtotal

                    Console.WriteLine("Bienvenido a su gestor de facturas Desglozadas!");
                    Console.Write("Por favor dime tu nombre: ");
                    nombre = Console.ReadLine();                        // Guardando el nombre del usuario
                    Console.Write($"Hola {nombre} Por favor ingresa el subtotal de tu factura: ");
                    subtotal = Convert.ToDouble(Console.ReadLine());    // Asignando el valor del usuario en la variable
                    iva = Math.Round((subtotal * .15),2);               // Calculando el 15% sobre el subtotal en impuestos
                    propina = Math.Round((subtotal * .1),2);            // Calculando el 10% sobre el sutotal en propina
                    total = Math.Round((subtotal + iva + propina),2);   // Agregando todos los valores para el total
                    
                    Console.WriteLine($"Sr(a) {nombre}, el monto de su factura de forma detallada es:");
                    Console.WriteLine($"Subtotal    = {subtotal}");
                    Console.WriteLine($"Impuestos   = {iva}");
                    Console.WriteLine($"Propina     = {propina}");
                    Console.WriteLine($"Total       = {total}");
                    Console.WriteLine("Muchas Gracias por su visita, que pase un buen dia, lo esperamos pronto!!\n");

                    break;     
            
            case 2:
                    Console.WriteLine("Bievenido a tu Presupuesto Hospitalario!");
                    Console.Write("Por Favor Dime Como te llamas: ");
                    nombre = Console.ReadLine();
                    Console.Write("Por Favor Dime Como se llama el hospital a evaluar: ");
                    hospital = Console.ReadLine();
                    Console.Write("Por Favor Indica el monto Presupuestal a utilizar en los calculos: ");
                    presupuesto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Excelente! Gracias por los datos");
                    Console.WriteLine("Si Deseas trabajar con los valores de defecto digita 1");
                    Console.WriteLine("Ginecologia 40%, Traumatologia 30% y Pediatria 30%");
                    Console.WriteLine("Digita 2 si quieres definirlos manualmente");
                    tipoPresupuesto = Convert.ToInt32(Console.ReadLine());

                    if (tipoPresupuesto==1)
                    {
                        gineco = Math.Round((presupuesto*0.4),2);
                        trauma= Math.Round((presupuesto * 0.3),2);
                        pedia= Math.Round((presupuesto * 0.3),2);

                        Console.WriteLine($"El Hospital {hospital} tiene un presupuesto asignado de {presupuesto}");
                        Console.WriteLine($"El departamento de Ginecologia cuenta con un 40% Equivalente a {gineco}");
                        Console.WriteLine($"El departamento de Traumatologia cuenta con un 30% Equivalente a {trauma}");
                        Console.WriteLine($"El departamento de Pediatria cuenta con un 30% Equivalente a {pedia}");
                        Console.WriteLine("Gracias por usas el sistema de presupuesto hospitalario, ");
                        Console.WriteLine("lo esperamos pronto!");

                    }
                    else
                    {
                        double g,p,t; // Definiendo variables para establecer el porcentaje definido por el usuario.
                        
                        Console.WriteLine("Por favor define como distribuiremos el presupuesto");
                        Console.WriteLine("Por favor emplea numero enteros sin simbolos para la asignacion, es decir");
                        Console.WriteLine("Si quiere asignar un 20%, solo escribe 20, si es un 45% escribe 45");
                        Console.Write("Por favor define el porcentaje de Ginecologia: ");
                        g = (Convert.ToDouble(Console.ReadLine()))/100;
                        Console.Write("Por favor define el porcentaje de Traumatologia: ");
                        t = (Convert.ToDouble(Console.ReadLine()))/100;
                        Console.Write("Por favor define el porcentaje de Pediatria: ");
                        p = (Convert.ToDouble(Console.ReadLine())) / 100;

                        while (g + p + t == 1)
                            {
                                gineco = Math.Round((presupuesto * g), 2);
                                trauma = Math.Round((presupuesto * t), 2);
                                pedia = Math.Round((presupuesto * p), 2);

                                //Console.WriteLine(gineco);
                                //Console.WriteLine(g);
                                //Console.WriteLine(p);
                                //Console.WriteLine(t);
                                Console.WriteLine($"El Hospital {hospital} tiene un presupuesto asignado de {presupuesto}");
                                Console.WriteLine($"El departamento de Ginecologia cuenta con un 40% Equivalente a {gineco}");
                                Console.WriteLine($"El departamento de Traumatologia cuenta con un 30% Equivalente a {trauma}");
                                Console.WriteLine($"El departamento de Pediatria cuenta con un 30% Equivalente a {pedia}");
                                Console.WriteLine("Gracias por usas el sistema de presupuesto hospitalario, ");
                                Console.WriteLine("lo esperamos pronto!");
                                Console.ReadKey();
                            break;
                        }   
                    }
                    break;

            case 3:
                    {
                        double p;
                        Console.WriteLine("Bievenido a tu Calculadora de Utilidad!");
                        Console.Write("Por Favor Dime Como te llamas: ");
                        nombre = Console.ReadLine();
                        Console.Write("Por Favor dime el costo del producto en cuestion: ");
                        precio = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Excelente, y dime, cuanto planeas sacar de utilidad?");
                        Console.WriteLine("Por favo indica un numero entero, si quieres un 40% digita solo 40");
                        Console.WriteLine("si quieres un 75% digita solo 75");
                        p = (Convert.ToDouble(Console.ReadLine()))/100;
                        utilidad = Math.Round((precio + (precio * p)),2);
                        Console.WriteLine($"Gracias! si quiere ganar un {p*100}% de utilidad");
                        Console.WriteLine($"Entonces deberemos vender el producto a {utilidad}");
                        Console.WriteLine("Gracias por utilizar el sistema de calcula de utilidad!");

                    }

                    break;

            case 4:

                    {
                        Console.WriteLine("Gracias por utilizar el sistema de calculo de edad!");
                        Console.Write("Por Favor Dime Como te llamas: ");
                        nombre = Console.ReadLine();
                        Console.Write($"Hola {nombre} por favor digita tu Anno de Nacimiento: ");
                        fecha = DateTime.Now.Year - Convert.ToInt32((Console.ReadLine()));
                        Console.WriteLine($"Gracias, actualmente tu tienes {fecha} Annos!");
                        Console.WriteLine("Gracias por Utilizar el sistema de calculo de edad!");
                    }
                    
                    break;

            }






                Console.ReadKey();  
        }
    }
}
