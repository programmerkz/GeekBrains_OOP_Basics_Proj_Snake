using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Basics_project_Snake
{
    class Snake:Figure
    {
        public Snake(Point tail, int lenth, Direction direction)
        {
            pointList = new List<Point>();

            for (int i = 0; i < lenth; i++)
            {
                Point bodyPoint = new Point(tail);
                bodyPoint.Move(i, direction);
                pointList.Add(bodyPoint);
            }
        }
    }
}
