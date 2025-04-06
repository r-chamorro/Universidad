#include <iostream>
#include "./headers/gameMap.h"
#include "./headers/mapCell.h"
using namespace std;

//bienvenido al mundo de Elias



main()
{
    cout<<"Pueba de ejecucion: "<<endl;
    gameMap mapa;
    //mapa.drawMap();
    cout<<"Espacio de separacion!"<<endl;
    mapCell fichaMapa;
    cout<<fichaMapa.getid()<<endl;
    fichaMapa.setid(8);
    cout<<fichaMapa.getid()<<endl;

    return 0;
}