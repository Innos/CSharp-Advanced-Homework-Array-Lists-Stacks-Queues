package _01_Geometry.ThreeDimensional;

public class SquarePyramid extends SpaceShape {

    private double side;

    private double height;

    public SquarePyramid(Vertex3D centre, double side, double height) {
        super(centre);

        this.setSide(side);
        this.setHeight(height);
    }

    public double getSide() {
        return side;
    }

    public void setSide(double side) {
        if(side <= 0){
            throw new IllegalArgumentException("Base width cannot be zero or less.");
        }
        this.side = side;
    }

    public double getHeight() {
        return height;
    }

    private void setHeight(double height) {
        if(height<= 0){
            throw new IllegalArgumentException("Height cannot be zero or less.");
        }
        this.height = height;
    }

    @Override
    public double getArea() {
        double sideSquared = this.side * this.side;
        return sideSquared + 2 * this.side * Math.sqrt((sideSquared / 4) + (this.height * this.height));
    }

    @Override
    public double getVolume() {
        return (this.side * this.side) * (this.height /3);
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();
        result.append("SquarePyramid\n");
        result.append(String.format("\tCoordinates: %s\n",this.vertices));
        result.append(String.format("\tBaseWidth: %.2f\n",this.side));
        result.append(String.format("\tHeight: %.2f\n",this.height));
        result.append(String.format("\tVolume: %.2f\n",this.getVolume()));
        result.append(String.format("\tArea: %.2f\n",this.getArea()));
        return result.toString();
    }
}
