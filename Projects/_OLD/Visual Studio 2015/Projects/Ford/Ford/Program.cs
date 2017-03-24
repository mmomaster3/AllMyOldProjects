using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ford
{
    class Peak
    {
        int Name;
        int Weight;

        public Peak(int n)
        {
            Name = n;
        }
    }

    class Edge
    {
        public Peak StartPeak { get; set; }
        public Peak EndPeak { get; set; }
        public int Weigth { get; set; }
        public int Fill { get; set; }
        public bool IsIncident { get; set; }

        public Edge(Peak start, Peak end, int w, bool inc)
        {
            StartPeak = start;
            EndPeak = end;
            Weigth = w;
            IsIncident = inc;
        }
    }

    class Way
    {
        public int MinEdge { get; set; }
        public bool Mark { get; set; }


        public Way(int min, bool mark)
        {
            MinEdge = min;
            Mark = mark;
        }
    }

    class Algorithm
    {
        List<Peak> lPeak { get; set; }
        List<Edge> lEdge { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Peak p1 = new Peak(1); Peak p2 = new Peak(2); Peak p3 = new Peak(3); Peak p4 = new Peak(4);
            Peak p5 = new Peak(5); Peak p6 = new Peak(6); Peak p7 = new Peak(7); Peak p8 = new Peak(8);
            Peak p9 = new Peak(9); Peak p10 = new Peak(10); Peak p11 = new Peak(11); Peak p12 = new Peak(12);
            Peak p13 = new Peak(13); Peak p14 = new Peak(14);

            List<Peak> p = new List<Peak> { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14 };
            List<Edge> e = new List<Edge>
            {
                new Edge(p1, p2, 6, false), new Edge(p1, p3, 6, false),new Edge(p1, p4, 8, false),
                new Edge(p1, p5, 9, false),new Edge(p2, p6, 4, false),new Edge(p6, p10, 5, false),
                new Edge(p10, p14, 6, false),
                new Edge(p3, p7, 4, false),new Edge(p7, p11, 5, false),new Edge(p11, p14, 9, false),
                new Edge(p4, p8, 5, false),new Edge(p8, p12, 5, false),new Edge(p12, p0, 0, false),
                new Edge(p0, p0, 0, false),new Edge(p0, p0, 0, false),new Edge(p0, p0, 0, false),
                new Edge(p0, p0, 0, false),new Edge(p0, p0, 0, false),new Edge(p0, p0, 0, false),
                new Edge(p0, p0, 0, false),new Edge(p0, p0, 0, false),new Edge(p0, p0, 0, false),
                new Edge(p0, p0, 0, false),new Edge(p0, p0, 0, false),new Edge(p0, p0, 0, false),
                new Edge(p0, p0, 0, false),new Edge(p0, p0, 0, false),new Edge(p0, p0, 0, false),
                new Edge(p0, p0, 0, false),new Edge(p0, p0, 0, false),new Edge(p0, p0, 0, false);

        }
    }
}
