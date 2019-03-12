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
            Tools.ShowCaption();  // вывести заголовок

            
            // Тест функции вывода символа в указанную позицию:
            Point p1 = new Point();
            p1.x = 4;
            p1.y = 2;
            p1.symb = '%';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 2;
            p2.symb = '%';
            p2.Draw();

            Tools.WaitingEnter();   // ожидаем нажатия Enter
        }
    }
}
