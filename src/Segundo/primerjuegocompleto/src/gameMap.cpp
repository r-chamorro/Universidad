#include <iostream>
#include <fstream>
#include <string>
#include "../headers/gameMap.h"
#include "../headers/mapCell.h"

gameMap::gameMap(): PlayerCell(NULL) 
{
    loadMapFromFile();
};

void gameMap::drawMap()
{

    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 15; j++)
        {
            cout<<celdaMapa[j][i].getID();
        }
        cout<<endl;
    }
    
};

void gameMap::setPlayerCell(int playerX, int PlayerY)
{
    
    if (PlayerCell!=NULL)
    {
        PlayerCell->setID('0');
    }
        PlayerCell = &celdaMapa[playerX][PlayerY];    
        PlayerCell->setID('H');
    
    
    
    
    // cout<<"Las coordenadas del jugador son: X = "<<playerX<<" Y = "<<PlayerY<<endl;
};

void gameMap::loadMapFromFile()
{
    ofstream fileCreated("map.txt");
    if (fileCreated.is_open())
    {
        /* code */
    }else
    {
        cout<<"FATAL ERROR: MAP FILE COULD NOT BE CREATED!"<<endl;
    }
    
    string line;
    ifstream myFile("map.txt");
    if(!myFile.is_open())
    {
        cout<<"FATAL ERROR: MAP FILE COULD NOT BE LOADED"<<endl;
    }

};