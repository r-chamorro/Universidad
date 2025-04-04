#include <iostream>
using namespace std;


class cPersonaje
{
    public:
//CONSTRUCTORES
    cPersonaje() // Constructor por defecto
    {
        characterName = "Ulreck";
        characterMagicPower = 10;
        characterPhisicPower = 20;
        characterHealth = 100;
        characterMana = 100;    
    }

    cPersonaje(string name, int Mpower, int Ppower, int health, int mana)// Constructor a detalle
    {
        characterName = name;
        characterMagicPower = Mpower;
        characterPhisicPower = Ppower;
        characterHealth = health;
        characterMana = mana;    

    }
// SETTER & GETTERS
    void getName()
    {
    cout<<"Mi nombre es: "<<characterName<<endl;
    }
    void getMPower(){
        cout<<"Mi Poder magico es de: "<<characterMagicPower<<endl;
    }
    void getPPower(){
        cout<<"Mi Poder Fisico es de: "<<characterPhisicPower<<endl;
    }
    void getHealth(){
        cout<<"Mi vida actual es de: "<<characterHealth<<endl;
    }
    void getMana(){
        cout<<"Mi Mana acutal es de: "<<characterMana<<endl;
    }
    void getDetails()
    {
        getName();
        getPPower();
        getMPower();
        getHealth();
        getMana();
    }

    void setName(string newName)
    {
        characterName = newName;
    }
    void setMPower(int newMpower){
        characterMagicPower = newMpower;
    }
    void setPPower(int newSpower){
        characterPhisicPower =newSpower;
    }
    void setHealth(int newHP){
        characterHealth=newHP;
    }
    void setMana(int newMana){
        characterMana = newMana;
    }


    private:
    string characterName;
    int characterMagicPower;
    int characterPhisicPower;
    int characterHealth;
    int characterMana;
    
};

class hMago :public cPersonaje
{
    public:
    hMago(string hName , int hMagpower, int hphipower,int hHealth, int hMana ):  cPersonaje(hName,hMagpower,hphipower,hHealth,hMana)
    {
        setMana(hMana);
        setHealth(hHealth);
        setPPower(hphipower);
        setMPower(hMagpower);
        setName(hName);

    }
    
};

int main ()
{

    cPersonaje mago ("Josefo",150,25,100,500);
    mago.getDetails();
    hMago gandalf("Gandalf",300,100,100,1000);
    gandalf.getDetails();

    


    return 0;
}