#include <iostream>
#include "../headers/mapCell.h"
using namespace std;

mapCell::mapCell(): id(' '){}

char mapCell::getID()
{
    return id;
}

void mapCell::setID(char heroHere)
{
    id=heroHere;
}

bool mapCell::isBlocked()
{
    if (getID()=='#')
    {
        return true;
    }else
    {
        return false;
    }
    
}

bool mapCell::isMoney()
{
    if (getID()=='$')
    {
        return true;
    }else
    {
        return false;
    }
    
}

