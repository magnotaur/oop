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
            VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            Draw(v1);

            Point p = new Point(4, 5, '+');     //создание точки
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);   //создание змейки
            Draw(fSnake);
            Snake snake = (Snake) fSnake;

            HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();  //список фигур
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);

            foreach (var f in figures)  //у всех наследников класса фигуры есть метод Draw
            {
                f.Draw();
            }
            Console.ReadLine();
        }

        static void Draw(Figure figure)
        {
            figure.Draw();

        }
        
    }
    
}

           /* Console.SetBufferSize(80, 25);

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

            FoodCreator foodCreator = new FoodCreator(80, 25, '$'); // класс, который генерирует точки(еда), первые 2 цифры габариты экрана
            Point food = foodCreator.CreatFood();
            food.Draw();    //вывод этой точки на экран

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreatFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);


                if (Console.KeyAvailable)    //1. проверка на то, была ли нажата какая-либо клавиша с прошлого витка цикла
                {
                    ConsoleKeyInfo key = Console.ReadKey(); //2. получаем значение этой клавиши
                    snake.Handlkey(key.Key);
                }
            }
            
            Console.ReadLine(); 
        }
    }
}*/
