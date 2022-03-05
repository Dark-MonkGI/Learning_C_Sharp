using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;

            Pipline = new List<Point>();

            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                Pipline.Add(p);

            }
        }

        internal void Move()
        {
            Point tail = Pipline.First();
            Pipline.Remove(tail);
            Point head = GetNextPoint();
            Pipline.Add(head);

            tail.Clear();
            head.Drow();

        }
        
        public Point GetNextPoint()
        {
            Point head = Pipline.Last();
            Point nextPoint = new Point( head );
            nextPoint.Move(1, direction);
            return nextPoint;

        }
    }
}
