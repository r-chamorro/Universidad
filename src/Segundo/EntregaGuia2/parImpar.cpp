#include<iostream>
#include"parImpar.h" // Se vincula con la cabecera para crear la referencia.
using namespace std;

  /* 1. Número Par o Impar
    • Pide un número entero al usuario e imprime si es par o impar.*/

void parImpar()
{
    int num;
    cout<<"Por Favor Ingresa un numero: "<<endl;
    cin>>num;
    if (num%2==0)
    {
        cout<<"El Numero es Par!!"<<endl;
    }else
    {
        cout<<"El Numero es ImPar!!"<<endl;
    }
}
