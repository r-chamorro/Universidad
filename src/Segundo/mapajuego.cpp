#include <iostream>
using namespace std;

void DrawMap (int heroPositionX,int heroPositionY, char mapaJuego[5][5])
{cout<<endl;
    for (int i=0;i <5;i++)
    {
        for (int j=0;j <5;j++)
        {
            if (heroPositionX==i && heroPositionY==j)
            {
                cout<<'H'<<" ";
            }else
            {
                cout<<mapaJuego[i][j]<<" ";
                

            }
            
        }   
        cout<<endl;
        

    }


  
    
}

int main()
{
    
    int heroFilas =0, heroColumnas =0;
    bool gameOver = false;
    char Input = ' ';
    char mapaJuego[5][5] = {
    {'1','1','1','1','1'},
    {'1','1','1','1','1'},
    {'1','1','1','1','1'},
    {'1','1','1','1','1'},
    {'1','1','1','1','1'}};
    DrawMap(heroFilas,heroColumnas,mapaJuego);
    

    while (!gameOver)
    {
        cout<<"\n";
        cin>>Input;    
        switch (Input)
        {
        case 'd': case 'D':
        if (heroColumnas<4)
        {
            heroColumnas++;     
        }else
        {
            cout<<"No Puedes Avanzar mas por este rumbo! \n"<<"Intenta otra direccion!"<<endl;
        }

        break;
        case 'i': case 'I':
            if(heroColumnas==0)
            {
                    cout<<"No Puedes Avanzar mas por este rumbo! \n"<<"Intenta otra direccion!"<<endl;
            }else heroColumnas--; 
        break;
        case 'b': case 'B':
        if (heroFilas<4)
        {
            heroFilas++;     
        }else
        {
            cout<<"No Puedes Avanzar mas por este rumbo! \n"<<"Intenta otra direccion!"<<endl;
        }
        break;
        case 's': case 'S':
        if(heroFilas==0)
            {
                    cout<<"No Puedes Avanzar mas por este rumbo! \n"<<"Intenta otra direccion!"<<endl;
            }else heroFilas--; 
        break;
        case 'p': case 'P':
        cout<<"Gracias por jugar"<<endl;
        cout<<"\nPROGRAMA FINALIZADO"<<endl;
        gameOver=true;
        break;
        default:
        cout<<"\nPor favor elige entre las 5 opciones disponibles: \n"<<"Subir (S,s) \nBajar (B,b) \nIzquierda (I,i) \nDerecha (D,d) \nPara salir presiona 'P' o 'p'"<<endl;
        break;
        }

        DrawMap(heroFilas,heroColumnas,mapaJuego);
    
    }


return 0;
}