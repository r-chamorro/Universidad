#include <iostream>
using namespace std;

int main() {
    int tamano;
    cout << "Ingresa el número de filas: ";
    cin >> tamano;

    // Imprimir el triángulo centrado
    for (int i = 1; i <= tamano; i++)
    {
        for (int j=tamano-i; j >0 ; j--)
        {
            cout<<" ";    
        }
        for (int k=1; k<=i ; k++)
        {
            cout<<"* ";    
        }
        
        cout<<endl;
        
    }
    

    return 0;
}