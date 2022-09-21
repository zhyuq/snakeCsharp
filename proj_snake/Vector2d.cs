using System;
namespace proj_snake
{
    public struct Vector2d
    {
        public int x;
        public int y;
        public Vector2d(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator ==(Vector2d lhs, Vector2d rhs)
        {
            if (lhs.x == rhs.x && lhs.y == rhs.y)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Vector2d lhs, Vector2d rhs)
        {
            if (lhs.x == rhs.x && lhs.y == rhs.y)
            {
                return true;
            }
            return false;
        }
    }
}
