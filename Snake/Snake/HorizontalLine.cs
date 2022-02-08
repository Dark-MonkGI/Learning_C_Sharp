using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class HorizontalLine
    {
        List<Point> Pipline;

        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            Pipline = new List<Point>();

            for (int i = xLeft; i <= xRight; i++)
            {
                Point PointLine = new Point(i, y, symbol);
                Pipline.Add(PointLine);
            }
        }

        public void Drow()
        {
            foreach(Point Line in Pipline)
            {
                Line.Drow();
            }
        }

    }
}
