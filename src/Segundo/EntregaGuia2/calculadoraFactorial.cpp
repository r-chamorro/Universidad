#include <iostream>
#include "calculadoraFactorial.h"

using namespace std;

/*Solicita un número entero positivo y calcula su factorial 
usando un ciclo for*/

void cal_factorial()
{
int num=1,factorial=1;
cout<<"Ingrese un numero para conocer su factorial: "<<endl;
cin>>num;

for (int i = 1; i<=num; i++)
{
    factorial*=i;
}

cout<<"\nEl factorial de "<<num<<" Es : "<<endl;
cout<<factorial<<endl;
cout<<"Fin de Programa"<<endl;

}
