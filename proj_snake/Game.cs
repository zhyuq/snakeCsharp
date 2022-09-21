using System;
namespace proj_snake
{
    public enum E_Game_Scene
    {
        Begin,
        Game,
        End
    }

    public class Game
    {
        public const int w = 50;
        public const int h = 20;
        private static E_Game_Scene gameScene = E_Game_Scene.Begin;
        public Game()
        {
            
        }

        public void start()
        {
            while(true)
            {
                switch (gameScene)
                {
                    case E_Game_Scene.Begin:
                        Console.Clear();
                        new BeginScene();
                        break;
                    case E_Game_Scene.Game:
                        Console.Clear();
                        new GameScene();
                        break;
                    case E_Game_Scene.End:
                        Console.Clear();
                        new EndScene();
                        break;
                }
            }
        }

        public static void ChangeScene(E_Game_Scene scene)
        {
            gameScene = scene;
        }
    }
}