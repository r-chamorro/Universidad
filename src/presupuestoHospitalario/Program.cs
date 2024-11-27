/*
Objetivos:
Elaborar un programa que me permita conocer el presupuesto anual de las siguientes tres áreas: Ginecología, Pediatría, Traumatología en el hospital Militar escuela Dr. Alejandro Dávila Bolaños.
El presupuesto anual del hospital se reparte conforme a la sig. Tabla:
Área Porcentaje del presupuesto.
Ginecología 40%
Traumatología 30%
Pediatría 30%
Obtener la cantidad de dinero que recibirá cada área, para cualquier monto presupuestal

 */

//Declarando Variables

float presupuesto; //Almacena el valor que el usuario indique

Console.WriteLine("Bienvenido al sistema de gestion presupuestaria\n");
Console.WriteLine("Por favor ingrese el presupuesto destinado al hospital este mes!");
presupuesto = Convert.ToSingle(Console.ReadLine());

float ginecologia = Convert.ToSingle((presupuesto * .4));
float traumatologia = Convert.ToSingle((presupuesto * .3));
float pediatria = Convert.ToSingle((presupuesto * .3));


Console.WriteLine("Gracias por la informacion, de acuerdo a sus datos, el hopistal operara bajo la siguiente distribucion: \n");
Console.WriteLine($"El presupuesto total para este mes es de $ {presupuesto}\n"+
                  "\n" +
                  $"El area de Ginecologia tiene un presupuesto asignado de:   $ {ginecologia}\n"+
                  $"El area de Traumatologia tiene un presupuesto asignado de: $ {traumatologia}\n" +
                  $"El area de Pediatria tiene un presupuesto asignado de:     $ {pediatria}\n"+
                  "\n"+
                  "Gracias por confiar en su herramiento de presupuestos!"
    );

