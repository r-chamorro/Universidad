#include <iostream>
using namespace std;






void drawMap(int x, int y)
{

    for (int i = 1; i <= y; i++)
    {

        for (int j = 1; j <=x; j++)
        {
            cout<<'O';
        }
        
        cout<<endl;
    }
    

};


int main() {
    int x,y;
    cin>>x;
    cin>>y;

    drawMap(x,y);
 return 0;  
}