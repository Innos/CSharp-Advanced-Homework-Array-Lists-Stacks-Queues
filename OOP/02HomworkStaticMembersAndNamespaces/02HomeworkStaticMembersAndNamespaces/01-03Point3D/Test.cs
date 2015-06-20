using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembersAndNamespaces
{
    public class Point3DTest
    {
        static void Main()
        {
            Point3D test = new Point3D(5, 5, 5);
            Point3D test2 = new Point3D(2, 2, 2);
            var distance = DistanceCalculator.CalculateDistance(test, test2);

            Console.WriteLine(Point3D.StartingPoint.ToString());
            Console.WriteLine(test.ToString());
            Console.WriteLine(distance);

            Path3D points = new Path3D(test,test2);
            Storage.Write("file", points);
            Path3D testlist = Storage.Read("file");
            Console.WriteLine(testlist);
        }
    }
}
