#include <iostream>
#include <string>
#include "./headers/class_typewritereffect.h"
using namespace std;

//El viaje de Elias --
//Version Alpha 0.1.0



int main ()
{
    int tiempo;
    string texto;
    cout<<"Ingrese el Texto que desee escribir:"<< endl;
    getline(cin,texto);
    cout<<"Ingrese el tiempo de retraso en [milisegundos]:"<< endl;
    cin>>tiempo;
    cout<<endl;
    
    typewritereffect typo;
    typo.maquinaEscribir(texto,tiempo);
    return 0;
}