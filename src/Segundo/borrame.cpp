#include <iostream>

using namespace std;


int main ()
{
/*
Solicita un número entero n y dibuja un triángulo de altura n con asteriscos
*/
    int tamano =1;
    
    cout<<"Selecciona un numero entero y dibujare un triangulo de ese tamano"<<endl;
    cin>>tamano;
    for (int i = 1; i <= tamano; i++)
    {
        for (int j = i; j <=tamano; j++)
        {
   
            cout<<"*";
        }
        cout<<endl;
    }
    return 0;
}



