#include <iostream> // Biblioteca para manejo de entradas y salidas
#include <chrono> // Biblioteca para control de tiempo
#include <thread> // Control de hilo del procesador

using namespace std;
using namespace chrono;
using namespace this_thread;



/*
En su segundo reto lo que van a hacer es una pequeña aventura de texto.
¿Cómo van a lograr esto? Es bastante sencillo, lo que van a hacer es pedirle al usuario 
un Char(Caracter) usando COUT, y con CIN lo van a guardar en una variable.
Después van a comparar la variable en diferentes condicionales if, si se cumple van a 
imprimir diferentes decisiones de la historia. 
La historia es libre y ustedes pueden dejarla tan simple o complicada como quieran.
*/
void pressTocontinue () // Funcion para mostrar texto
{
cout<<"Presiona Enter para continuar..."<< endl;
cin.get();
}


void maquinaEscribir (string texto, int delayedby) //Funcion Para efecto maquina de escribir, recibe una variable de tipo string y un entero para el tiempo de espera
{
for (char c: texto) //Forma mejorada de iteracion en lugar de (int i=0;c<texto.length();i++)
{
cout<<c<<flush; // La opcion Flush hace que se muestre en pantalla de inmediato en vez de esperar por el comando endl, evita que aparezca todo el texto d eun solo golpe
sleep_for(milliseconds(delayedby)); // Aqui empleamos thread y chrono, thread para detener el terminal por ese tiempo y chronos para convertir un  numero enm milisegundos
}
cout<<endl;
}



int main ()
{
    
    //Creacion de textos para la historia
    string intro = "Despiertas! otra vez, existir, esta vez donde estamos? A donde me ha traido mi curiosidad hoy? bueno, no me quedare parado esperando respuestas"; 
    // Intro general a la historia
    string chapter1 = "Te levantas forzosamente y empiezar a recorrer la penumbra que te rodea, hasta que logras divisar un haz de luz al final de una habitacion. Decides abrir la puerta. 'Vaya parece que tengo un par de opciones para salir'";
    // Primer Capitulo, donde estoy
    string descripcion = "Una habitacion de piedra nos brinda una magnifica e inesperada vista, dentro de la habitacion permanecen solo la mitad del piso y del tejado, pedazos de muebles destruidos distribuidos mientras en el centro se erige una enorme roca, cual artista posando ante su obra";
    // Descipcion de la habitacion encontrada
    string detalle = "No parece haber otra salida, y las opciones son un tanto limitadas, podria volver por donde vine, tratar de salir por la ventana que no fue destruida por la roca o podria intentar escalar la roca";
    //  Decisiones a seguir
    string elRetorno = "Decides que no vale la pena tanto esfuerzo y mejor te regresas a lo oscurito a dormir un poco mas, total no tenias ganas de hacer nada";
    // Retornar por donde vine
    string laVentana = "Ves una ventana al extremo de la habitacion, intentas alcazarla pero olvidas tomar en cuenta dos pequenos detalles, por esa ventana solo cabe un nino y la ultima vez que revisaste no podias saltar 3 metros en el aire o si? Frustrado por tu mal calculo, te sientas en el piso y decides admirar la roca!";
    string suspenso = ". . ."; //El MERO SUSPENSOOOOO
    string laRoca = "El ser humano es uno de los mamiferos mas evolucionados y perfectos que existe hasta el momento, somos seres cultos y maravillosos, pero a pesar de todos los grandes avances en tecnologia y ciencias, siempre hay una constante IRREFUTABLE!!!!";
    string roca= "Simio ve roca, simio Feliz";

    // Estructura de lanzamiento para textos en variables

    maquinaEscribir(intro,25);         //  Lanzando intro al juego!
    maquinaEscribir(chapter1,25);      //  Breve capitulo 1
    maquinaEscribir(descripcion,25);   //  Descripcion de la habitacion 
    maquinaEscribir(detalle, 25);      //  Opciones disponibles


    //Ciclo de opciones a tomar

    int opcion;

           
        cout<<"------------"<<endl;
        cout<<"1 - Regresar por el mismo camino"<<endl;
        cout<<"2 - Alcanzar la ventana"<<endl;
        cout<<"3 - Roca"<<endl;
        cout<<"------------"<<endl;
        cin>>opcion;
        



        switch (opcion)
        {
        case 1:
            
            maquinaEscribir(elRetorno,25);
            cout<<"FIN DEL JUEGO";

            break;

        case 2:
            maquinaEscribir(laVentana,25);
            maquinaEscribir(suspenso,200);
            maquinaEscribir(roca,150);
            cout<<"FIN DEL JUEGO"<<endl;

        break;

        case 3:
            maquinaEscribir(laRoca,25);
            maquinaEscribir(suspenso,200);
            maquinaEscribir(roca,150);
            cout<<"HAZ ALCANZADO EL NIRVANA!"<<endl;

        break;  
        
        default:
            cout<<"Oye solo son 3 numeros!"<<endl;
            cout<<"Vamos tu puedes hacerlo, intenta de nuevo"<<endl;
            break;
        }
        return 0;
  
}