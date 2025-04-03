#include <iostream>
#include <string>
#include "dibujaTriangulos.h"
using namespace std;

void dibujaTriangulo()
{
/*
Solicita un número entero n y dibuja un triángulo de altura n con asteriscos
*/
    int tamano =1;    
    cout<<"Selecciona un numero entero y dibujare un triangulo de ese tamano"<<endl;
    cin>>tamano;
    for (int i = 1; i <= tamano; i++)
    {
        for (int j=tamano-i; j >0 ; j--)
        {
            cout<<" ";    
        }
        for (int k=1; k<=i ; k++)
        {
            cout<<"* ";    
        }
        
        cout<<endl;
        
    }
    



}