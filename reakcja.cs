using System;
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.SetCursorPosition(0,0);
            Console.CursorVisible = false;
            int x=0;
            int y=0;
            for (int i=0;i<100;i++)
            {
            if ( Console.ReadKey().Key == ConsoleKey.RightArrow)
            {
                    Console.Clear();
                    x++;
                    Console.SetCursorPosition(x,y);
                    Console.Write("X");
            }
            if ( Console.ReadKey().Key == ConsoleKey.LeftArrow)
            {
                    Console.Clear();
                    x--;
                    Console.SetCursorPosition(x,y);
                    Console.Write("X");
            }
            if ( Console.ReadKey().Key == ConsoleKey.UpArrow)
            {
                    Console.Clear();
                    y--;
                    Console.SetCursorPosition(x,y);
                    Console.Write("X");
            }
            if ( Console.ReadKey().Key == ConsoleKey.DownArrow)
            {
                    Console.Clear();
                    y++;
                    Console.SetCursorPosition(x,y);
                    Console.Write("X");
            }
            }
            Console.CursorVisible = true;
        }
    }
