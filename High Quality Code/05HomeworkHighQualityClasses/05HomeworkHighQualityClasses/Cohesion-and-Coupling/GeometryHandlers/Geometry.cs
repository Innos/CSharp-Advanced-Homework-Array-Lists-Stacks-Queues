namespace CohesionAndCoupling.GeometryHandlers
{
    using System;

    public static class Geometry
    {
        public static double CalculateDistance2D(double x1, double y1, double x2, double y2)
        {
            double distanceX = (x2 - x1) * (x2 - x1);
            double distanceY = (y2 - y1) * (y2 - y1);
            double distance = Math.Sqrt(distanceX + distanceY);
            return distance;
        }

        public static double CalculateDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distanceX = (x2 - x1) * (x2 - x1);
            double distanceY = (y2 - y1) * (y2 - y1);
            double distanceZ = (z2 - z1) * (z2 - z1);
            double distance = Math.Sqrt(distanceX + distanceY + distanceZ);
            return distance;
        }

        public static double CalculateVolume(double width, double height, double depth)
        {
            double volume = width * height * depth;
            return volume;
        }
    }
}
