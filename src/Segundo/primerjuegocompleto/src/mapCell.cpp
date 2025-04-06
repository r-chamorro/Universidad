#include <iostream>
#include "../headers/mapCell.h"
using namespace std;


mapCell::mapCell() : id(0){}


void mapCell::setid(int x)
{
 id=x;
}
int mapCell::getid()
{
    return  id;
}
    

