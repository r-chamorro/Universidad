#include <iostream>
#include <string>
#include "dibujarTriangulos.h"

void dibujaTraingulo()
{
/*
Solicita un número entero n y dibuja un triángulo de altura n con asteriscos
*/
    int tamano =1;
    string triangulo =" ";
    cout<<"Selecciona un numero entero y dibujare un triangulo de ese tamano"<<endl;
    for (int i = 0; i <= tamano; i++)
    {
        triangulo+="*";
        cout<<triangulo<<endl;
    }
    



}