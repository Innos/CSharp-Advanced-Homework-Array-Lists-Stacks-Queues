import java.util.Scanner;

public class RectangleArea {
    public static void main(String[] args) {
        System.out.println("Enter side a:");
        Scanner scanner = new Scanner(System.in);
        int a = scanner.nextInt();
        System.out.println("Enter side b:");
        int b = scanner.nextInt();
        System.out.printf("Area:%d",a*b);
    }
}
