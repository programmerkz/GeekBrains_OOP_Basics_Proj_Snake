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
            ShowCaption();

            PrintChar(2, 2, '*');
            PrintChar(5, 7, '$');

            PressEnter();
        }



        static void ShowCaption()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("OOP Basics. Blank console application \"Snake\"");
        }
        static bool PrintChar(int x, int y, char ch)
        {
            if ((x < 0) || (y < 0))
                return false;
            else
            {
                Console.SetCursorPosition(x, y);
                Console.Write(ch);
                return true;
            }
        }
        static void PressEnter()
        {
            Console.WriteLine("\r\n \r\n Press Enter to exit");
            Console.ReadLine();
        }
    }
}
