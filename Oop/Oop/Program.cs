using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Point p1 = new Point(1, 3, '+');
             p1.Draw();

             Point p2 = new Point(4, 5, '#');
             p2.Draw(); */

            Console.SetBufferSize(80, 25);

            //Отрисовка рамочки
            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();

            // Отриcовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake( p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();   //метод с помощью которого змейка будет двигаься

            while(true) //бесконечный цикл, который означает что код внутри скобочек будет выполняться вечно
            {
                if(Console.KeyAvailable)    //1. проверка на то, была ли нажата какая-либо клавиша с прошлого витка цикла
                {
                    ConsoleKeyInfo key = Console.ReadKey(); //2. получаем значение этой клавиши
                    snake.Handlkey(key.Key);
                }
                Thread.Sleep(100);  //4. после определения направления змейки, идет задержка на 100 милисекунд
                snake.Move();       //5. происходит смещение змейки
            }

            /* List<int> numList = new list<int>();
             numList.Add(0);
             numList.Add(1);
             numList.Add(2);

             int x = numList[0];
             int y = numList[1];
             int z = numList[2];

             foreach (int i in numList)
             {
                 Console.WriteLine(i);
             }

             numList.Remove(0);

             List<Point> pList = new List<Point>();
             pList.Add(p1);
             pList.Add(p2); */

            Console.ReadLine(); 
        }
    }
}
