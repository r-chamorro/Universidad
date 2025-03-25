// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

 //Delimitadores en C#
 
Console.WriteLine("Esto son delimitadores \n");
Console.WriteLine("() Los parentesis son empleados para delimitar los parametros de las funciones \n");
Console.WriteLine("[] Los corechete se usan para declarar arreglos y acceder a ellos tambien\n");
/*
 Por ejemplo, podemos 
*/

int x;
Console.WriteLine("Introduzca un valor Numerico \n");
x =  Convert.ToInt32(Console.ReadLine());

if (x > 1)
{
    Console.WriteLine($"El valor de la varialbe x es {x} y es mayor que 1\n");
}
else if (x < 1)
{
    Console.WriteLine($"El valor de la varialbe x es {x} y es menor que 1\n");
}
else
{
    Console.WriteLine($"El valor de la varialbe x es {x}\n");
}


Console.WriteLine("Operaciones Matematicas\n");

int operacion1 = 6 + 2 * 3;
int operacion2 = 6 + 6 - 4 / 2;
int operacion3 = 5 * (5 + 4 + 1);
int operacion4 = 2 + (10 + 10 - 3);
int operacion5 = ((2 - 3 ) * (5 - 7) * (12 - 8) ) / 2;
int operacion6 = (20 * 3 + 8 - 2 ) / 3;
int operacion7 = 20 + 5 * 6 + 4 + (5 - 3 ) * (50 + 3);

Console.WriteLine(operacion1);
Console.WriteLine(operacion2);
Console.WriteLine(operacion3);
Console.WriteLine(operacion4);
Console.WriteLine(operacion5);
Console.WriteLine(operacion6);
Console.WriteLine(operacion7);

