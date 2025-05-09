/*
Guía de ejercicios #4 – Arreglos.
i. Inserción

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
    // Ejercicio 5:
    // Crear un programa que permita insertar un número en una posición específica de un arreglo, desplazando los elementos necesarios.    
    
    int arreglo[10]={1,2,3,4,5,6,7,8,9,10};
    int decision;
    for (int j = 0; j<10; j++)
    {
        cout<<"Numero "<<j+1<<" :"<<arreglo[j]<<endl;
    }  

    cout<<"Dime que numero te gustaria Reemplazar?"<<endl;
    cout<<"Es un arreglo de 10 puestos, elige una posicion del 1 al 10"<<endl;
    cin>>decision;
    decision--;
    cout<<"Esta bien, ahora que numero pondras en su lugar : ";
    cin>>arreglo[decision];
    cout<<"Listo, lo he actualizado!"<<endl;

    for (int j = 0; j<10; j++)
    {
       if (j==decision)
       {
        cout<<"Aqui esta lo que tu tocaste: "<<arreglo[j]<<endl;
       }else
       {       
        cout<<"Numero "<<j+1<<" :"<<arreglo[j]<<endl;
       }
    }  

    return 0;
}