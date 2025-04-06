#include <iostream>
#include "../headers/gameMap.h"

using namespace std;



gameMap::gameMap()
{

};

void gameMap::drawMap()
{

    for (int i = 0; i < 15; i++)
    {

        for (int j = 0; j <10; j++)
        {
            cout<<'O';
        }
        
        cout<<endl;
    }
    

};
