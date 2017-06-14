using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Console.WriteLine();
            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p1);

            Point t1 = new Point(10, 10, '@');
            Point t2 = new Point(30, 10, '#');
            Point t3 = new Point(10, 20, '$');
            Point t4 = new Point(30, 20, '%');

            List<Point> myListPoint = new List<Point>();
            myListPoint.Add(t1);
            myListPoint.Add(t2);
            myListPoint.Add(t3);
            myListPoint.Add(t4);

            foreach (Point i in myListPoint)
            {
                i.Draw();
            }

            Console.ReadLine();
        }

        

    }
}

