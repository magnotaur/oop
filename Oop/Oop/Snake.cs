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

        internal void Move()    //метод Move
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

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for(int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }

        public void Handlkey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)    //3. проверка чему же равна клавиша
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }

        internal bool Eat(Point food)   //метод Eat
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))       //если голова змейки находится в том же месте что и точка то змейка ее съест
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
