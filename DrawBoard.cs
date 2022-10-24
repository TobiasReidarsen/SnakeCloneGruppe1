using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SnakeCloneGruppe1
{
    public class DrawBoard
    {
        public const int SizeX = 32; // widht
        public const int SizeY = 32; // height
        public const int TotalSize = SizeX * SizeY;
        public const string wall = "# ";
        public const string empty = "  ";

        public static void DrawBoardFunc()
        {
            //DrawSnake snake = new DrawSnake();
            snake.InitSnake();

            for (int y = 1; y <= SizeY; y++)
            {
                for (int x = 1; x <= SizeX; x++)
                {
                    if ((x == 1) || (x == SizeY))
                    {
                        if (snake.xInitialSnakePosition.Contains(x) && snake.xInitialSnakePosition.Contains(y))
                        {
                            Console.Write(snake.SNAKE_BODY);
                        }
                        else 
                        {
                            Console.Write(wall);
                        }
                    }
                    else
                    {
                        if ((y == 1) || (y == SizeX))
                        {
                            Console.Write(wall);
                        }
                        else
                        {
                            Console.Write(empty);
                        }
                    }

                }
                Console.Write("\n");
            }

        }
    }  
}

