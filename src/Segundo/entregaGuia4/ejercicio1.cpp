/*
Guía de ejercicios #4 – Arreglos.
Operaciones con Arreglos Unidimensionales
a. Lectura/Escritura

Ejercicio 2:
Crear un programa que lea 5 números flotantes en un arreglo y los imprima en orden inverso al que fueron
introducidos.
b. Asignación
Ejercicio 3:
Crear un programa que inicialice un arreglo de 10 elementos con los números del 1 al 10 y muestre sus valores.
Ejercicio 4:
Crear un programa que inicialice todos los elementos de un arreglo con ceros y luego los imprima.
c. Actualización
i. Inserción
Ejercicio 5:
Crear un programa que permita insertar un número en una posición específica de un arreglo, desplazando los
elementos necesarios.
ii. Eliminación
Ejercicio 6:
Crear un programa que elimine el elemento de una posición específica de un arreglo, moviendo los elementos
siguientes una posición hacia atrás.
iii. Modificación
Ejercicio 7:
Crear un programa que permita buscar un número en un arreglo y modificarlo por un nuevo valor ingresado por el
usuario.
*/

#include <iostream>
using namespace std;

int main ()
{
    //Ejercicio 1:
    //Crear un programa que lea 10 números enteros en un arreglo y luego los imprima en el mismo orden.
    int arreglo[10];
    cout<<"Ingrese 10 numeros: "<<endl;
    for (int i = 0; i <10; i++)
    {
        cout<<"Numero "<<i+1<<": ";
        cin>>arreglo[i];
    }
    

    cout<<"En el mismo orden los numeros son: "<<endl;

    for (int j = 0; j < 10; j++)
    {
        cout<<"Numero "<<j<<" :"<<arreglo[j]<<endl;
    }
    



    return 0;
}