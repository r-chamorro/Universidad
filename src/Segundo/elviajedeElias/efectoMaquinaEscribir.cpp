#include <iostream>
#include <chrono>
#include <thread>

using namespace std;
using namespace chrono;
using namespace this_thread;


//Aqui se incluiran los efectos de texto que vaya creando.

void maquinaEscribir (string texto, int delayedby) //Funcion Para efecto maquina de escribir, recibe una variable de tipo string y un entero para el tiempo de espera
{
    for (char c: texto) //itera letra a letra por el string recibido
{
cout<<c<<flush; // La opcion Flush hace que se muestre en pantalla de inmediato en vez de esperar por el comando endl, evita que aparezca todo el texto de un solo golpe en pantalla.
sleep_for(milliseconds(delayedby)); // Aqui empleamos thread y chrono, thread para detener el terminal por ese tiempo y chronos para convertir un  numero enm milisegundos
}
cout<<endl;//Para dejar un espacio despues de la ultima linea de texto.
}