using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtlePleaseRun
{
    internal class Program
    {
        static void LetterI()
        {
            Turtle.X = 100;
            Turtle.Y = 200;

            Turtle.Angle = 180;
            Turtle.Move(60);
            Turtle.Angle = 30;
            Turtle.Move(70);
            Turtle.Angle = 180;
            Turtle.Move(60);
        }
        static void letterL()
        {
            Turtle.X = 150;
            Turtle.Y = 260;

            Turtle.Angle = 20;
            Turtle.Move(60);
            Turtle.Angle = 160;
            Turtle.Move(60);

        }

        static void letterY(int size)
        {
            Turtle.X = 205;
            Turtle.Y = 202;

            Turtle.Angle = 180;
            Turtle.Move(58);

            for(int i = 0; i < 3; i++)
            {
                Turtle.TurnLeft();
                Turtle.Move(size);
            }
        }
        static void letterYa(int size)
        {
            Turtle.X = 250;
            Turtle.Y = 260;

            Turtle.Angle = 32;
            Turtle.Move(40);
            Turtle.Angle = 0;
            Turtle.Move(size);
            for (int i = 0; i < 3; i++)
            {
                Turtle.TurnLeft();
                Turtle.Move(size);
            }
            Turtle.Angle = 180;
            Turtle.Move(35);
        }

        static void snake()
        {
            Turtle.X = 275;
            Turtle.Y = 280;

            int i = 0;

            while (i < 4)
            {
                Turtle.Move(25);
                Turtle.TurnRight();
                Turtle.Move(25);
                Turtle.TurnRight();
                Turtle.Move(25);
                Turtle.TurnLeft();
                Turtle.Move(25);
                Turtle.TurnLeft();
                i++;
            }
            
        }
        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            int lenletter = 25;

            LetterI();
            letterL();
            letterY(lenletter);
            letterYa(lenletter);

            snake();
            Turtle.Hide();

        }
    }
}
