using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StlReader
{
  public  class Linelist
    {
     
     public   Dictionary<line, List<Surface>> d;
    public    Linelist ()
        { 
          d = new Dictionary<line, List<Surface>>();
        }
    /*    public List<line> IstVollständig()
        {
            List<line> L = new List<line>();
            foreach (StlReader.line s in Lineliste)
                if (s.repetition % 2 != 0)
                { line a = new line();
                    a.point_end = s.point_end;
                    a.point_start = s.point_start;
                    L.Add(a);
                }
            return L;
        }*/
        public void add(StlReader.line a)
        {

            if (!d.ContainsKey(a))
            {
                List<Surface> l = new List<Surface>();
                d.Add(a, l);
            }
         
        }
        public void add(Surface a)
        { d[a.line1].Add(a);
            d[a.line2].Add(a);
            d[a.line3].Add(a);
        }
    }
}
