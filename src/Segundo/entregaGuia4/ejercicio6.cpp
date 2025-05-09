/*

iii. Modificación
Ejercicio 7:
Crear un programa que permita buscar un número en un arreglo y modificarlo por un nuevo valor ingresado por el
usuario.
*/

#include <iostream>
using namespace std;

int main ()
{
    // Ejercicio 6:
    // Crear un programa que elimine el elemento de una posición específica de un arreglo, moviendo los elementos
    // siguientes una posición hacia atrás.
    
    int arreglo[10]={1,2,3,4,5,6,7,8,9,10};
    int decision;
    for (int j = 0; j<10; j++)
    {
        cout<<"Numero "<<j+1<<" :"<<arreglo[j]<<endl;
    }  

    cout<<"Elige una posicion y movere el resto de numeros un espacio atras?"<<endl;
    cout<<"Es un arreglo de 10 puestos, elige una posicion del 1 al 10: "<<endl;
    cin>>decision;
    decision--;//Las posiciones empiezan en 0 necesario para aplicar elvalor del usuario
    // cout<<"Esta bien, ahora que numero pondras en su lugar : ";
    // cin>>arreglo[decision];
    cout<<"Listo, lo he actualizado!"<<endl;

    for (int j = decision; j<9; j++)
        {
            arreglo[j]=arreglo[j+1];
        }
  

    for (int j = 0; j<9; j++)
    {
        cout<<"Numero "<<j+1<<" :"<<arreglo[j]<<endl;
    }  

    return 0;
}