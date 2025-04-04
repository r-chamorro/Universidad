#include <iostream>
using namespace std;

// Definicion de Clases

class cCharacter 
{

    public:
    cCharacter()
    {
        cName="Ulreck";
        cMana=100;
        cVida=100;
        cPoder=10;

    }
    cCharacter(string name, int mana, int vida, int poder)
    {
        cName=name;
        cMana=mana;
        cVida=vida;
        cPoder=poder;

    }
    void setName(string newName)
    {
        cName=newName;
    }
    void setVida(int newVida)
    {
        cVida=newVida;
    }
    void setMana(int newMana)
    {
        cMana=newMana;
    }
    void setPoder(int newPoder)
    {
        cPoder=newPoder;
    }

    //Getter!!
    void getName()
    {
        cout<<cName;
    }
    void getMana()
    {
        cout<<cMana;
    }
    void getVida()
    {
        cout<<cVida;
    }
    void getPoder()
    {
        cout<<cPoder;
    }

    private:
    //Setter!!
    

    string cName;
    int cMana;
    int cVida;
    int cPoder;

};


class cWarrior()
{

};


int main ()
{
    cCharacter mago;
    mago.getName();
    return 0;
}
