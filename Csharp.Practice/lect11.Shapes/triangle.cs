using System;
using System.Collections.Generic;
using System.Text;

namespace lect11.Shapes
{
    class triangle : Shape
    {
        public int _width { get; set; }
        public int _height { get; set; }

        public triangle (int width, int height)
        {
            _width = width;
            _height = height;
        }
        public override int getArea(int a, int b)
        {
            return 1 / 2 * a * b;
        }
    }
}
