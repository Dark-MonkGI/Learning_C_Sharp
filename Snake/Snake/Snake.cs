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
            head.Draw();

        }
        
        public Point GetNextPoint()
        {
            Point head = Pipline.Last();
            Point nextPoint = new Point( head );
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool IsHitTail()
        {
            var head = Pipline.Last();
            for(int i = 0; i < Pipline.Count - 2; i++)
            {
                if ( head.IsHit(Pipline[i]) )
                    return true;
            }
            return false;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }


        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.symbol = head.symbol;
                Pipline.Add(food);
                return true;
            }
            else
                return false;
        }



    }
}
