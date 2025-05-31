#include <iostream> // Librearia entrada y salida de datos
using namespace std;
/*
Escribe un programa en C++ que tome un arreglo de enteros como entrada y elimine todos los
duplicados. El programa deberá imprimir el nuevo arreglo sin duplicados.
a. Entrada: {1, 2, 2, 3, 4, 4, 4, 5, 5}
b. Salida esperada: {1, 2, 3, 4, 5}
*/

int main (){

int arreglo[10] = {1,1, 2, 2, 3, 4, 4, 4, 5, 5}, arreglo2[10]; //Usaremos un arreglo estatico y luego ingresaremos el resultado en un nuevo arreglo
int numeroactual; // Variable puente donde se almacenara el valor que se esta evaluando actualmente
int ubicacionNuevoArreglo =0; //Al ingresar en un nuevo arreglo debemos llegar hasta dnde haya valores si no se ingresa basura, con esta variable lo evito


for (int i = 0; i < 10; i++) //Primer ciclo de iteacion, lee el arreglo y evalua cada caso
{
    bool duplicado=false; //Iniciamos la variable booleana en Falso para deerminar si lo ingresaremo al nuevo arreglo o no
    numeroactual=arreglo[i];//Se asigna el primer valor del arreglo original a la varaible temporal

    for (int j = 0; j < 10; j++) // Segunda iteracion, esta comprueba si el numero actual esta en el nuevo arreglo 
    {

        if (arreglo2[j]==numeroactual) // Si el numero actual Ya esta en el arreglo cambia el booleano y lo ignora
        {
            duplicado=true; // Informa que se encontro el valor
            break; // Rompe el cilo de iteracion para qeu no continue pues ya encontro un duplicado
        }
        
        
    }

    if (!duplicado) //Si recorrimos todo el arreglo y no se cambio el booleano, el numero no existe y se puede ingresar
    {
        arreglo2[ubicacionNuevoArreglo]=numeroactual; // Guardamos el valor de la varaible temporal en el nuevo arreglo iniciando en la posiciohn 0
        ubicacionNuevoArreglo++; // Como cree un arreglo estatico, para evitar basura esta variable va incrementando conforme se ingresan los valores y asi no muestra los 10 registros.
    }
    
    
}

for (int k = 0; k < ubicacionNuevoArreglo; k++) // Iteramos hasta la maxima ubicacion que se creo en la variable ubicacion de esta forma evito el residuo de memoria
{
    cout<<"Arreglo Posicion"<<k<<" : "; //Imprimo linea a linea!
    cout<<arreglo2[k]<<endl;
}



return 0; // Regresa valor 0 confirmando ejecucion correcta del programa
}
