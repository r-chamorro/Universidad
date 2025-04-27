#include <iostream>
#include <cmath> // Biblioteca matematica para invocar la potencia (power of)
using namespace std;

/*
Cree un solicite al usuario el radio de un círculo y procesa a calcular su área y perímetro.
Requisitos:
• La fórmula del área de un círculo es: 𝐴 = 𝜋𝑟2
• La fórmula del perímetro es: 𝑃 = 2𝜋r
*/

main ()
{

    //char opcion; //variable para usar el switch, se emplea char porque me parece mas elegante que simples numeros -- like a sir -- 
    float radio, resultado, resultado1, resultado2;// Variable a emplear para calculo seleccionado y resultado del calculo, se emplea float porque los valores pueden incluir decimales antes y despues de calcularos
    //Cree 3 variables porque hice 2 modos uno por switch y uno directo, lo lei bien hasta depspues de crear el swtich, queda comentado.
    float pi = 3.14159265358979323846; //Para efectos practicos decidi emplear el valor manual -- Ulreck: investigar inclusion de PI como libreria, ejemplo C# lib math.avg y mat.pi--
    cout<<"Bienvenido a tu calculador de formas!"<<endl;
    //cout<<"Opcion A: Calculadora de area de un circulo"<<endl;
    //cout<<"Opcion B: Calculadora de perimetro de un circulo"<<endl;
    //cin>>opcion;
    cout<<"regalame el radio y te devuelvo el perimetro y el area de tu circulo"<<endl;
    cin>>radio; // Pidiendo el valor del radio al usuario
    resultado1= pi*(pow(radio,2)); // Calculo de Area
    resultado2= 2*pi*radio;  // Calculo del Perimetro

    cout<<"El Area es igual a: "<<resultado1<<endl;
    cout<<"El Perimetro es igual a: "<<resultado2<<endl;


/*  // Modelo tipo switch, creado antes, dejado de referencia.
    switch (opcion) // Switch basado en un tipo char para elegir entre opciones
    {
        case 'a': case 'A': // Definimos mayuusculas y minisculas para disparar el case
        cout<<"Vamos a calcular el area de un circulo!"<<endl;
        cout<<"Me regalas el radio para calcularlo: ";
        cin>>radio;
        resultado= pi*(pow(radio,2)); // Formula basada en ejercicio, usando funcion pow de potencia con parametros de valor y potencia a emplear
        cout<<"El area de tu circulo con radio: "<<radio<<" Es de : "<<endl;
        cout<<resultado<<endl; // Imprimiendo resultado al usuario
        break;
        case 'b': case 'B':
        cout<<"Vamos a calcular el perimetro de un circulo!"<<endl;
        cout<<"Me regalas el radio para calcularlo: ";
        cin>>radio;
        resultado= 2*pi*radio; // Formula en base al ejercicio, al ser multiplicaciones no afecta no tener parentesis
        cout<<"El area de tu circulo con radio: "<<radio<<" Es de : "<<endl;
        cout<<resultado<<endl;
        
        break;
    
        default:
        cout<<"Esa opcion no esta definida, por favor selecciona A o B"<<endl; // Al no estar definido termina el programa
        break;
    }
*/

    return 0;
}