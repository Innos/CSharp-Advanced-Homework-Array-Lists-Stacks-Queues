import java.util.Scanner;

public class PointsInsideAFigure {
    public static void main(String[] args) {
        System.out.println("Enter X and Y:");
        Scanner scanner = new Scanner(System.in);
        double x = scanner.nextDouble();
        double y = scanner.nextDouble();

        double figAXstart = 12.5;
        double figAXend = 17.5;
        double figAYstart = 8.5;
        double figAYend = 13.5;

        double figBXstart = 20;
        double figBXend = 22.5;
        double figBYstart = 8.5;
        double figBYend = 13.5;

        double figCXstart = 12.5;
        double figCXend = 22.5;
        double figCYstart = 6;
        double figCYend = 8.5;

        boolean isOutsideA = (x < figAXstart || x > figAXend) || (y < figAYstart || y > figAYend);
        boolean isOutsideB = (x < figBXstart || x > figBXend) || (y < figBYstart || y > figBYend);
        boolean isOutsideC = (x < figCXstart || x > figCXend) || (y < figCYstart || y > figCYend);

        if(isOutsideA && isOutsideB && isOutsideC){
            System.out.println("Outside");
        } else {
            System.out.println("Inside");
        }
    }
}
