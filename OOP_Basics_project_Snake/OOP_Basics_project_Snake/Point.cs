using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Basics_project_Snake
{
    class Point
    {
        public int x, y;
        public char symb;

        public Point()
        {
        }

        public Point(Point pointToCopyFrom)
        {
            x = pointToCopyFrom.x;
            y = pointToCopyFrom.y;
            symb = pointToCopyFrom.symb;
        }

        public Point(int x, int y, char symb)
        {
            this.x = x;
            this.y = y;
            this.symb = symb;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.LEFT)        { x -= offset; }
            else if (direction == Direction.RIGHT)  { x += offset; }
            else if (direction == Direction.UP)     { y -= offset; }
            else if (direction == Direction.DOWN)   { y += offset; }
        }

        public bool Draw()
        {
            if ((x < 0) || (y < 0))
                return false;
            else
            {
                Console.SetCursorPosition(x, y);
                Console.Write(symb);
                return true;
            }
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + symb;
        }
    }
}
