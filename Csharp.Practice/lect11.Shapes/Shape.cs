using System;
using System.Collections.Generic;
using System.Text;

namespace lect11.Shapes
{
   public  class  Shape
    {
        public  string Name { get; set; }

        public int Value { get; set; }

        public virtual double GetArea()
        {
            return 0;
        }

    }
}
