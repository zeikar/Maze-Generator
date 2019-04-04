using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator
{
    class Maze
    {
        public int[,] maze;
        int width, height;

        public Maze(int width, int height)
        {
            this.width = width;
            this.height = height;
            maze = new int[width, height];
        }

        public void SaveToFile()
        {
            string[] output = new string[height];

            output[0] = "{";

            for (int x = 0; x < height; x++)
            {
                if(x != 0)
                {
                    output[x - 1] += ",";
                }

                output[x] += "{";

                for (int y = 0; y < width; y++)
                {
                    if(y != 0)
                    {
                        output[x] += ",";
                    }

                    output[x] += maze[y, x].ToString();
                }

                output[x] += "}";
            }

            output[height - 1] += "};";

            System.IO.File.WriteAllLines("mazeArr.txt", output);
        }
    }
}
