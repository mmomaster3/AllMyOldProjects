using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    public class Peak
    {
        public int Number { get; set; }
        public bool Mark { get; set; }
        public int Weight { get; set; }

        public Peak(int n, bool m = false)
        {
            Number = n;
            Mark = m;
            Weight = int.MaxValue;
        }
    }

    public class Edge
    {
        public Peak StartPeak { get; set; }
        public Peak EndPeak { get; set; }
        public int Weight { get; set; }

        public Edge() { }

        public Edge(Peak start, Peak end, int w)
        {
            this.StartPeak = start;
            this.EndPeak = end;
            this.Weight = w;
        }
    }

    public class Algorithm
    {
        List<Peak> lPeak { get; set; }
        List<Edge> lEdge { get; set; }
        Queue<Peak> queue = new Queue<Peak>();

        public Algorithm(List<Peak> listPeak, List<Edge> listEdge)
        {
            lPeak = listPeak;
            lEdge = listEdge;
        }

        private void CurrentExecute(Peak currPeak)
        {
            currPeak.Mark = true;
            var processing = (from le in lEdge

                              select le.StartPeak == currPeak ? le.EndPeak : le.StartPeak
                                                     ).ToList<Peak>();


            foreach (var i in processing)
                foreach (var l in lEdge)
                    if (((l.StartPeak == i && l.EndPeak == currPeak) || (l.StartPeak == currPeak && l.EndPeak == i)) && i.Weight > currPeak.Weight + l.Weight)
                    {
                        i.Weight = currPeak.Weight + l.Weight;
                        queue.Enqueue(i);
                    }
        }

        public int Execute(Peak start, Peak end)
        {
            start.Weight = 0;
            queue.Enqueue(start);
            while (queue.Count > 0)
                CurrentExecute(queue.Dequeue());
            return end.Weight;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> List = new Queue<int>();
            int[,] mas = new int[10, 10];

            mas[0, 1] = 10;
            mas[0, 2] = 30;
            mas[0, 4] = 10;
            mas[1, 2] = 45;
            mas[3, 2] = 20;
            mas[4, 0] = 10;
            mas[5, 3] = 35;
            mas[6, 7] = 10;
            mas[8, 3] = 20;
            mas[2, 4] = 15;
            mas[3, 6] = 1;
            mas[4, 3] = 30;
            mas[5, 9] = 10;
            mas[7, 2] = 100;
            mas[8, 6] = 5;
            mas[3, 1] = 40;
            mas[3, 8] = 20;
            mas[4, 5] = 5;
            mas[6, 3] = 1;
            mas[8, 6] = 5;
            mas[9, 8] = 50;

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write("{0,5} ", mas[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Введите вершины: ");

            int sp = int.Parse(Console.ReadLine());
            int ep = int.Parse(Console.ReadLine());

            Console.WriteLine();
            int weight = 0;
            string result = "";

            do
            {
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        if (mas[i, j] != 0)
                        {
                            if (j == ep)
                            {
                                if (i == sp)
                                {
                                    Console.WriteLine($"i = {i} j = {j} вес = {mas[i, j] + weight}");
                                }
                                else
                                {
                                    Console.WriteLine($"i = {i}");
                                    List.Enqueue(i);
                                    weight = mas[i, j];
                                }
                            }
                        }
                    }
                }

                Console.WriteLine();
                foreach (var i in List)
                    Console.Write(i + " ");


                
                ep = List.Dequeue();
                Console.ReadLine();
            } while (true);





            //{ new Edge(p1, p2, 10),  new Edge(p1, p3, 30),  new Edge(p1, p5, 10),
            //                                new Edge(p2, p3, 45), new Edge(p3, p5, 15), new Edge(p4, p2, 40),
            //                                new Edge(p4, p3, 20),  new Edge(p4, p7, 1),  new Edge(p4, p9, 20),
            //                                new Edge(p5, p1, 10),  new Edge(p5, p4, 30),  new Edge(p5, p6, 5),
            //                                new Edge(p6, p4, 35),  new Edge(p6, p10, 10),  new Edge(p7, p4, 1),
            //                                new Edge(p7, p8, 10),  new Edge(p8, p3, 100),  new Edge(p9, p7, 5),
            //                                new Edge(p9, p4, 20),  new Edge(p9, p7, 5),  new Edge(p10, p9, 50)
            //                              };
            //Algorithm alg = new Algorithm(p, e);

            //Console.WriteLine(alg.Execute(p1, p10));
            Console.ReadLine();
        }
    }
}
