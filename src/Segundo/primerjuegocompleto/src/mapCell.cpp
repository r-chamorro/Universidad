#include <iostream>
#include "../headers/mapCell.h"
using namespace std;

mapCell::mapCell(): id('0'){}

char mapCell::getID()
{
    return id;
}

void mapCell::setID(char heroHere)
{
    id=heroHere;
}


