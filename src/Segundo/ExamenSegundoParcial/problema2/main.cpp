#include <iostream> // Librearia entrada y salida de datos
using namespace std;
/*
Implementa una función que reciba un arreglo de enteros y lo modifique de tal manera que los elementos
estén en orden inverso. No está permitido usar un arreglo adicional.
*/

int main (){
int arreglo[5]; // Creamos un arreglo de 5 enteros para recibir del usuario

cout<<"ingresa 5 valores enteros en un arreglo y te devolvere el orden inverso de como los ingreses"<<endl;

for (int i = 0; i < 5; i++) // Primera iTeracion para llenar el arreglo 
{
    cout<<"Ingresa la posicion "<<i+1<<" : ";
    cin>>arreglo[i];
}

cout<<"El arreglo original es: "<<endl; //Le mostramos al usuario el arreglo en el orden que se ingreso
for (int i = 0; i < 5; i++)
{
    cout<<"Numero "<<i+1<<" : "<<arreglo[i]<<endl;
}

cout<<"El arreglo ivnertido es: "<<endl; //Se hace una interacion decreciente para que los valores se muestren en el orden inverso
for (int i = 4; i >= 0; i--)
{
    cout<<"Numero "<<i+1<<" : "<<arreglo[i]<<endl;
}



return 0; // Regresa valor 0 confirmando ejecucion correcta del programa
}
