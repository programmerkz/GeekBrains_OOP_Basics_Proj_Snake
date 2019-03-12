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
            Tools.WaitingEnter();   // ожидаем нажатия Enter
        }
    }
}
