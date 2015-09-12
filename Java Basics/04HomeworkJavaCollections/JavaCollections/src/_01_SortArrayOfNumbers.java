import java.util.Arrays;
import java.util.Scanner;

public class _01_SortArrayOfNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int length = scanner.nextInt();
        int[] numbers = new int[length];

        for (int i = 0; i < length; i++) {
            numbers[i] = scanner.nextInt();
        }

        Arrays.sort(numbers);
        System.out.println(Arrays.toString(numbers));
    }
}
