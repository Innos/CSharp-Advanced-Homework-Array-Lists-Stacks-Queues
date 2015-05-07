using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
    public double CalculateDistance(Point target)
    {
        int dx = target.X - this.X;
        int dy = target.Y - this.Y;
        double distance = Math.Sqrt(dx * dx + dy * dy);
        return distance;
    }
}
public class Polygon
{
    private List<Point> points;

    public Polygon(List<Point> points)
    {
        this.points = points;
        points.Add(points[0]);
    }

    public double Area
    {
        get
        {
            return CalculateArea(points);
        }
    }

    public double Perimeter
    {
        get
        {
            return CalculatePerimeter(points);
        }
    }

    public double CalculateArea(List<Point> points)
    {
        double area = 0;
        for (int i = 0; i < points.Count() - 1; i++)
        {
            area = area + ((points[i].X * points[i + 1].Y) - (points[i].Y * points[i + 1].X));
        }
        area = Math.Abs(area / 2);
        return area;
    }

    public double CalculatePerimeter(List<Point> points)
    {
        double perimeter = 0;
        for (int i = 0; i < points.Count()-1; i++)
        {
            perimeter = perimeter + points[i].CalculateDistance(points[i + 1]);
        }
        return perimeter;
    }
}

class PerimeterAndAreaOfPolygon
{
    static void Main(string[] args)
    {
        List<Point> input = new List<Point>();
        int numberOfPoints = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfPoints; i++)
        {
            string[] inp = Console.ReadLine().Split(' ');
            int x = int.Parse(inp[0]);
            int y = int.Parse(inp[1]);
            Point currentPoint = new Point(x, y);
            input.Add(currentPoint);
        }
        Polygon pol = new Polygon(input);
        Console.WriteLine("Area is: {0:F2}",pol.Area);
        Console.WriteLine("Perimeter is: {0:F2}",pol.Perimeter);
    }
}

