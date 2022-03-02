using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class VerticalLine : Figure
    {
       
        public VerticalLine(int xUp, int xDown, int y, char symbol)
        {
            Pipline = new List<Point>();

            for (int i = xUp; i <= xDown; i++)
            {
                Point PointLine = new Point(y, i, symbol);
                Pipline.Add(PointLine);
            }
        }


    }
}
