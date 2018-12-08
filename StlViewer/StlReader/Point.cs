using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StlReader
{
    public class Point
    {
       public float x, y, z;
        public Point()
        { x = y = z = 0; }
        public Point(float a, float b, float c)
        {
            x = a;
            y = b;
            z = c;
        }
        public override string ToString()
        {
            return (" Point("+x+";"+y+";"+z+") ");
        }
    }
}
