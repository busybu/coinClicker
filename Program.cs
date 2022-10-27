using System;

class Clicker
{
    static void Main()
    {   
        Game jogo = new Game();

        while(true)
        {
            jogo.PrintGame();
            jogo.GetClick();
        }
        
    }
}