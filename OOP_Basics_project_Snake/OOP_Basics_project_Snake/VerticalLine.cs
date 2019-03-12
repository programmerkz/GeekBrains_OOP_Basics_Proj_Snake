using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Basics_project_Snake
{
    class VerticalLine:Figure
    {
        public VerticalLine(int x, int yTop, int yDown, char symb)
        {
            pointList = new List<Point>();

            for (int y = yTop; y <= yDown; y++)
                pointList.Add(new Point(x, y, symb));
        }
    }
}
