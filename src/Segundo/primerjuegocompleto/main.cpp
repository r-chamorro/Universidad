#include <iostream>
#include "./headers/gameMap.h"
#include "./headers/mapCell.h"
#include "./headers/player.h"
using namespace std;

//bienvenido al mundo de Elias



main()
{
    bool gameOver = false;

    cout<<"Bienvenido al diario de Elias: "<<endl;  
    gameMap mapaJuego;
    player Hero;
    
    cout<<"Juego Iniciado!"<<endl;

    while (!gameOver)
    {
      
      Hero.callInput(); // Define movimiento del jugador
      mapaJuego.setPlayerCell(Hero.getPlayerX(),Hero.getPlayerY());
      mapaJuego.drawMap(); // Indica dibujar el mapa
      cout<<"Las coordenadas del Heroe son:"<<" X = "<<Hero.getPlayerX()<<" Y = "<<Hero.getPlayerY()<<endl;
     
        // gameOver=true;
    }
    return 0;
}