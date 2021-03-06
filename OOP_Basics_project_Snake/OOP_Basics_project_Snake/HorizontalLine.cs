﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Basics_project_Snake
{
    class HorizontalLine:Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char symb)
        {
            pointList = new List<Point>();

            for (int x = xLeft; x <= xRight; x++)
                pointList.Add(new Point(x, y, symb));
        }
    }
}
