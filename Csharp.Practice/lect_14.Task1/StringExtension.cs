using System;
using System.Collections.Generic;
using System.Text;

namespace lect_14.Task1
{
  public static class StringExtension
    {
        public static string StringExt(this string str)
        {
           string x = str.Remove(5);
           return x + "...";
        }
    }
}
