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
            Point OnePoint = new Point(1, 3, '*');
            Count MyCount = new Count(2, 4, 5);
            HorizontalLine Line = new HorizontalLine(5, 10, 6, '*');
           

            //OnePoint.X = 1;
            //OnePoint.Y = 3;
            //OnePoint.symbol = '*';

            OnePoint.Drow();
            MyCount.NumCount();
            Line.Drow();            
            Console.ReadLine();


            //List<Point> points = new List<Point>();
            //points.Add(OnePoint);
            //Console.SetCursorPosition(points[0].x, points[0].y);
            //Console.Write(points[0].symbol);
            //Console.ReadLine();

        }
        
    }
}
