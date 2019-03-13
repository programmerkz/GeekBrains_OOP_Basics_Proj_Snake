using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Basics_project_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Tools.ShowCaption();    // вывести заголовок
            Tools.DrawGameArea();   // нарисовать игровое поле

            Point snakeTail = new Point(13, 14, '*');
            Snake snake = new Snake(snakeTail, 7, Direction.UP);
            snake.Draw();



            Tools.WaitingEnter();   // ожидаем нажатия Enter
        }
    }
}
