using System;
using System.Collections.Generic;
using System.Text;

namespace lect11.Shapes
{
    class Square : Shape
    {
        public int Side { get; set; }

        public Square(int side)
        {
            Side = side;
        }
    }
}
