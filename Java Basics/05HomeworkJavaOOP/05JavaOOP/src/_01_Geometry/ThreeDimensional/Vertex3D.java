package _01_Geometry.ThreeDimensional;


import _01_Geometry.Interfaces.Vertex;
import _01_Geometry.TwoDimensional.Vertex2D;

public class Vertex3D implements Vertex {

    private double x;
    private double y;
    private double z;

    public Vertex3D(double x, double y, double z) {
        this.setX(x);
        this.setY(y);
        this.setZ(z);
    }

    public double getX() {
        return x;
    }

    private void setX(double x) {
        this.x = x;
    }

    public double getY() {
        return y;
    }

    private void setY(double y) {
        this.y = y;
    }

    public double getZ() {
        return z;
    }

    private void setZ(double z) {
        this.z = z;
    }

    @Override
    public double calculateDistance(Vertex2D other) {
        double squaredDistance = Math.pow((this.getX() - other.getX()), 2) + Math.pow((this.getY() - other.getY()), 2) + Math.pow((this.getZ() - 0), 2);
        return Math.sqrt(squaredDistance);
    }

    @Override
    public double calculateDistance(Vertex3D other) {
        double squaredDistance = Math.pow((this.getX() - other.getX()), 2) + Math.pow((this.getY() - other.getY()), 2) + Math.pow((this.getZ() - other.getZ()), 2);
        return Math.sqrt(squaredDistance);
    }

    @Override
    public String toString() {
        return String.format("[x: %.2f, y: %.2f, z: %.2f]", this.x, this.y, this.z);
    }
}
