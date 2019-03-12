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
            Point p1 = new Point(4, 2, '%');
            p1.Draw();

            Point p2 = new Point(5, 3, '#');
            p2.Draw();


            // рисуем горизонтальную линию (с помощью специально созданного класса)
            HorizontalLine hLine = new HorizontalLine(0, 30, 6, '=');
            hLine.Draw();

            
            

            Tools.WaitingEnter();   // ожидаем нажатия Enter
        }
    }
}
