using System;
namespace proj_snake
{
    public class Map : IDraw
    {

        private int w;
        private int h;
        public Map(int w, int h)
        {
            this.w = w;
            this.h = h;

        }

        public void Draw()
        {
            //DrawObject.DrawSingle(w, h / 2, ConsoleColor.Blue, "■");
            //DrawObject.DrawSingle(w + 1, h / 2, ConsoleColor.Blue, "■");
            //DrawObject.DrawSingle(w + 2, h / 2, ConsoleColor.Blue, "■");
            //DrawObject.DrawSingle(10, 8, ConsoleColor.Blue, "■");

            for (int i = 0; i < w; i++)
            {
                DrawObject.DrawSingle(i, 0, ConsoleColor.Red, "■");
                DrawObject.DrawSingle(i, h - 1, ConsoleColor.Red, "■");
            }

            for (int i = 0; i < h; i++)
            {
                DrawObject.DrawSingle(0, i, ConsoleColor.Red, "■");
                DrawObject.DrawSingle(w*2, i, ConsoleColor.Red, "■");
            }

           

        }
    }
}
