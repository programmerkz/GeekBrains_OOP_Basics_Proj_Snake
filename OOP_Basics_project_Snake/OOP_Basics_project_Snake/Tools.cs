using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Basics_project_Snake
{
    static class Tools
    {
        public static void ShowCaption()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("OOP Basics. Blank console application \"Snake\"");
        }

        public static void DrawGameArea()
        {
            HorizontalLine hLine = new HorizontalLine(0, 100, 1, '#');
            hLine.Draw();

            hLine = new HorizontalLine(0, 100, 30, '#');
            hLine.Draw();

            VerticalLine vLine = new VerticalLine(0, 1, 30, '#');
            vLine.Draw();

            vLine = new VerticalLine(100, 1, 30, '#');
            vLine.Draw();
        }

        public static void WaitingEnter()
        {
            Console.SetCursorPosition(0, 31);
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
