using System;
using System.Collections.Generic;
using System.Text;

namespace lect11.Shapes
{
   abstract class  Shape
    {
        public virtual int getArea(int a, int b)
        {
            return a * b;
        }

        public virtual int getArea(int a)
        {
            return a * a;
        }
    }
}
