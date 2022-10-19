using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCloneGruppe1
{
    public class DrawSnake
    {
        // make an initial position for snake
        // snake has initial size of 5
        // snake symbol is *
        public const string SNAKE_BODY = "X ";
        public static int InitialSnakeLenght = 5;
        public static List<int> xInitialSnakePosition = new List<int>();
        public static List<int> yInitialSnakePosition = new List<int>();

        public static void InitSnake()
        {
            for (int i = 0; i < InitialSnakeLenght; i++)
            {
                xInitialSnakePosition.Add(i);
                yInitialSnakePosition.Add(i + 1);
            }
            Console.WriteLine(xInitialSnakePosition.Count);
        }
    }
}
