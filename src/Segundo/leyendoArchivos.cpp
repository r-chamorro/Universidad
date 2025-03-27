#include <iostream>
#include <fstream>
using namespace std;

int main ()
{
    ofstream myFile("GameData.txt");// Guarda un archivo tipo TXT con nombre gamedata en path actual
    if(myFile.is_open())
    {
        myFile <<"Hola Usuario!"<<endl;
        myFile <<"Que bueno Verte!"<<endl;
        myFile <<"Estamos probando comunicacion!"<<endl;
        myFile <<"Pronto estaremos ahi!"<<endl;

    }
    myFile.close();

    ifstream myFileRead("GameData.txt");
    string line;
    int linecount=1;
    if(myFileRead.is_open())
    {
        while(getline(myFileRead,line))
        {
            cout<<line<<endl;


        }
        myFile.close();
    }else
    {
        cout<<"No logre acceder al archivo!";
    }

    return 0;
}