using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Basics_project_Snake
{
    static class Tools
    {
        public const int GAME_AREA_WIDTH = 80;
        public const int GAME_AREA_HEIGHT = 20;
        public const int GAME_AREA_TOP = 1;
        public const int GAME_AREA_LEFT = 0;

        public const char GAME_AREA_CHAR = '#';
        public const char FOOD_CHAR = '$';
        public const char SNAKE_CHAR = '*';

        public const int GAME_DELAY = 100;


        public static void ShowCaption()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("GeekBrains - OOP Basics. The \"Snake\" by Alexandr Volossatov");
        }

        public static List<Figure> DrawGameArea(bool showCaption)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(GAME_AREA_LEFT + GAME_AREA_WIDTH + 2, GAME_AREA_TOP + GAME_AREA_HEIGHT + 3);
            Console.SetBufferSize(GAME_AREA_LEFT + GAME_AREA_WIDTH + 2, GAME_AREA_TOP + GAME_AREA_HEIGHT + 3);

            if (showCaption) { ShowCaption(); }

            List<Figure> gameAreaWalls = new List<Figure>();

            gameAreaWalls.Add(new HorizontalLine(GAME_AREA_LEFT, GAME_AREA_LEFT + GAME_AREA_WIDTH, GAME_AREA_TOP, GAME_AREA_CHAR));
            gameAreaWalls.Add(new HorizontalLine(GAME_AREA_LEFT, GAME_AREA_LEFT + GAME_AREA_WIDTH, GAME_AREA_TOP + GAME_AREA_HEIGHT, GAME_AREA_CHAR));
            gameAreaWalls.Add(new VerticalLine(GAME_AREA_LEFT, GAME_AREA_TOP, GAME_AREA_TOP + GAME_AREA_HEIGHT, GAME_AREA_CHAR));
            gameAreaWalls.Add(new VerticalLine(GAME_AREA_LEFT + GAME_AREA_WIDTH, GAME_AREA_TOP, GAME_AREA_TOP + GAME_AREA_HEIGHT, GAME_AREA_CHAR));

            foreach (Figure wall in gameAreaWalls)
                wall.Draw();

            return gameAreaWalls;
        }

        public static void WaitingEnter()
        {
            Console.SetCursorPosition(GAME_AREA_LEFT, GAME_AREA_TOP + GAME_AREA_HEIGHT + 1);
            //Console.WriteLine("buffer: h=" + Console.BufferHeight.ToString() + " w=" + Console.BufferWidth.ToString());
            //Console.WriteLine("window: h=" + Console.WindowHeight.ToString() + " w=" + Console.WindowWidth.ToString());
            Console.WriteLine("Game Over. Press Enter to exit");
            Console.ReadLine();
        }
    }
}
