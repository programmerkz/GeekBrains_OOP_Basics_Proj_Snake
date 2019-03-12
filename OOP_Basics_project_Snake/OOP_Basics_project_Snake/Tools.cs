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

        public static void WaitingEnter()
        {
            Console.WriteLine("\r\n \r\n Press Enter to exit");
            Console.ReadLine();
        }
    }
}
