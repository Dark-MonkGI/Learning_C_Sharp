using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize( 120, 30);

            // Рамка
            HorizontalLine HorizontalUPLine = new HorizontalLine(0, 118, 0, '-');
            HorizontalLine HorizontalDownLine = new HorizontalLine(0, 118, 29, '-');
            VerticalLine VerticalRaightLine = new VerticalLine(1, 28, 119, '|');
            VerticalLine VerticalLeftLine = new VerticalLine(1, 28, 0, '|');
            
            HorizontalUPLine.Drow();
            HorizontalDownLine.Drow();
            VerticalRaightLine.Drow();
            VerticalLeftLine.Drow();

            // Змейка
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(120, 30, '$');
            Point food = foodCreator.CreateFood();
            food.Drow();


            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Drow();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

            //Console.ReadLine();

        }
        
    }
}
