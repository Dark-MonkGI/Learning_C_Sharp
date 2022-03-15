using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Figure
    {
        protected List<Point> Pipline;
        public void Drow()
        {
            foreach (Point Line in Pipline)
            {
                Line.Draw();
            }
        }

        internal bool IsHit( Figure figure)
        {
            foreach(var p in Pipline)
            {
                if(figure.IsHit(p))
                    return true;
            } 
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in Pipline)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }



    }
}
