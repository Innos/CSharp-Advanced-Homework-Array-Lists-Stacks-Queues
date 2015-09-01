import java.util.Scanner;

public class TriangleArea {
    public static void main(String[] args) {
        System.out.println("Enter point A's X and Y(integers):");
        Scanner scanner = new Scanner(System.in);
        int Ax = scanner.nextInt();
        int Ay = scanner.nextInt();
        System.out.println("Enter point B's X and Y(integers):");
        int Bx = scanner.nextInt();
        int By = scanner.nextInt();
        System.out.println("Enter point C's X and Y(integers):");
        int Cx = scanner.nextInt();
        int Cy = scanner.nextInt();

        double area = Math.abs((Ax*(By-Cy) + Bx*(Cy-Ay) + Cx*(Ay-By))/2);
        System.out.println(Math.round(area));
    }
}
