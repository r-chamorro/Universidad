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
int player::getPlayerLastX()
{
    return playerLastX;
}
int player::getPlayerLastY()
{
    return playerLastY;
}

void player::resettoSafePosition()
{
    playerX=getPlayerLastX();
    playerY=getPlayerLastY();
}


void player::increasePlayerX() // Funcion para aumentar el valor de x
{
    playerX++;
}

void player::increasePlayerY() // Funcion para aumentar el valor de y
{
    playerY++;
}

void player::decreasePlayerX() // Funcion para disminuir el valor de x
{
    playerX--;
}

void player::decreasePlayerY()// Funcion para disminuir el valor de y
{
    playerY--;
}

void player::setPlayerX(int newPlayerX) // Establece manualmente el valor de X
{
    playerX=newPlayerX;
}
void player::setPlayerY(int newPlayerY)// Establece manualmente el valor de Y
{
    playerY=newPlayerY;
}

void player::setPlayerLastX(int newPlayerstLastX)// Establece manualmente el valor anterior de X
{
    playerLastX=newPlayerstLastX;
}


void player::setPlayerLastY(int newPlayerLastY)// Establece manualmente el valor anterior de y
{
    playerLastY=newPlayerLastY;
}



void player::callInput() // Recibe los movimienots del jugador desde el input
{   
    
        
 

    char userInput; //Guaradara la variable para el caso a emplear
    cin>>userInput; //Pide un valor al usuario
    switch (userInput)
    {
        case 'a':case 'A'://Movimiento hacia la izquierda, Limite es 0, condicional
            player::setPlayerLastX(player::getPlayerX()); // Guarda el valor de X antes del cambio en caso de ocupar volver.
            player::decreasePlayerX();//Si no esta en la poscion 0, disminuye el valor
        
        break;

        case 'w':case 'W':
            player::setPlayerLastY(player::getPlayerY());// Guarda el valor de Y antes del cambio en caso de ocupar volver.
            player::decreasePlayerY(); //Si no pasa aumenta Y
        
        break;  
    
        case 'd':case 'D':
            player::setPlayerLastX(player::getPlayerX());// Guarda el valor de X antes del cambio en caso de ocupar volver.
            player::increasePlayerX();
        break;

        case 's':case 'S':
            player::setPlayerLastY(player::getPlayerY());// Guarda el valor de Y antes del cambio en caso de ocupar volver.
            player::increasePlayerY();
           
        break;
    default: // en caso de valor invalido indicamos como se usa.
        cout<<"\nUse el teclado para desplazarse!"<<endl;
        cout<<"El juego emplea movimientos clasicos 'ASDW'"<<endl;
        cout<<"A-izquierda, S-Abajo, D-Derecha y W-Arriba!"<<endl;
        break;
    }
}

