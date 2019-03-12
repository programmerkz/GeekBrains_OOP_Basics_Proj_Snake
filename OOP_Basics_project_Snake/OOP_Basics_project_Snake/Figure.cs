using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Basics_project_Snake
{
    class Figure
    {
        protected List<Point> pointList;

        public void Draw()
        {
            foreach (Point p in pointList)
                p.Draw();
        }
    }
}
