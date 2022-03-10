using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class FoodCreator
    {
        int mapWidht;
        int mapHidht;
        char symbol;

        Random random = new Random( );

        public FoodCreator(int mapWidht, int mapHidht, char symbol)
        {
            this.mapWidht = mapWidht;
            this.mapHidht = mapHidht;
            this.symbol = symbol;
        }

        public Point CreateFood()
        {
            int x = random.Next( 2, mapWidht - 2 );
            int y = random.Next( 2, mapHidht - 2 );
            return new Point(x, y, symbol);

        }

    }
}
