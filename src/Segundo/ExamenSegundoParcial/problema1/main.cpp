#include <iostream> // Librearia entrada y salida de datos
using namespace std;
/*
Escriba un programa que permita al usuario buscar un número en un arreglo predefinido de enteros. Si el
número está en el arreglo, el programa deberá imprimir la posición del número en el arreglo, si no, este
deberá indicar que el número no se encontró
*/

int main (){

int arreglo[] = {10,20,30,40,50,60,70,80,90,100}; //Definiendo arreglo de enteros estatico para busqueda.
int eleccion; //Variable de enteros para que el usuario pueda ingresar el valor a buscar
bool encontrado =false;//Variable que disparara la respuesta negativa en caso de no existir el numero, asi evito bucle infinito y puedo salir de la ejecucion

cout<<"El programa tiene un arreglo de 10 numero enteros!"<<endl;
cout<<"Ingresa un numero del 10 al 100 y si tu numero esta en el arreglo te dare su posicion"<<endl; // Comunicamos al usuario lo que esperamos de el

cin>>eleccion;

for (int i = 0; i <10; i++)//Iteramos por el arreglo de 10
{
   
    if (eleccion==arreglo[i]) //Comparamos la eleccion del usuario con el numero en la posicion indicada
    {
        cout<<"Ese numero existe y se encuentra en la posicion: "<<i+1<<endl; // Si el numero hace match le devolvmemos la posicion al usuario
        encontrado=true;//Al encontrar el valor, se cambia el bool a TRUE y asi evitamos que se dispare el if que esta debajo 
        
    }

}
if (encontrado==false)//Si toda la iteracion anterior no encontro el valor buscado, el boOl seguira siendo FALSE y cumple la condicion
{
    cout<<"No existe ese numero en el arreglo!"<<endl; // Al cumplirse la condicion le indicamos al usuario que no se encontro
}










return 0; // Regresa valor 0 confirmando ejecucion correcta del programa
}
