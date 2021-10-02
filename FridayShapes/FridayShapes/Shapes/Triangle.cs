using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayShapes.Shapes
{
    sealed class Triangle : Rectangle
    {
        public int getAreaTri(int h, int w)
        {
            //int area = base.getArea();
            return (w * h ) / 2 ;
        }

        public Triangle(int h, int w)
        {
        }
        public Triangle()
        {
        }

    }
}
