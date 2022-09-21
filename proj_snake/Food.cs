using System;
using System.Collections.Generic;

namespace proj_snake
{
    public class Food : IDraw
    {
        public Vector2d pos;
        Random rd = new Random();
        int w;
        int h;
        public Food(int w, int h)
        {
            this.w = w;
            this.h = h;
        }

        public void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("●");
        }

        public void GenerateFood(List<DrawObject> snakeList)
        {

            do
            {
                
                int x = rd.Next(1, w * 2 - 1);
                int y = rd.Next(1, h - 1);
                Vector2d p = new Vector2d(x, y);

                bool isQuit = true;
                foreach (var snake in snakeList)
                {
                    if (snake.pos == p)
                    {
                        isQuit = false;
                        break;
                    }
                }
                if (isQuit)
                {
                    pos = p;
                    Draw();
                    return;
                }

            } while (true);
         
        }
    }
}
