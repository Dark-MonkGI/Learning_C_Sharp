using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Point
    {
        public int X;
        public int Y;
        public char symbol;

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(symbol);
        }
    }
}
