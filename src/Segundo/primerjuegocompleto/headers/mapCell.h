#ifndef MAP_CELL
#define MAP_CELL

class mapCell
{
    public:
    mapCell();
    char getID();
    void setID(char);
    bool isBlocked();
    
    private:
    char id;
    
};
#endif