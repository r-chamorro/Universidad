using System;
/*
Elaborar un programa que calcule el valor total a pagar de la factura de un restaurante, 
el usuario deberá introducir el sub-total, el programa deberá calcular el IVA (15%) y la propina del mesero, 
esta será proporcional al 10% sobre el subtotal. Es decir que al sub-total tiene que sumar el IVA + la propina.
*/


/*
 La salida del programa debe ser de la siguiente manera:
******************************************************************
Sr(a) *NOMBRE DEL USUARIO*, el monto de su factura de forma detallada es:

Subtotal= 500
IVA 15% = 75
Propina  10% = 50
Total a pagar = 625
Muchas gracias por su visita, que pase buen día lo esperamos pronto.
 */

//Definiendo Variables
string nombreFactura;   //Contiene el nombre que el usuario designe
double subtotal;        //Contiene el valor del subtotal de la factura del usuario
double propina;         //Almacena el valor calculado de propina, 10% del subtotal
double iva;             //Almacena el valor calculado de IVA, 15% del subtotal
double total;           //Almacena el valor calulado del subtotal + IVA + Propina

Console.WriteLine("Bienvenido al Sistema de gestion de Facturas V 1.0\n");
Console.Write("Es un placer atenderle,\n" + "Por favor ingrese su nombre: ");
nombreFactura = Console.ReadLine();

Console.Write($"Hola {nombreFactura}\n"+"Por favor digite el subtotal de su factura en Dolares: ");
subtotal = Convert.ToDouble(Console.ReadLine());
propina = Math.Round((subtotal * 0.10),2);
iva = Math.Round((subtotal*.15),2);
total = Math.Round((subtotal+propina+iva),2);


Console.WriteLine("\nGracias!\n" +
    "\n"+
    $"Sr(a) {nombreFactura}, el monto total de su factura de forma detallada es:\n" +
    "\n"+
    $"Subtotal:             $ {subtotal}\n" +
    $"IVA 15% =             $ {iva}\n" +
    $"Propina 10% =         $ {propina}\n" +
    $"Total a Pagar es =    $ {total}\n"   
    );