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
            Snake snake = new Snake(new Point(13, 14, '*'), 12, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable) { snake.HandleKey(Console.ReadKey().Key); }

                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
