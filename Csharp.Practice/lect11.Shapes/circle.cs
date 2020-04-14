using System;
using System.Collections.Generic;
using System.Text;

namespace lect11.Shapes
{
    class circle : Shape
    {
        public int Radius { get; set; }
        public circle(int r)
        {
            Radius = r;
        }

        public override int getArea()
        {
            int area = 3 * a * a;
            return area;
        }

       
    }

    
}
