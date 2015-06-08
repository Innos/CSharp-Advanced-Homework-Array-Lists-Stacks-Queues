using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembersAndNamespaces
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D point1, Point3D point2)
        {
            var a = (point1.X - point2.X) * (point1.X - point2.X);
            var b = (point1.Y - point2.Y) * (point1.Y - point2.Y);
            var c = (point1.Z - point2.Z) * (point1.Z - point2.Z);
            return Math.Sqrt(a+b+c);
        }
    }
}
