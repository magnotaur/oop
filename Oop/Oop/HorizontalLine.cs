using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xReight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xReight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
            
        }

        public override void Draw() //альтернативная реализация метода Draw благодаря virtual
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Draw();

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
