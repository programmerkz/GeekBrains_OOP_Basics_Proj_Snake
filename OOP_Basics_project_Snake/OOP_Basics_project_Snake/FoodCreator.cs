using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Basics_project_Snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        int mapTop;
        int mapLeft;
        char foodSymbol;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, int mapTop, int mapLeft, char foodSymbol)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.mapTop = mapTop;
            this.mapLeft = mapLeft;
            this.foodSymbol = foodSymbol;
        }

        public Point CreateFood(Figure snake)
        {
            bool isFoodOverSnake = true;
            Point foodPoint = null;

            while (isFoodOverSnake)
            {
                int x = random.Next(mapLeft + 1, mapLeft + mapWidth - 1);
                int y = random.Next(mapTop + 1, mapTop + mapHeight - 1);
                foodPoint = new Point(x, y, foodSymbol);

                isFoodOverSnake = snake.IsHit(foodPoint);
            }
            return foodPoint;
        }
    }
}
