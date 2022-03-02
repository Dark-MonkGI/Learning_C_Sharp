﻿using System;
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
                Line.Drow();
            }
        }
    }
}
