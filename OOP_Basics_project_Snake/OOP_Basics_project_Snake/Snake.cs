using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Basics_project_Snake
{
    class Snake:Figure
    {
        public Direction moveDirection;

        public Snake(Point tail, int lenth, Direction direction)
        {
            moveDirection = direction;
            pointList = new List<Point>();

            for (int i = 0; i < lenth; i++)
            {
                Point bodyPoint = new Point(tail);
                bodyPoint.Move(i, direction);
                pointList.Add(bodyPoint);
            }
        }


        internal void Move()
        {
            // удалить хвост (это первая точка в списке)
            // получить из метода GetNextPoint() точку новой головы
            // добавить эту точку в список
            // слелать отрисовку (стереть хвост и нарисовать новую голову)

            Point tailPoint = pointList.First();
            pointList.Remove(tailPoint);

            Point newHeadPoint = GetNextPoint();
            pointList.Add(newHeadPoint);

            tailPoint.Clear();
            newHeadPoint.Draw();
        }

        public Point GetNextPoint()
        {
            // получить точку Головы змейки (это последняя в списке)
            // создать новую копию полученной точки
            // сместить её по направлению движения змейки
            // добавить в список точек

            Point snakeHead = pointList.Last();
            Point nextHeadPoint = new Point(snakeHead);
            nextHeadPoint.Move(1, moveDirection);
            return nextHeadPoint;
        }
    }
}
