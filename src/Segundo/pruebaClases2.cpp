#include <iostream>
using namespace std;

class dog 
{
public:
    dog()
    {
        nName="Gogdo";
        nBark="Low Frequency";
    }

    dog(string name, string barkType)
    {
        nName = name;
        nBark=barkType;
    }

    string _getName()
    {
        return nName;
    }

    string _getBark()
    {
        return nBark;
    }


    void barking()
    {
        cout<<nBark<<endl;
    }

    void _setName(string newName)
    {
        nName=newName;
    }

    void _setBark(string newBark)
    {
        nBark=newBark;
    }
private:
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