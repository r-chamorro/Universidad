#include <iostream>
using namespace std;
string name;

void printmessage() // Creando Funcion para encapsulamiento de datos
{
cout<< "Eres Lo Melhor!"<<endl;
cout<< "Hoy es un gran dia!"<<endl;
}

int main ()
{
printmessage(); // Una vez creada ya puede ser empleada n veces.
printmessage();
printmessage();

return 0; // Siempre se debe retornar 0 para indicar que todo esta en orden.
}