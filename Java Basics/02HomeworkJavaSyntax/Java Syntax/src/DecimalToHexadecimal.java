import java.util.Scanner;

public class DecimalToHexadecimal {
    public static void main(String[] args) {

        System.out.println("Enter an integer:");
        Scanner scanner = new Scanner(System.in);
        int num = scanner.nextInt();

        System.out.printf("%X",num);
    }
}
