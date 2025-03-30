#include <iostream>

using namespace std;


int main ()
{
/*
Solicita un número entero n y dibuja un triángulo de altura n con asteriscos
*/
int tamano =1;
string triangulo =" ";
cin>>tamano;
cout<<"Selecciona un numero entero y dibujare un triangulo de ese tamano"<<endl;
for (int i = tamano; i >= 0; i--)
{ 
    
    triangulo+="*";
    cout<<triangulo<<endl;
}

return 0;

}