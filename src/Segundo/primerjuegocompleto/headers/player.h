#ifndef PLAYER_PAGE
#define PLAYER_PAGE
using namespace std;

class player
{
    public:
        player();
        int getPlayerX();
        int getPlayerY();
        int getPlayerLastX();
        int getPlayerLastY();
        int getPlayerMoney();
        void callInput();
        void setPlayerX(int);
        void setPlayerY(int);
        void resettoSafePosition();
        void setPlayerLastX(int);
        void setPlayerLastY(int);
        void increasePlayerX();
        void increasePlayerY();
        void decreasePlayerX();
        void decreasePlayerY();
        void increasePlayerMoney();

    protected:
        
    private:
    int playerX, playerY, playerLastX,playerLastY, playerMoney=0;
    
};


#endif