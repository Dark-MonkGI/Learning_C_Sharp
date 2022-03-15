using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            //Отрисовка рамки
            HorizontalLine HorizontalUPLine = new HorizontalLine(0, mapWidth - 2, 0, '-');
            HorizontalLine HorizontalDownLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '-');
            VerticalLine VerticalRaightLine = new VerticalLine(1, mapHeight - 2, mapWidth - 1, '|');
            VerticalLine VerticalLeftLine = new VerticalLine(1, mapHeight - 2, 0, '|');

            //HorizontalUPLine.Drow();
            //HorizontalDownLine.Drow();
            //VerticalRaightLine.Drow();
            //VerticalLeftLine.Drow();

            wallList.Add(HorizontalUPLine);
            wallList.Add(HorizontalDownLine);
            wallList.Add(VerticalRaightLine);
            wallList.Add(VerticalLeftLine);


        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;

        }

        public void Drow()
        {
            foreach (var wall in wallList)
            {
                wall.Drow();
            }
        }
    }
}
