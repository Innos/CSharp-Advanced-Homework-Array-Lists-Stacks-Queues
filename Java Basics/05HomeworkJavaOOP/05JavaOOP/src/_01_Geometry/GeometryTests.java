package _01_Geometry;


import _01_Geometry.ThreeDimensional.*;
import _01_Geometry.TwoDimensional.*;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

public class GeometryTests {
    public static void main(String[] args) {

        Vertex2D pointA = new Vertex2D(1,1);
        Vertex2D pointB = new Vertex2D(1,5);
        Vertex2D pointC = new Vertex2D(17,2);

        Vertex3D pointD = new Vertex3D(1,3,5);

        Triangle triangle = new Triangle(pointA,pointB,pointC);
        Rectangle rectangle = new Rectangle(pointA,4,6);
        Circle circle = new Circle(pointA,10);

        SquarePyramid pyramid = new SquarePyramid(pointD,2,10);
        Cuboid cuboid = new Cuboid(pointD,4,6,10);
        Sphere sphere = new Sphere(pointD,10);

        ArrayList<Shape> shapes = new ArrayList<>();
        shapes.add(triangle);
        shapes.add(rectangle);
        shapes.add(circle);
        shapes.add(pyramid);
        shapes.add(cuboid);
        shapes.add(sphere);

        List<Shape> result = shapes.stream()
                .filter(s -> s instanceof SpaceShape)
                .map(s->(SpaceShape)s)
                .filter(s-> s.getVolume() > 40)
                .collect(Collectors.toList());

        List<Shape> result2 = shapes.stream()
                .filter(s->s instanceof PlaneShape)
                .sorted()
                .collect(Collectors.toList());
        System.out.println("Search #1:");
        System.out.println(result);
        System.out.println();
        System.out.println("Search #2:");
        System.out.println(result2);
    }
}
