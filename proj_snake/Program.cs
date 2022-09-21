using System;

namespace proj_snake
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Game game = new Game();
            game.start();
            //BeginScene scene = new BeginScene();
            
        }
    }
}
