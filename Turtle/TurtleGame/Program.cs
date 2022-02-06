using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;


namespace TurtleGame
{
    internal class Program
        
    {
        static void Main(string[] args)
        { 
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            
            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(10, 10);
            int X = 200;
            int Y = 200;

            Shapes.Move(eat, X, Y);
            Random rand = new Random();

            Turtle.Speed = 5;
            
            Turtle.PenUp();
            while (true)
            {
                //Console.WriteLine(Turtle.X.ToString());
                Turtle.Move(10);
                
                if (Turtle.X >= X && Turtle.X <= X + 10 && Turtle.Y >= Y && Turtle.Y <= Y + 10)
                {
                    X = rand.Next(0, GraphicsWindow.Width);
                    Y = rand.Next(0, GraphicsWindow.Height);

                    Shapes.Move(eat, X, Y);
                    Turtle.Speed++;
                }
            }
            
        }

        private static void GraphicsWindow_KeyDown()
        {
           if ( GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
           else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
           else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
        }
    }
}
