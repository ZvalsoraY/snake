using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Func1(x);
            Console.WriteLine("x="+x);

            Func2(x);
            Console.WriteLine("Func2.x"+x);
            

            Point p1 = new Point(1,3,'*');
            p1.Draw();
            Move(p1, 10, 10);
            p1.Draw();


            Point p2 = new Point(4,5,'#');
            p2.Draw();
            
            Console.ReadLine();
        }
        public static void Func1(int value)
        {

        }
        public static void Func2(int value)
        {
            value = value + 1;
        }
        public static void Move(Point p,int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }
    }
}
