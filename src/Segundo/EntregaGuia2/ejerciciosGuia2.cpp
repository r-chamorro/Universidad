#include <iostream>
#include "parImpar.h"
#include "calculadoraFactorial.h"
#include "vocalesCadena.h"
#include "adivinaNumero.h"
#include "dibujaTriangulos.h"

using namespace std;

void menuPrincipal()
{
    cout<<"\nSeleccione una opcion:"<<endl;
    cout<<"1 - Determinar si un numero es par o Impar"<<endl;
    cout<<"2 - Calculadora Factorial"<<endl;
    cout<<"3 - Contador de Vocales en Cadena de Texto"<<endl;
    cout<<"4 - Adivina un numero"<<endl;
    cout<<"5 - Dibuja un Triangulo"<<endl;
    cout<<"0 - Salir del programa"<<endl;
}

int main ()
{
    int option=0; //Declarando variable de seleccion:
    do
    { 
        menuPrincipal();
        cin>>option;
        switch (option)
        {
        case 1:
            parImpar();
        break;

        case 2:
            cal_factorial();
        break;
        case 3:
            voCadena();
        break;
        case 4:
            advinaNumero();
        break;
        case 5:
            dibujaTriangulo();
        break;
        case 0:
        cout<<"PROGRAMA FINALIZADO"<<endl;
        break;
        
            default:
            cout<<"OPCION INVALIDA"<<endl;
            break;
        }
        
    }while (option!=0);
return 0;
}