using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        
        public VerticalLine(int yL, int yH, int x, char sym)
        {
            pList = new List<Point>();
            for( int y= yL; y <= yH; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }
            
        }
                
    }
}
