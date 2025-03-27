#include <iostream>
#include <fstream>

using namespace std;

int main (){
ifstream myFileRead("GameData.txt");
string line;
int lineCount=0;

while(myFileRead.is_open())
{ 
    if(lineCount==2)
     getline(myFileRead,line);    
}
    
else
{
    cout<<"No logre acceder al archivo!";
}
myFileRead.close();

return 0;
}