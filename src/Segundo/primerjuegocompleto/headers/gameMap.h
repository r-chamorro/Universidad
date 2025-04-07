#ifndef GAME_MAP
#define GAME_MAP
#include "./mapCell.h"
#include "./player.h"


class gameMap
{
    public:
    gameMap();
    mapCell* PlayerCell;
    mapCell celdaMapa[15][10];
    player hero;
    void drawMap();
    bool setPlayerCell(int, int); // obtiene las coordenadas del jugador y actualiza el mapa
    
    private:

    protected:
    void loadMapFromFile();

};


#endif