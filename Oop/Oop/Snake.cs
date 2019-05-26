using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    class Snake : Figure
    {
        public Snake(Point tail, int lenght, Direction direction)
        {
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {                                    //в цикле создаются точки, копии хвостовой точки
                Point p = new Point(tail);      //увеличение змейки на 1 точку
                p.Move( i, direction);          //сдвигаем точку i позиции по направлению direction
                pList.Add(p);                   //занесение добавленной точки в список
            }
        }
    }
}
