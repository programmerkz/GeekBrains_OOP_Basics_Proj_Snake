using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OOP_Basics_project_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Tools.DrawGameArea(true);

            Snake snake = new Snake(new Point(13, 14, Tools.SNAKE_CHAR), 3, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(Tools.GAME_AREA_WIDTH, Tools.GAME_AREA_HEIGHT, Tools.GAME_AREA_TOP, Tools.GAME_AREA_LEFT, Tools.FOOD_CHAR);
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                    snake.Move();

                Thread.Sleep(Tools.GAME_DELAY);

                if (Console.KeyAvailable) { snake.HandleKey(Console.ReadKey().Key); }
            }
        }
    }
}
