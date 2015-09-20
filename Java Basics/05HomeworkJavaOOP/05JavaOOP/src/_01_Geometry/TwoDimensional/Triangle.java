package _01_Geometry.TwoDimensional;

public class Triangle extends PlaneShape {

    private double a;
    private double b;
    private double c;

    public Triangle(Vertex2D A, Vertex2D B, Vertex2D C) {
        super(A, B, C);

        this.a = B.calculateDistance(C);
        this.b = C.calculateDistance(A);
        this.c = A.calculateDistance(B);
    }

    public double getSideA() {
        return a;
    }

    public double getSideB() {
        return b;
    }

    public double getSideC() {
        return c;
    }

    @Override
    public double getArea() {

        double halfPerimeter = getPerimeter() / 2;
        return Math.sqrt(halfPerimeter * (halfPerimeter - this.getSideA()) * (halfPerimeter - this.getSideB()) * (halfPerimeter - this.getSideC()));
    }

    @Override
    public double getPerimeter() {
        return a + b + c;
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();
        result.append("Triangle\n");
        result.append(String.format("\tCoordinates: %s\n",this.vertices));
        result.append(String.format("\tSide A: %.2f\n",this.a));
        result.append(String.format("\tSide B: %.2f\n",this.b));
        result.append(String.format("\tSide C: %.2f\n",this.c));
        result.append(String.format("\tPerimeter: %.2f\n",this.getPerimeter()));
        result.append(String.format("\tArea: %.2f\n",this.getArea()));
        return result.toString();
    }
}
