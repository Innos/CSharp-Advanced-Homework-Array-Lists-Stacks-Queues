package _01_Geometry;

import _01_Geometry.Interfaces.Vertex;

import java.util.List;

public abstract class Shape {
    protected List<Vertex> vertices;

    protected Shape(List<Vertex> vertices){
        this.vertices = vertices;
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();
        result.append(String.format("\tCoordinates: %s\n",this.vertices));
        return result.toString();
    }
}
