using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StlReader
{
    public class Normal_vector
    {
        public float x, y, z;
        public Normal_vector ()
        { x = y = z = 0; }
        public Normal_vector(float a, float b, float c)
        {
            x = a;
            y = b;
            z = c;
        }
        public override string ToString()
        {
            return (" Vector(" + x + ";" + y + ";" + z + ") ");


        }
    }
}
