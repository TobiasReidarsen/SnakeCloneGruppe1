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
        public static void DrawBoard_()
        {
            int height = 7;
            int width = 7;
            char wall = '#';
            int columnCount = height * width;
            List<string> board = new List<string>();

            // wall = #

            for (int i = 0; i < columnCount; i++)  // i står for width
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (i == 0 || i == columnCount - 1)
                    {
                        Write(wall);
                    } 
                    else if (j == 0 || j == columnCount - 1)
                    {
                        Write(wall);
                    }
                    else
                    {
                        Write(' ');
                    }
                }
                WriteLine();
            }
        }
    }  
}

