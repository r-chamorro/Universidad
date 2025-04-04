#include <iostream>
#include "classPlayer.h"
using namespace std;

player::player()
{

}

void player::callInput()
{
    char usernInput =' ';
    
    bool gameOver = false;
    while (!gameOver){
        cin>>usernInput;
        switch (usernInput)
        {
            case 'd': case 'D':
        
            {
                cout<<"Jugador Hacia la Derecha!"<<endl;
            }

            break;
            case 'i': case 'I':
                cout<<"Jugador hacia la izquierda!"<<endl;
                
            break;
            case 'b': case 'B':
                cout<<"Jugador hacia Abajo"<<endl;
            break;
            case 's': case 'S':
                cout<<"JUgador hacia arriba!"<<endl;
                
            break;
            case 'p': case 'P':
            cout<<"Gracias por jugar"<<endl;
            cout<<"\nPROGRAMA FINALIZADO"<<endl;
            gameOver=true;
            break;
            default:
            cout<<"\nPor favor elige entre las 5 opciones disponibles: \n"<<"Subir (S,s) \nBajar (B,b) \nIzquierda (I,i) \nDerecha (D,d) \nPara salir presiona 'P' o 'p'"<<endl;
            break;
        }
    }

}

player::~player()
{
    
}



