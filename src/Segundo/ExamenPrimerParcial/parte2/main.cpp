#include <iostream>
using namespace std;

/*Problema 2: Calculadora de factorial (20 puntos)
Cree un programa que solicite un número entero positivo al usuario y muestre su factorial.
Requisitos:
• Debe pedir al usua+rio un número entero positivo.
• Debe mostrar el resultado del cálculo de la factorial al usuario.*/

int main()
{
    int numero; //Variable para almacenar el factorial a calcular
    int acumulado=1; // Aqui guaradare el valor del factorial acumlativo, lo inicio en 1 porque C++ es especial y mete basura ahi
    cout<<"Bienvenido a la Calculadora Factorial"<<endl;
    cout<<"Ingresa un numero entero y te retornare su factorial"<<endl;
    cin>>numero;

    if (numero==0)//Por si acaso el usuario se siente chistoso
    {
        cout<<"Interesante, por definicion el factorial de 0 es 1 :)"<<endl;
    }else if (numero<0) // Por si se siente mas chistoso!, evitamos el ingreso de negativos y finaliza el programa
    {
        cout<<"Interesante, pero no es posible calcular un factorial negativo, Los numeros natural N no los contemplan. Gracias!"<<endl;
    }    
    else
    {
        for (int i = numero; i >0; i--)
        {
            acumulado*=i;
        }
        
    }
    cout<<"El factorial de "<<numero<<" Es :"<<acumulado<<endl;    
    
}
