#include <iostream>
using namespace std;

class cHuman 
{
    
//-------------------------------CONSTRUCTORES-------------------------------------//    
    public: // Incluir todas las Funcionalidades y detalles propios de la clase
    cHuman() // Constructor por defecto
    {
        hName ="Bob";
        hAge = 18;
        hRace= "Hispanic";

    }
    cHuman (string name, int hSpawnAge, string hSpawnRace)// Constructor incluir edad/raza
    {
        hName= name;
        hAge =  hSpawnAge;
        hRace= hSpawnRace;

    }
//-------------------------------FUNCIONES---------------------------------------//    
void getName()
{
    cout<<hName;
}


void hThink ()
{
    cout<<getThinkMessage()<<endl;
}

    private: // Inlcuir toda la data que queramos proteger y que solo pueda ser tocada desde dentro de esta funcion

string getThinkMessage()
    {
        return "\n Estoy Pensando: \n";
    }

//-------------------------------VARIABLES---------------------------------------//    
    string hName;
    int hAge;
    string hRace;
};

int main ()
{
    cHuman minion;
    cout<<"Me llamo: ";
    minion.getName();
    cout<<" Y yo ... ";
    minion.hThink();
return 0;
 
}

