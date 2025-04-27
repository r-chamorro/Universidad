#include <iostream>
using namespace std;
/*
Problema 1: Control de Flujo y Entrada/Salida (15 puntos)
Cree un programa que pida al usuario ingresar la cantidad de números que desee, lea los números y luego
calcule y muestre el promedio de esos números.
Requisitos:
• Debe pedir al usuario la cantidad de números que ingresará.
• Basado en la cantidad de números, deberá pedirle al usuario ingresar número por número.
• Calcule y muestre el promedio de los números ingresados
*/
int main()
{
    //Definiendo Variables:
    int n; //Variable que definira el tamano del arreglo a utilizar
    float  acumulado; // Aqui guardamos todos los valores para efectuar el promedio al final
    float promedio; //Se guarda el resultado del calculo, como es una division es posible que hayan decimales por eso el tipo float.

    

    cout<<"Bienvenido!"<<endl;
    cout<<"Por favor indica el tamano del arreglo a evaluar: ";
    cin>>n; //Aqui el usuario define el tamano del arreglo

    int arreglo[n]={0}; // Declaracion variable a ser empleada como nuevo arreglo, se declara despiues de pedir n al usuario
    //arreglo = new int[n]; // Definiendo el tamano del arreglo a lo que el usuario ingrese --ulreck: revisar en 2da vuelta para evaluar razon de fallo--.
    cout<<"Gracias!"<<endl;
    cout<<"Por favor ingresa los valores de tu arreglo 1 por 1: ";
    for (int i = 0; i < n; i++)
    {
        cout<<"Ingrese el valor "<<i+1<<endl; //Como inicia en 0 se agrga uno para no confundir al usaurio
        cin>>arreglo[i]; //Llenando el arreglo paso a paso basado en el tamano que el usuario establecio
        acumulado+=arreglo[i];
    }
    promedio = acumulado/n; // Calculando el valor del promedio
    cout<<"El promedio de estos valores es: "<<promedio<<endl;    

    return 0;
}


