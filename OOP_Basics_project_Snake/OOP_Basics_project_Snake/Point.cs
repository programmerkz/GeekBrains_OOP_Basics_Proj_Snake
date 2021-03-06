﻿using System;
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

        public bool isHit(Point p)
        {
            if ((x == p.x) && (y == p.y))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Draw();
                Console.ResetColor();

                return true;
            }
                
            else
                return false;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }

        public void Clear()
        {
            symb = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + symb;
        }
    }
}
