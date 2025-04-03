#include <iostream>
#include "vocalesCadena.h"

/*
Pide una frase al usuario y cuenta cuántas vocales (a, e, i, o, u) 
contiene
*/

using namespace std;

void voCadena()
{
    string cadena=" ";
    int a=0,e=0,i=0,o=0,u=0,otrosCaracteres=0;
    cout<<"Ingrese un texto"<<endl; 
    cin.ignore();
    getline(cin, cadena);

    for(char c:cadena)
    {
        switch (c)
        {
        case 'a': case 'A':
        a++;
            break;
        case 'e': case 'E':
        e++;
            break;
        case 'i': case 'I':
        i++;
            break;
        case 'o': case 'O':
        o++;
            break;
        case 'u': case 'U':
        u++;
            break;
        default:
        otrosCaracteres++;
            break;
        }
    }
    cout<<"En esta Cadena encontramos lo siguiente: "<<endl;
    cout<<"Letra A: "<<a<<endl;
    cout<<"Letra E: "<<e<<endl;
    cout<<"Letra I: "<<i<<endl;
    cout<<"Letra O: "<<o<<endl;
    cout<<"Letra U: "<<u<<endl;
    cout<<"Otros Caracteres: "<<otrosCaracteres<<endl;

}
