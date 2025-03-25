/*
Objetivos:
El dueño de una tienda compra un artículo a un precio determinado. Obtener el precio en que lo debe vender para obtener una ganancia del 30%
 */

Console.WriteLine("Bievenido a la calculadora de utilidad\n");
Console.Write("Por favor ingrese el costo del articulo:$ ");
float precio = Convert.ToSingle(Console.ReadLine());
float ganancia = Convert.ToSingle(precio*1.3);

Console.WriteLine($"Para tener un 30% de ganacia deberas vender tu producto en: ${ganancia}\n");
