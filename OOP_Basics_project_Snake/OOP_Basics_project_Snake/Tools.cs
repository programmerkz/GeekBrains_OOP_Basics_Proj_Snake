using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Basics_project_Snake
{
    static class Tools
    {
        const int GAME_AREA_WIDTH = 100;
        const int GAME_AREA_HEIGHT = 20;
        const int GAME_AREA_TOP = 2;
        const int GAME_AREA_LEFT = 4;
        const char GAME_AREA_CHAR = '#';


        public static void ShowCaption()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("OOP Basics. Blank console application \"Snake\"");
        }

        public static void DrawGameArea()
        {
            HorizontalLine hLine = new HorizontalLine(GAME_AREA_LEFT, GAME_AREA_LEFT + GAME_AREA_WIDTH, GAME_AREA_TOP, GAME_AREA_CHAR);
            hLine.Draw();

            hLine = new HorizontalLine(GAME_AREA_LEFT, GAME_AREA_LEFT + GAME_AREA_WIDTH, GAME_AREA_TOP + GAME_AREA_HEIGHT, GAME_AREA_CHAR);
            hLine.Draw();

            VerticalLine vLine = new VerticalLine(GAME_AREA_LEFT, GAME_AREA_TOP, GAME_AREA_TOP + GAME_AREA_HEIGHT, GAME_AREA_CHAR);
            vLine.Draw();

            vLine = new VerticalLine(GAME_AREA_LEFT + GAME_AREA_WIDTH, GAME_AREA_TOP, GAME_AREA_TOP + GAME_AREA_HEIGHT, GAME_AREA_CHAR);
            vLine.Draw();
        }

        public static void WaitingEnter()
        {
            Console.SetCursorPosition(GAME_AREA_LEFT, GAME_AREA_TOP + GAME_AREA_HEIGHT + 1);
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
