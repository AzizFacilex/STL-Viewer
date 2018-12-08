using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StlReader
{
   public class Pointlist
    { 
        public Dictionary<Point, List<line>> d;
        public Pointlist ()
        {
            d = new Dictionary<Point,List<line>>();
        }
        public void add(Point a, line l = null)
        {
            if (!d.ContainsKey(a))
            {
                List<line> list = new List<line>();
                d[a] = list; 
            }
            if (l != null)
            {
                d[a].Add(l);
            }
        }
        public void add (line a)
        {
            this.add(a.point_start, a);
            this.add(a.point_end, a);
        }

    /* public  Linelist  Line_construction()
        {
          line l = new line();
            Linelist liste = new Linelist();
            for (int i=0;i<pointliste.Count;i=i+3)
            {
                l.point_start = pointliste[i];
                l.point_end = pointliste[i + 1];
                liste.add(l);
                l.point_start = pointliste[i];
                l.point_end = pointliste[i + 2];
                liste.add(l);
                l.point_start = pointliste[i+1];
                l.point_end = pointliste[i+2];
                liste.add(l);
            }
            return liste;


        }*/
    }
    

}

