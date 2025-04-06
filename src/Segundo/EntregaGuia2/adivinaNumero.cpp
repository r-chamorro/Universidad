#include <iostream>
#include <random>
#include <ctime>
#include "adivinaNumero.h"

using namespace std;

void advinaNumero()
{
/*
Genera un número aleatorio entre 1 y 100. El usuario debe adivinarlo, y el programa debe 
indicar si el número ingresado es mayor o menor hasta que acierte
*/
srand(time(0));
int rndNum = rand()%101, usuario=0, intentos=5;
cout<<"Intente adivinar un numero entre 1 y 100"<<endl;
cout<<"Tienes 5 Intentos"<<endl;

//cout<<rndNum<<endl; // Descomentar para Debug--Muestra el valor generado. -_-

do{
    cin>>usuario;
if (usuario>rndNum)
{
    cout<<"\nEl numero del usuario es mayor que el elegido por el Programa"<<endl;
    intentos--;
}else if(usuario<rndNum)
{
    cout<<"El numero del usuario es menor que el elegido por el Programa"<<endl;
    intentos--;
}else
{
    cout<<"Has adivinado el numero Correcto!"<<endl;
    break;
}
}while(intentos>0);

if (intentos==0)
{
    cout<<"Mejor suerte la proxima vez!"<<endl;
}




}