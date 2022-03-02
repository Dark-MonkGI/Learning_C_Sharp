using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize( 120, 30);



            Point OnePoint = new Point(1, 3, '*');
            Count MyCount = new Count(2, 4, 5);

            HorizontalLine HorizontalUPLine = new HorizontalLine(0, 118, 0, '-');
            HorizontalLine HorizontalDownLine = new HorizontalLine(0, 118, 29, '-');
            VerticalLine VerticalRaightLine = new VerticalLine(1, 28, 119, '|');
            VerticalLine VerticalLeftLine = new VerticalLine(1, 28, 0, '|');
            

            //OnePoint.X = 1;
            //OnePoint.Y = 3;
            //OnePoint.symbol = '*';

            OnePoint.Drow();
            MyCount.NumCount();

            HorizontalUPLine.Drow();
            HorizontalDownLine.Drow();
            VerticalRaightLine.Drow();
            VerticalLeftLine.Drow();


            Snake snake = new Snake(p, 4, Derection.RIGHT);

            Console.ReadLine();


            //List<Point> points = new List<Point>();
            //points.Add(OnePoint);
            //Console.SetCursorPosition(points[0].x, points[0].y);
            //Console.Write(points[0].symbol);
            //Console.ReadLine();

        }
        
    }
}
