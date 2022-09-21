using System;
namespace proj_snake
{
    public class BeginScene
    {
        int selectIdx = 0;
        bool isQuit = false;
        public BeginScene()
        {
            Console.SetCursorPosition(10, 5);
            Console.Write("开始界面");
            while(true)
            {
                if (selectIdx == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(10, 7);
                    Console.Write("开始游戏");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(10, 9);
                    Console.Write("退出游戏");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(10, 7);
                    Console.Write("开始游戏");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(10, 9);
                    Console.Write("退出游戏");
                }

                ConsoleKey key = Console.ReadKey(true).Key;
                switch(key)
                {
                    case ConsoleKey.DownArrow:
                        selectIdx = 1;
                        break;
                    case ConsoleKey.UpArrow:
                        selectIdx = 0;
                        break;
                    case ConsoleKey.J:
                        if (selectIdx == 1)
                        {
                            Environment.Exit(0);
                        } else
                        {
                            isQuit = true;
                            Game.ChangeScene(E_Game_Scene.Game);
                        }
                        break;
                }

                if (isQuit)
                    break;
               
            }
            

        }
    }
}
