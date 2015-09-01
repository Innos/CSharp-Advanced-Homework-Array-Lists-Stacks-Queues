import java.util.Scanner;

public class CountOfBits1 {
    public static void main(String[] args) {
        System.out.println("Enter an integer:");
        Scanner scanner = new Scanner(System.in);
        int number = Integer.bitCount(scanner.nextInt());
        System.out.println(number);
    }
}
