using System;
using System.Collections.Generic;
using System.Threading;

namespace proj_snake
{
    public enum E_Sanke_Dir
    {
        Up,
        Down,
        Left,
        Right,
    }

    public class GameScene
    {
        private List<DrawObject> snakeList = new List<DrawObject>();
        private E_Sanke_Dir snakeDir = E_Sanke_Dir.Right;
        private Food food;
        public GameScene()
        {
            Map map = new Map(Game.w, Game.h);
            map.Draw();
            snakeList.Add(new DrawObject(25, 10, E_Draw_Type.Head));
          
            food = new Food(Game.w, Game.h);
            food.GenerateFood(snakeList);
            while (true)
            {

                Clear();
                DrawObject head = snakeList[0];

                if (head.pos == food.pos)
                {
                    snakeList.Add(new DrawObject(0, 0, E_Draw_Type.Body));

                    food.GenerateFood(snakeList);
                    
                }
               
                Vector2d pos = head.pos;
                switch (snakeDir)
                {
                    case E_Sanke_Dir.Up:
                        pos.y -= 1;
                        break;
                    case E_Sanke_Dir.Down:
                        pos.y += 1;
                        break;
                    case E_Sanke_Dir.Left:
                        pos.x -= 1;
                        break;
                    case E_Sanke_Dir.Right:
                        pos.x += 1;
                        break;
                }

                for (int i = snakeList.Count-1; i > 0; i--)
                {
                    snakeList[i].pos = snakeList[i - 1].pos;
                }
                head.pos = pos;

                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;
                    switch(key)
                    {
                        case ConsoleKey.DownArrow:
                            snakeDir = E_Sanke_Dir.Down;
                            break;
                        case ConsoleKey.UpArrow:
                            snakeDir = E_Sanke_Dir.Up;
                            break;
                        case ConsoleKey.LeftArrow:
                            snakeDir = E_Sanke_Dir.Left;
                            break;
                        case ConsoleKey.RightArrow:
                            snakeDir = E_Sanke_Dir.Right;
                            break;

                    }
                }
                DrawSnake();
                Thread.Sleep(200);
            }
        }

        
        public void Clear()
        {
            foreach (var item in snakeList)
            {
                Console.SetCursorPosition(item.pos.x, item.pos.y);
                Console.Write(" ");
            }
        }
        public void DrawSnake()
        {
            
            foreach(var item in snakeList)
            {
                item.Draw();
            }
        }
    }
}