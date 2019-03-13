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
            Tools.DrawGameArea(true);   // нарисовать игровое поле

            Point snakeTail = new Point(13, 14, '*');
            Snake snake = new Snake(snakeTail, 7, Direction.RIGHT);
            snake.Draw();

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(300);
                snake.Move();
                snake.Draw();
            }
            



            Tools.WaitingEnter();   // ожидаем нажатия Enter
        }
    }
}
