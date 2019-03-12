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
    }
}
