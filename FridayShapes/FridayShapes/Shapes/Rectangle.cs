using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FridayShapes.Shapes;


namespace FridayShapes.Shapes
{
    class Rectangle : Shape
    {

        public Rectangle(int h, int w)
        {
        }
        public Rectangle()
        {
        }


        // DERIVED CLASS

        public int getArea(int w, int h)
        {
           
            return (w * h);
        }


    }
}
