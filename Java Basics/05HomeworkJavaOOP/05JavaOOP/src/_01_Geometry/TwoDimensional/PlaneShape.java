package _01_Geometry.TwoDimensional;

import _01_Geometry.Interfaces.AreaMeasurable;
import _01_Geometry.Interfaces.PerimeterMeasurable;
import _01_Geometry.Shape;

import java.util.Arrays;

public abstract class PlaneShape extends Shape implements AreaMeasurable,PerimeterMeasurable,Comparable<PlaneShape>{

    protected PlaneShape(Vertex2D...vertices) {
        super(Arrays.asList(vertices));
    }

    @Override
    public int compareTo(PlaneShape o) {
        return Double.compare(this.getPerimeter(),o.getPerimeter());
    }

    @Override
    public abstract String toString();
}
