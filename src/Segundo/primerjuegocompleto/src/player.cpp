#include <iostream>
#include <utility>
#include "../headers/player.h"

using namespace std;

player::player(): playerX(1),playerY(1){}

int player::getPlayerX() //Getter para el valor X (Columnas)
{
    return playerX;
}

int player::getPlayerY()//Getter para el valor Y (Filas)
{
    return playerY;
}

void player::increasePlayerX()
{
    playerX++;
}

void player::increasePlayerY()
{
    playerY++;
}

void player::decreasePlayerX()
{
    playerX--;
}

void player::decreasePlayerY()
{
    playerY--;
}



void player::callInput()
{   
    
        
 

    char userInput;
    cin>>userInput;
    switch (userInput)
    {
        case 'a':case 'A':
        
        if(player::getPlayerX()==0)
        {
            cout<<"Fuera del Limite de Mapa, por favor regresa"<<endl;
        }else
        {
            player::decreasePlayerX();
        }
        break;

        case 's':case 'S':
        if(player::getPlayerY()==0)
        {
            cout<<"Fuera del Limite de Mapa, por favor regresa"<<endl;
        }else
        {
            player::increasePlayerY();
        }
        break;  
    
        case 'd':case 'D':
            player::increasePlayerX();
        break;

        case 'w':case 'W':
            player::decreasePlayerY();
        break;
    default:
        cout<<"\nUse el teclado para desplazarse!"<<endl;
        cout<<"El juego emplea movimientos clasicos 'ASDW'"<<endl;
        cout<<"A-izquierda, S-Abajo, D-Derecha y W-Arriba!"<<endl;
        break;
    }
}

