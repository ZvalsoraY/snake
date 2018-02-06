using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        public List<Point> pListV;

        public VerticalLine(int yL, int yH, int x, char sym)
        {
            pListV = new List<Point>();
            for( int y= yL; y <= yH; y++)
            {
                Point p = new Point(x, y, sym);
                pListV.Add(p);

            }
            
        }

        public void Drow()
        {
            foreach(Point p in pListV)
            {
                p.Draw();
            }
        }
    }
}
