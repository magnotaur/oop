using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    class Figure
    {
        protected List<Point> pList;
        public virtual void Draw()  //любой наследник этого метода благодаря virtual может написать свою реализацию
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
