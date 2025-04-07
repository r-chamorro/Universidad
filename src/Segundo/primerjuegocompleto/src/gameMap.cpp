#include <iostream>
#include <fstream>
#include <string>
#include "../headers/gameMap.h"
#include "../headers/mapCell.h"
#include "../headers/player.h"

gameMap::gameMap(): PlayerCell(NULL) 
{
    loadMapFromFile();
};

void gameMap::drawMap()
{

    for (int i = 0; i <10; i++)
    {
        for (int j = 0; j < 15; j++)
        {
            cout<<celdaMapa[j][i].getID();
        }
        cout<<endl;
    }
    
};

bool gameMap::setPlayerCell(int playerX, int PlayerY)
{
    if (!celdaMapa[playerX][PlayerY].isBlocked())
    {
        if (PlayerCell!=NULL)
        {
            PlayerCell->setID(' ');
        }
            PlayerCell = &celdaMapa[playerX][PlayerY];    
            PlayerCell->setID('H');
            return true;
        
    }else
    {
        hero.resettoSafePosition();
        return false;
    }
    // cout<<"Las coordenadas del jugador son: X = "<<playerX<<" Y = "<<PlayerY<<endl;
};

void gameMap::loadMapFromFile()
{
    /*ofstream fileCreated("map.txt"); // Flujo de procesos Output File Stream = escribir hacia archivo
    if (fileCreated.is_open())
    {
        //
    }else
    {
        cout<<"FATAL ERROR: MAP FILE COULD NOT BE CREATED!"<<endl;
    }
    */
    
    string line; 
    int row =0;
    ifstream myFile("map.txt"); //Flujo de procesos input File stream = leer desde archivo
    if(myFile.is_open())
    {
        // cout<<"Prueba Carga de mapa"<<endl;
        while (getline(myFile,line))
        {

                for (int i = 0; i < line.length(); i++)
                {   if (line[i]=='0')
                    {
                        gameMap::celdaMapa[i][row].setID(' ');
                    }else
                    {
                        gameMap::celdaMapa[i][row].setID(line[i]);
                    }
                }
            row++;
        }
        // cout<<"Prueba Carga de mapa"<<endl;
    
    }
    else{
        cout<<"FATAL ERROR: MAP FILE COULD NOT BE LOADED"<<endl;
        }

};