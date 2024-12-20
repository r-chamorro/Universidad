using System;
using System.Globalization;


namespace EstructuraSelectiva_Practicas
{
    internal class Program
    {


        static void Main(string[] args)
        {
            /*
             EP1. Realizar una aplicación que permita simular lo siguiente: Solicitar Usuario y Contraseña si ambos son 
            correctos mostrar un menú que le permita ir a los ejercicios propuestos en caso de ser incorrecto aparezca la 
            ventana en fondo color ROJO con texto Blanco (“Usuario o Contraseña Incorrecto”) 
             */
            string usuario, contrasena, user, pass;
            Console.Title = "Menu Principal";
            usuario = "admin";
            contrasena = "1234";
            Console.Write("Bienvenido! Por Favor ingrese su usuario: ");
            user = Console.ReadLine();
            Console.Write("Gracias, por favor ingresa tu contreaña: ");
            pass= Console.ReadLine();

            try
            {

                if (usuario == user && contrasena == pass)
                {
                    Console.WriteLine("Bienvenido Al menu de opciones!");
                    Console.WriteLine("1 - Calculadora de Funciones");
                    Console.WriteLine("2 - Calculos con Circulos");
                    Console.WriteLine("3 - Calculadora de Hipotenusa");
                    Console.WriteLine("4 - Tipo  de Triangulo");
                    Console.WriteLine("5 - Notas Clasificacion");
                    Console.WriteLine("6 - Tombola UCN");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        /*
                         EP2. Escriba un programa que permita leer un valor entero, calcule lo siguiente: 
                        cubo, cuadrado, raíz cuadrada, tangente, seno, coseno. (Utilice 2 valores decimales para la salida) 

                         */

                        case 1:
                            Console.Title = "Funciones";
                            //Variables
                            double numero, grados;
                            Console.WriteLine("Por favor ingrese un numero Cualquiera");
                            numero = Convert.ToSingle(Console.ReadLine());
                            grados = numero * (Math.PI / 180);
                            //Ejecucion y Salida
                            Console.WriteLine("Gracias! Hare operaciones con ese numero por ti");
                            Console.WriteLine($"El cubo de {numero} es: {Math.Round(Math.Pow(numero, 3), 2)}");
                            Console.WriteLine($"El Cuadrado de {numero} es: {Math.Round(Math.Pow(numero, 2), 2)}");
                            Console.WriteLine($"La raiz Cuadrada de {numero} es: {Math.Round(Math.Sqrt(numero), 2)}");
                            Console.WriteLine($"La tangente de {numero} es: {Math.Round(Math.Tan(grados), 2)}");
                            Console.WriteLine($"El Seno de {numero} es: {Math.Round(Math.Sin(grados), 2)}");
                            Console.WriteLine($"El coseno de {numero} es: {Math.Round(Math.Cos(grados), 2)}");
                            break;

                        case 2:
                            /*
                             EP3. Desarrolle un programa que permita leer un valor para el radio (R), calcule el área (A) de un círculo (A = 2пR²). 
                            (Utilice 2 valores decimales para la salida) 
                             */
                            //Variables
                            double radio,A;
                            //Ejecucion
                            Console.Title = "Circulos";
                            Console.WriteLine("Por favor ingresa el radio de tu circulo: ");
                            radio = Convert.ToDouble(Console.ReadLine());
                            A = Math.Round((2 * (Math.PI * Math.Pow(radio, 2))),2);
                            
                            //Salida
                            Console.WriteLine($"El area de tu circulo es de: {A}");

                            break;


                        case 3:
                            /*
                             EP4. Escriba un programa que calcule la hipotenusa de un triángulo rectángulo conocidas las longitudes de sus dos catetos.
                            (La salida de la hipotenusa debe ser con 2 decimales). 
                             */
                            Console.Title = "Hipotenusa";
                            //Variables
                            double a,b, hipotenusa;
                            //Ejecucion y Salida
                            Console.WriteLine("Ingresa el Valor del Cateto a: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingresa el Valor del Cateto b: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Gracias!");
                            Console.WriteLine($"El cateto a = {a}");
                            Console.WriteLine($"El cateto b = {b}");
                            Console.WriteLine("La hipotenusa es igual a h");
                            Console.WriteLine("La Hipotenusa se calcula por medio de esta formula: h = √(a²+b²) ");
                            Console.WriteLine($"Entonces: h = √({a}²+{b}²)");
                            Console.WriteLine($"h = √({Math.Pow(a,2)}+{Math.Pow(b,2)}) ");
                            Console.WriteLine($"h = √({Math.Pow(a,2)+ Math.Pow(b, 2)})");
                            Console.WriteLine($"h = {Math.Round( Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)),2)}");
                            Console.ReadKey();
                            break;

                        case 4:
                            /*
                             EP5. Escriba un programa que, a partir de tres variables reales que representan las longitudes de los lados de un triángulo, 
                            dé respuestas a las siguientes preguntas usan- do valores lógicos: ¿Es un triángulo? (Afirmativo cuando la suma de dos de ellas 
                            es mayor que la tercera) ¿Es escaleno? (Afirmativo cuando es triangulo y los tres lados son distintos entre sí) ¿Es equilátero? 
                            (Afirmativo cuando es triangulo y los tres lados son iguales) ¿Es isósceles? (Afirmativo cuando es triangulo y dos lados son iguales)
                             */

                            Console.Title = "Tipo de Triangulo";
                            //Variables
                            int e, f, g;
                            Console.Title = "Triangulos";
                            Console.WriteLine("Por favor ingresa la longitud de los lados de un triangulo uno por uno");
                            Console.WriteLine("Ingresa el primer Lado");
                            e = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingresa el segundo Lado");
                            f = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingresa el tercer Lado");
                            g = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Gracias!");
                            
                            //Condicional para evaluar triangulos
                            // La suma de 2 de sus lados debe siempre ser mayor que el lado restante o no es un triangulo
                            
                            if ((e+f)>g && (f+g)> e &&(e + g) > f)
                            {
                                Console.WriteLine("Los lados Cumplen con las reglas para ser un triangulo!");

                                // Definido que es un triangulo, validamos que tipo de triangulo tenemos
                                if (e == f && f == g)
                                {
                                    Console.WriteLine("Esto es un Triangulo Equilatero!");
                                    Console.WriteLine("Todos sus lados son iguales");
                                }
                                else if (e == f || f == g || e == g)
                                {
                                    Console.WriteLine("Esto es un Triangulo Isosceles!");
                                    Console.WriteLine("Al menos dos de sus lados son iguales");
                                }
                                else 
                                {
                                    Console.WriteLine("Esto es un Triangulo Escaleno");
                                    Console.WriteLine("Todos los lados son Diferentes");
                                }


                            }
                            else
                            {
                                Console.WriteLine("Esto No es un Triangulo!");
                            }




                            break;

                        case 5:
                            /*
                             EP6. Escriba un programa que permita calcular la calificación de un alumno a partir de la nota numérica, de la siguiente manera: 
                            AI (si nota<60); AE (si nota >=61 y nota<=75); AS (si nota >=76 y <=89); AA (si nota >=91). Utilice el operador condicional.  
                            En caso que la nota sea <0 ó >100 mostrar un mensaje que diga nota invalida, Ingrese una nota valida. 
                            (Personalice su ejercicio para que cambie de color según el resultado)
                             */
                            Console.Title="Notas";
                            //Variables 
                            int nota;

                            Console.WriteLine("Por favor ingresa tus notas");
                            nota = Convert.ToInt32(Console.ReadLine());

                            //Condicionales anidadas para decision de mensaje a presentar
                            
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
                                Console.WriteLine("Esta nota supera el valor maximo de 100!");
                                Console.WriteLine("Por favor  ingresa un entero entre 0 - 100");

                            }
                            else 
                            
                            {
                                Console.WriteLine("No Trabajamos con Negativos");
                                Console.WriteLine("Por favor  ingresa un entero entre 0 - 100");
                            }



                            break;


                        case 6:
                            /*
                             EP7. Realice un programa de tipo tómbola que permita ingresar un numero por teclado y luego generar un numero aleatorio 
                            entre el 1 al 100. Si el numero ingresado es igual al numero aleatorio entonces mostrar un mensaje de 
                            “Ganador” en caso contrario “Perdiste”. 
                             */

                            //Variables
                            int jugador,tombola;
                            //Se declara una nueva instancia de la clase Random
                            //Random no puede ser llamada como Math (esto es un conjunto de funciones matematicas)
                            //Random Genera una semilla o valor default que no puede ser el mismo para todos los usuarios pues no seria aleatorio sino predecible y repetitivo
                            //https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-9.0

                            Random random = new Random();
                            tombola = Convert.ToInt32(random.Next(1,100));
                            Console.Title = "Tombola!";
                            Console.WriteLine("Bienvenido a La tombola UCN");
                            Console.WriteLine("Trata de adivinar en que numero estoy pensando");
                            Console.WriteLine("Ingresa un numero entre 1 y 100");
                            //Descomentar las lineas 248,250 y 251 ** Para Debugging
                            //Console.WriteLine($"DEBUGGING --  El valor de tombola es {tombola}");
                            jugador = Convert.ToInt32(Console.ReadLine());
                            //Console.WriteLine($"Tombola: {tombola} == Jugador: {jugador} ");
                            //Console.ReadKey();

                            if (jugador == tombola)
                            {
                                Console.WriteLine("Excelente! Has Ganado!");
                            }
                            else {

                                Console.WriteLine("PERDISTE!!");
                                Console.WriteLine("La casa siempre Gana!");
                            }

                            break;

                        default:

                            Console.WriteLine("Opcion Invalida, Por favor selecciona una de las opciones disponibles");
                            break;


                    }
                }
                else
                {

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("Usuario o Contraseña Incorrecto");
                }

            }
            catch (Exception)
            {

                Console.WriteLine("\nSeguro hiciste algo que no te dije que hicieras!");
                Console.WriteLine("Sigue las instrucciones por favor!");

            }
            finally 
            {
                Console.WriteLine("\nHas salido del programa!");
                
            }


            Console.ReadKey();


        }
    }
}
