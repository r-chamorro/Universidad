#include <iostream>
using namespace std;

class dog // Definiendo Clase dog
{
public: // Elementos publicos que pueden ser accedidos
    dog() // Constructor por defecto, se inicializa cuando no se pasan parametros
    {
        nName="Gogdo";
        nBark="Low Frequency";
    }

    dog(string name, string barkType) // Constructor manual, emplea los valores definidos opr usuario
    {
        nName = name;
        nBark=barkType;
    }
//Getters y Setters
    string _getName() // Getter _getName funcion para poder leer la variable nName
    {
        return nName;
    }

    string _getBark() // Getter  _getBark funcion para poder leer la variable nBark
    {
        return nBark;
    }
    void _setName(string newName) // setter _setName funcion para poder manipular la variable nName
    {
        nName=newName;
    }

    void _setBark(string newBark) // setter _setBark funcion para poder manipular la variable nBark
    {
        nBark=newBark;
    }
//Funcionalidad
    void barking() // Funcion de la clase dog = Ladrar!
    {
        cout<<nBark<<endl;
    }
private: // Elementos privados que solo pueden ser accedidos por metodos internos
    string nName;
    string nBark;
};


int main ()
{
    dog myFirstDog;
    dog mySecondDog("Puchito","High Pitch");
    cout<<myFirstDog._getName()<<endl;
    cout<<myFirstDog._getBark()<<endl;
    cout<<mySecondDog._getName()<<endl;
    cout<<mySecondDog._getBark()<<endl;

    myFirstDog._setName("Juliano");
    mySecondDog._setName("Gogdito");
    cout<<myFirstDog._getName()<<endl;
    cout<<mySecondDog._getName()<<endl;
    myFirstDog.barking();
    mySecondDog.barking();
    return 0;
}