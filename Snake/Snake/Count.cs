using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Count
    {
        public int x;
        public int y;
        public int z;

        public Count(int _x, int _y, int _z)
        {
            x = _x;
            y = _y;
            z = _z;

        }
        public void NumCount()
        {
            //Console.SetCursorPosition(x, y);
            //Console.Write(symbol);


            List<int> numList = new List<int>();

            numList.Add(x);
            numList.Add(y);
            numList.Add(z);

            numList.RemoveAt(numList.Count - 1);

            //int x = numList[0];
            //int y = numList[1];
            //int z = numList[2];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
