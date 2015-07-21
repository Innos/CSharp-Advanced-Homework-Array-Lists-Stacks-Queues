namespace CohesionAndCoupling
{
    using System;
    using CohesionAndCoupling.FileHandlers;
    using CohesionAndCoupling.GeometryHandlers;

    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileNameHandler.GetFileExtension("example"));
            Console.WriteLine(FileNameHandler.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameHandler.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileNameHandler.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileNameHandler.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameHandler.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", Geometry.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", Geometry.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            Console.WriteLine("Volume = {0:f2}", Geometry.CalculateVolume(3, 4, 5));

            // Redundant methods as CalculateDistance2D and CalculateDistance3D do exactly the same thing.
            // Console.WriteLine("Diagonal XYZ = {0:f2}", Geometry.CalculateDiagonalXYZ());
            // Console.WriteLine("Diagonal XY = {0:f2}", Geometry.CalculateDiagonalXY());
            // Console.WriteLine("Diagonal XZ = {0:f2}", Geometry.CalculateDiagonalXZ());
            // Console.WriteLine("Diagonal YZ = {0:f2}", Geometry.CalculateDiagonalYZ());
        }
    }
}
