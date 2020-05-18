using System;
using System.Collections.Generic;
using System.Text;

namespace lect_14.Task2
{
    class Neighbor
    {
        public string Name { get; set; }
        public int NFlat { get; set; }
        public string Number { get; set; }

        public Neighbor(string name, int flat, string numb)
        {
            Name = name;
            NFlat = flat;
            Number = numb;
        }
    }
}
