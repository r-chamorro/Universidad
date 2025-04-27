#include <iostream>
#include "./headers/gameMap.h"
#include "./headers/mapCell.h"
#include "./headers/player.h"
using namespace std;

//bienvenido al mundo de Elias



main()
{
    

    cout<<"Bienvenido al diario de Elias: "<<endl;  
    gameMap mapaJuego;
    player Hero;
    mapaJuego.drawIntro();
    mapaJuego.drawMap();
    while (!mapaJuego.getGameStatus())
    {
      
      cout<<"Introduce el comando de movimiento 'WASD'"<<endl;
      Hero.callInput(); // Define movimiento del jugador
      if (mapaJuego.setPlayerCell(Hero.getPlayerX(),Hero.getPlayerY()))
      {
        mapaJuego.drawMap(); // Indica dibujar el mapa
      }else
      {
        Hero.resettoSafePosition();
        mapaJuego.drawMap();
      }
      
      cout<<"Las coordenadas del Heroe son:"<<" X = "<<Hero.getPlayerX()<<" Y = "<<Hero.getPlayerY()<<endl;
      cout<<"Dinero Actual: "<<Hero.getPlayerMoney()<<endl;
     
        // gameOver=true;
    }
    return 0;
}