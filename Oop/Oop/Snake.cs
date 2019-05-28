using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    class Snake : Figure
    {
        Direction direction;    //1. после создания метода Move делаем чтобы класс змейка хранил данные направления
        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;  //2. после создания метода Move
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {                                    //в цикле создаются точки, копии хвостовой точки
                Point p = new Point(tail);      //увеличение змейки на 1 точку
                p.Move( i, direction);          //сдвигаем точку i позиции по направлению direction
                pList.Add(p);                   //занесение добавленной точки в список
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
