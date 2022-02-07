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
            Point OnePoint = new Point();
            OnePoint.X = 1;
            OnePoint.Y = 3;
            OnePoint.symbol = '*';
            OnePoint.Draw();

          



            Console.ReadLine();

        }
        
    }
}
