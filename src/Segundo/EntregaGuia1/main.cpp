#include <iostream>
#include <string> // se agrega esta lib para usar el tipo de dato string de lo contrario puede generar fallo.
#include <cmath> // Libreria para calculos matematicos

using namespace std;

main ()
{
    int opcion;
    cout<<"Bienvenido al programa!"<<endl;
    cout<<"Opcion 1: Calcudora de Temperaturas!"<<endl;
    cout<<"Opcion 2: Calculadora de IMC"<<endl;
    cout<<"Opcion 3: Numeros Pares e impares"<<endl;
    cout<<"Opcion 4: Tablas de Multiplicar"<<endl;
    cout<<"Opcion 5: Sistema de Autenticacion"<<endl;
    cout<<"Selecciona una opcion entre el 1 y el 5"<<endl;
    cin>>opcion;

    
    switch (opcion)
    {        
        case 1:

        {/*
        Convertidor de Temperatura: Utilizando pseudocódigo cree un algoritmo que convierta la
        temperatura de Celsius a Fahrenheit y luego de Fahrenheit a Celsius. Las fórmulas son las
        siguientes:
        i. 𝐹 = 𝐶 ∗ 9/5 + 32
        ii. 𝐶 = (𝐹 − 32) ∗ 5/9
        */
        float valor;
        float farenheit, celcius;
        char decision;
        cout<<"Ingresa F para convertir a Farenheit o C para convertir a Celcius: "<<endl;
        cin>>decision;
        cout<<"Ingresa el valor a convertir: ";
        cin>>valor;
        if (decision=='f'||decision=='F')
        {
            farenheit=(valor*(9/5))+32;       
            cout<<"El valor en Grados Farenheit "<<farenheit<<endl;
        }else if (decision=='C'||decision=='c')
        {
            celcius=(valor-32)*(5/9);
            cout<<"El valor en Grados Celcius "<<celcius<<endl;
        }else
        {
            cout<<"Opcion NO valida, finalizando programa"<<endl;
        }       }
        break;     
        case 2:
{
        /*
        Cálculo de Índice de Masa Corporal (IMC). Utilizando pseudocódigo cree un algoritmo para
        calcular el índice de Masa Corporal (IMC) de una persona. El IMC se calcula con la fórmula
        𝐼𝑀𝐶 = 𝑝𝑒𝑠𝑜 𝑒𝑛 𝑘𝑖𝑙𝑜𝑔𝑟𝑎𝑚𝑜𝑠/(𝑎𝑙𝑡𝑢𝑟𝑎 𝑒𝑛 𝑚𝑒𝑡𝑟𝑜𝑠)2 . El algoritmo debe solicitar al usuario su peso en kilogramos y su
        altura en metros y posteriormente mostrar el IMC calculado
        */  
        float peso, altura, imc;
        cout<<"Calculadora de Indice de Masa Corporal"<<endl;
        cout<<"Ocupare tu altura en Metros [mts] y tu peso en Kilogramos [Kg]"<<endl;
        cout<<"Peso [Kg]: ";
        cin>>peso;
        cout<<"Altura [mts]";
        cin>>altura;
        imc=peso/pow(altura,2);
        cout<<"Tu IMC es igual a: "<<imc<<endl;}
        break;

        case 3:
        {/*Verificar Números Pares e Impares: Cree un algoritmo en pseudocódigo que solicite al usuario
        un número entero y determine si es par o impar.*/
        int numero;

        cout<<"Ingresa un numero y te dire si es par o Impar: ";
        cin>>numero;
        if (numero%2==0)
        {
            cout<<"Tu Numero es par!";
        }else
        {
            cout<<"Tu Numero es impar!";
        }}
        break;

        case 4:
        {/*Generador de Tabla de Multiplicar: Cree un algoritmo en pseudocódigo que solicite al usuario
        un número entero y muestre la tabla de multiplicar de ese número del 1 al 10*/
        int numero; //Variable para guardar la tabla a calcular
        cout<<"Ingresa un numero entero y devolvere la tabla de multiplicar para ese numero del 1 al 12:  ";
        cin>>numero;
        for (int i = 1; i <=10; i++)
        {
            cout<<numero<<" x "<<i<<"  = "<<i*numero<<endl;
        }
        cout<<"Programa Finalizado!"<<endl;      
        }
        break;

        case 5:
        {
        /*
        Sistema básico de Autenticación: Escriba un algoritmo en pseudocódigo para un sistema
        básico de autenticación. El sistema debe permitir al usuario ingresar un nombre de usuario y
        contraseña. Luego, debe verificar si el nombre de usuario es “usuario123” y la contraseña es
        “contraseña”. Si las credenciales son correctas, muestra un mensaje de “Acceso concedido”.
        De lo contrario, muestra “Acceso denegado”
        */
        string usuario = "usuario123", contrasena="contrasena", newUsuario, newContrasena;
        cout<<"Hola Bienvenido a Una Empresa Standard"<<endl;
        cout<<"Ingresa tu usuario"<<endl;
        cin>>newUsuario;
        cout<<"Ingresa tu Contrasena"<<endl;
        cin>>newContrasena;

        if (usuario==newUsuario &&contrasena==newContrasena)
        {
            cout<<"Acceso Concedido";
        }else
        {
            cout<<"Acceso Denegado";
        }}
        break;
        default:
        cout<<"Opcion Invalida, por favor elige umn numero entre 1 y 5"<<endl;
        break;
        
    }
}