using System;
namespace proj_snake
{
    public enum E_Draw_Type
    {
        Wall,
        Head,
        Body
    }
    public class DrawObject: IDraw
    {
        public Vector2d pos;
        public E_Draw_Type type;
        public DrawObject(int x, int y, E_Draw_Type type)
        {
            pos = new Vector2d(x, y);
            this.type = type;
        }

        public void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            switch(this.type)
            {
                case E_Draw_Type.Wall:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("■");
                    break;
                case E_Draw_Type.Head:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("■");
                    break;
                case E_Draw_Type.Body:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("■");
                    break;
            }
        }

        public static void DrawSingle(int x, int y, ConsoleColor consoleColor, string ch = "◼")
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = consoleColor;
            Console.Write(ch);
        }

        
    }
}
