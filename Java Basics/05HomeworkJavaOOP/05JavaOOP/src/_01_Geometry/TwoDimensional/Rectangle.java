package _01_Geometry.TwoDimensional;

public class Rectangle extends PlaneShape {

    private double width;

    private double height;

    public Rectangle(Vertex2D startingPoint, double width, double height) {
        super(startingPoint);

        this.setWidth(width);
        this.setHeight(height);
    }

    public double getWidth() {
        return width;
    }

    private void setWidth(double width) {
        if(width <= 0){
            throw new IllegalArgumentException("Width cannot be zero or less.");
        }
        this.width = width;
    }

    public double getHeight() {
        return height;
    }

    private void setHeight(double height) {
        if(height <= 0){
            throw new IllegalArgumentException("Height cannot be zero or less.");
        }
        this.height = height;
    }

    @Override
    public double getArea() {
        return this.width * this.height;
    }

    @Override
    public double getPerimeter() {
        return 2 * (this.width + this.height);
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();
        result.append("Rectangle\n");
        result.append(String.format("\tCoordinates: %s\n",this.vertices));
        result.append(String.format("\tWidth: %.2f\n",this.width));
        result.append(String.format("\tHeight: %.2f\n",this.height));
        result.append(String.format("\tPerimeter: %.2f\n",this.getPerimeter()));
        result.append(String.format("\tArea: %.2f\n",this.getArea()));
        return result.toString();
    }
}
