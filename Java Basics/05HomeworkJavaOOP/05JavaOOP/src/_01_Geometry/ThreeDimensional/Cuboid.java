package _01_Geometry.ThreeDimensional;

public class Cuboid extends SpaceShape {

    private double width;
    private double height;
    private double depth;

    public Cuboid(Vertex3D startingPoint, double width, double height, double depth) {
        super(startingPoint);

        this.setWidth(width);
        this.setHeight(height);
        this.setDepth(depth);
    }

    public double getWidth() {
        return width;
    }

    private void setWidth(double width) {
        if (width <= 0) {
            throw new IllegalArgumentException("Width cannot be zero or less.");
        }
        this.width = width;
    }

    public double getHeight() {
        return height;
    }

    private void setHeight(double height) {
        if (height <= 0) {
            throw new IllegalArgumentException("Height cannot be zero or less.");
        }
        this.height = height;
    }

    public double getDepth() {
        return depth;
    }

    private void setDepth(double depth) {
        if (depth <= 0) {
            throw new IllegalArgumentException("Depth cannot be zero or less.");
        }
        this.depth = depth;
    }

    @Override
    public double getArea() {
        double areaA = this.width * this.height;
        double areaB = this.width * this.depth;
        double areaC = this.height * this.depth;
        return 2 * (areaA + areaB + areaC);
    }

    @Override
    public double getVolume() {
        return this.width * this.height * this.depth;
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();
        result.append("Cuboid\n");
        result.append(String.format("\tCoordinates: %s\n",this.vertices));
        result.append(String.format("\tWidth: %.2f\n",this.width));
        result.append(String.format("\tHeight: %.2f\n",this.height));
        result.append(String.format("\tDepth: %.2f\n",this.depth));
        result.append(String.format("\tVolume: %.2f\n",this.getVolume()));
        result.append(String.format("\tArea: %.2f\n",this.getArea()));
        return result.toString();
    }
}
