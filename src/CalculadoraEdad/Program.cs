/*
Objetivo: Realizar un programa que calcule la edad de una persona. Recuerde solicitarle el año de nacimiento.
*/

int edad;
int annoNacimiento;
Console.WriteLine("Por favor ingresa tu anno de Nacimiento: ");
annoNacimiento = Convert.ToInt16(Console.ReadLine());
edad = DateTime.Now.Year - annoNacimiento;
Console.WriteLine($"Usted tiene {edad} Annos de edad!");
