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

        internal bool IsHit(Figure obstacleFigure)
        {
            foreach (Point p in pointList)
                if (obstacleFigure.IsHit(p))
                    return true;

            return false;
        }

        private bool IsHit(Point obstaclePoint)
        {
            foreach (Point p in pointList)
                if (p.isHit(obstaclePoint))
                    return true;

            return false;
        }
    }
}
