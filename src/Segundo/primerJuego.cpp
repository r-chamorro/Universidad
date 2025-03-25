#include <iostream>
using namespace std;

bool playerisdead(int hp) // Funcion tipo bool para confirmar si el jugador esta muerto o no
{
    if (hp<=0)
    {
        return true;
    }else
    {
        return false;
    }
}

int main ()
{
    int totallife =3;
    if(playerisdead(totallife))
    {
        cout<<"Has muerto!";

    }
    return 0;
}
