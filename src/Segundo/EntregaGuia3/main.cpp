#include <iostream>
#include <cmath> //Biblioteca de operaciones matematicas
using namespace std;

main ()
{
    int opcion;
    cout<<"Bienvenido a tu Programa Selecciona una opcion del listado!"<<endl;
    cout<<"Opcion 1: Area y perimetro de un circulo"<<endl;
    cout<<"Opcion 2: Calculadora de Descuentos"<<endl;
    cout<<"Opcion 3: Cual es el numero mayor?"<<endl;
    cin>>opcion;


    switch (opcion)
    {
        case 1:
        {/*Desarrolle un programa que pida al usuario el radio de un círculo y calcule su área y perímetro.
        a. Área: 𝐴 = 𝜋𝑟2
        b. Perímetro: 𝑃 = 2𝜋𝑟*/
        float radio, area, perimetro, pi = 3.141592;
        cout<<"Calculare el Perimetro y Ara de un circulo basado en su radio: "<<endl;
        cout<<"Ingrese el valor del radio: ";
        cin>>radio;
        area = pi*pow(radio,2);
        perimetro= 2*pi*radio;
        cout<<"EL perimetro de tu circulo es: "<<perimetro<<endl;
        cout<<"El Area de tu circulo es: "<<area<<endl;
        }
        break;

        case 2:
        /*
        Crea un programa que, basado en el total de una compra, aplique un descuento diferente: ningún
        descuento para montos menores de 100, 5% de descuento para montos de 100 a 500 y 10% de
        descuento para montos mayores a 500. El programa debe aplicar el descuento aplicado y el total con
        descuento
        */
        float precio,descuento,total_descontado;
        cout<<"ingresa el precio del producto: ";
        cin>>precio;
        if (precio<100)
        {
            cout<<"Este producto no aplica Descuento!";
        }else if(precio>=100&&precio<=500)
        {
            descuento=precio*0.05;
            total_descontado=precio-descuento;
            cout<<"Ese producto aplica un descuento del 5% equivalente a = "<<descuento<<endl;
            cout<<"El valor de tu producto despues de descuento es: "<<total_descontado<<endl;

        }else
        {
            descuento=precio*0.1;
            total_descontado=precio-descuento;
            cout<<"Ese producto aplica un descuento del 10% equivalente a = "<<descuento<<endl;
            cout<<"El valor de tu producto despues de descuento es: "<<total_descontado<<endl;


        }
        break;
    
        case 3:
            /*
            Cree un programa que lea tres números enteros y determine cuál de ellos es el mayor. Se debe
            considerar la posibilidad que dos o los tres números sean iguales
            */
           int numero1, numero2, numero3;
           cout<<"Ingresa 3 numeros enteros y te dire cual es el mayor de ellos:";
           cout<<"Numero 1: ";
           cin>>numero1;
           cout<<"Numero 2: ";
           cin>>numero2;
           cout<<"Numero 3: ";
           cin>>numero3;

        if (numero1==numero2&&numero2>numero3)
        {
            cout<<"Hay dos valores iguales y los mayores son : "<<numero1<<" y "<<numero2;
        }else if(numero2==numero3&&numero3>numero1)
        {
            cout<<"Hay dos valores iguales y los mayores son : "<<numero2<<" y "<<numero3;
        }else if (numero1>numero2&&numero1>numero3)
           {
            cout<<"El mayor de los 3 es: "<<numero1;
           }else if(numero2>numero1&&numero2>>numero3)
           {
            cout<<"El mayor de los 3 es: "<<numero2;
           }else            
           {
            cout<<"El mayor de los 3 es: "<<numero3;
           }
           

        break;
        default:
        break;
    }


    return 0;
}