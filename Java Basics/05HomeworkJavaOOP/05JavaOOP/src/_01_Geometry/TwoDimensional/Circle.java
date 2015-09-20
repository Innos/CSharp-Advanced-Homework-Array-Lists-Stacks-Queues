package _01_Geometry.TwoDimensional;

public class Circle extends PlaneShape {

    private double radius;

    public Circle(Vertex2D centre, double radius){
        super(centre);

        this.setRadius(radius);
    }

    public double getRadius() {
        return radius;
    }

    private void setRadius(double radius) {
        if(radius <= 0){
            throw new IllegalArgumentException("Radius cannot be zero or less.");
        }
        this.radius = radius;
    }

    @Override
    public double getArea() {
        return Math.PI * this.radius * this.radius;
    }

    @Override
    public double getPerimeter() {
        return 2 * Math.PI * this.radius;
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();
        result.append("Circle\n");
        result.append(String.format("\tCoordinates: %s\n",this.vertices));
        result.append(String.format("\tRadius: %.2f\n",this.radius));
        result.append(String.format("\tPerimeter: %.2f\n",this.getPerimeter()));
        result.append(String.format("\tArea: %.2f\n",this.getArea()));
        return result.toString();
    }
}
