package _01_Geometry.Interfaces;

import _01_Geometry.ThreeDimensional.Vertex3D;
import _01_Geometry.TwoDimensional.Vertex2D;

public interface Vertex {

    double getX();

    double getY();

    double calculateDistance(Vertex2D other);

    double calculateDistance(Vertex3D other);
}
