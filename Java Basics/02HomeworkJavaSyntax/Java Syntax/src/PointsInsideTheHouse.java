import java.awt.*;
import java.util.Scanner;

public class PointsInsideTheHouse {

    private static double figAXstart = 12.5;
    private static double figAXend = 17.5;
    private static double figAYstart = 8.5;
    private static double figAYend = 13.5;

    private static double figBXstart = 20;
    private static double figBXend = 22.5;
    private static double figBYstart = 8.5;
    private static double figBYend = 13.5;

    private static double triangleAX = 12.5;
    private static double triangleAY = 8.5;
    private static double triangleBX = 22.5;
    private static double triangleBY = 8.5;
    private static double triangleCX = 17.5;
    private static double triangleCY = 3.5;

    public static void main(String[] args) {

        System.out.println("Enter X and Y:");
        Scanner scanner = new Scanner(System.in);
        double x = scanner.nextDouble();
        double y = scanner.nextDouble();

        if(isOutsideHouse(x,y)){
            System.out.println("Outside");
        } else {
            System.out.println("Inside");
        }
    }

    public static boolean isOutsideHouse(double x,double y){

        boolean isOutsideA = (x < figAXstart || x > figAXend) || (y < figAYstart || y > figAYend);
        boolean isOutsideB = (x < figBXstart || x > figBXend) || (y < figBYstart || y > figBYend);

        boolean isOutsideTriangle = isOutside(triangleAX, triangleAY, triangleBX, triangleBY, triangleCX, triangleCY, x, y);

        if(isOutsideA && isOutsideB && isOutsideTriangle) {
            return true;
        }
        return false;
    }

    private static double calculateArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        return Math.abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
    }

    private static boolean isOutside(double x1, double y1, double x2, double y2, double x3, double y3, double x, double y)
    {
   /* Calculate area of triangle ABC */
        double A = calculateArea(x1, y1, x2, y2, x3, y3);

   /* Calculate area of triangle PBC */
        double A1 = calculateArea(x, y, x2, y2, x3, y3);

   /* Calculate area of triangle PAC */
        double A2 = calculateArea(x1, y1, x, y, x3, y3);

   /* Calculate area of triangle PAB */
        double A3 = calculateArea (x1, y1, x2, y2, x, y);

   /* Check if sum of A1, A2 and A3 is same as A */
        return (A != A1 + A2 + A3);
    }
}
