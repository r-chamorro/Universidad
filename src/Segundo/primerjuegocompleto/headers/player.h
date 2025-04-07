#ifndef PLAYER_PAGE
#define PLAYER_PAGE
using namespace std;

class player
{
    public:
        player();
        int getPlayerX();
        int getPlayerY();
        void callInput();
        void increasePlayerX();
        void increasePlayerY();
        void decreasePlayerX();
        void decreasePlayerY();

    protected:
        
    private:
    int playerX, playerY;
};


#endif