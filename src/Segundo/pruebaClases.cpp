#include <iostream>
using namespace std;

class Cat
{
public:
    string Name;
    Cat()
    {
        Name = "Guapo";
    }
    Cat(string iName)
    {
        Name=iName;
    }
    void Meow()
    {
        cout<<Name<<"Dice Meow!"<<endl;
    }
};


int main ()
{
    Cat MyFirstKitty;
    Cat MysecondKitty("Eriberto");
    
    cout<<MyFirstKitty.Name<<endl;
    cout<<MysecondKitty.Name<<endl;
    MyFirstKitty.Meow();
    MysecondKitty.Meow();
    return 0;
}