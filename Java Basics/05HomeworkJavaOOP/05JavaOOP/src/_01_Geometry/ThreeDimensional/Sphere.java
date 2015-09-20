package _01_Geometry.ThreeDimensional;

public class Sphere extends SpaceShape {

    private double radius;

    public Sphere(Vertex3D centre, double radius) {
        super(centre);

        this.setRadius(radius);
    }

    public double getRadius() {
        return radius;
    }

    private void setRadius(double radius) {
        if (radius <= 0) {
            throw new IllegalArgumentException("Radius cannot be zero or less.");
        }
        this.radius = radius;
    }

    @Override
    public double getArea() {
        return 4 * Math.PI * this.radius * this.radius;
    }

    @Override
    public double getVolume() {
        return (4 * Math.PI * this.radius * this.radius * this.radius) / 3;
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();
        result.append("Sphere\n");
        result.append(String.format("\tCoordinates: %s\n",this.vertices));
        result.append(String.format("\tRadius: %.2f\n",this.radius));
        result.append(String.format("\tVolume: %.2f\n",this.getVolume()));
        result.append(String.format("\tArea: %.2f\n",this.getArea()));
        return result.toString();
    }
}
