using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLines leftLine = new VerticalLines(0,24,0,'+');
            VerticalLines rightLine = new VerticalLines(0,24,78,'+');

            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(4, 5, '*');
            p.Draw();

           /* Point p1 = new Point(1, 3, '*');
            
            p1.Draw();
           
            Point p2 = new Point(4, 5, '#');
            
            p2.Draw();

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Drow();*/
           
            Console.ReadLine();
        }

      
    }
}
