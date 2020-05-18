using System;
using System.Collections.Generic;
using System.Text;

namespace Lect_12
{
    class UnigueItem
    {

        static public int Id;

        public UnigueItem()
        {
            Id++;
        }

        public UnigueItem(int id)
        {
            Id = id;
            Id++;
        }

        
    }
}
